using ChatMe.Classes;
using ChatMe.Data;
using ChatMe.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.SignalR;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatMe.Hubs
{
    public class ChatHub : Hub
    {
        private readonly ChatContext _context;


        public ChatHub(ChatContext context)
        {

            _context = context;

        }
        public async Task SendMessage(int conversationID, string message)
        {
            Session session = new Session(_context);
            session.updateSession();

            string tk = HttpHelper.HttpContext.Session.GetString("SessionToken");

            if (tk != null)
            {
                User logged = _context.User.First(user => user.token == tk);

                if (logged != null)
                {
                    if (_context.Chats.Any(chat => chat.chatID == conversationID))
                    {
                        Chat currentConversation = _context.Chats.First(chat => chat.chatID == conversationID);
                        List<int> members = JsonConvert.DeserializeObject<List<int>>(currentConversation.usersIDs);
                        if (members.Contains(logged.ID))
                        {
                            Message newMessage = new Message();
                            newMessage.chatID = currentConversation.chatID;
                            newMessage.createdTime = DateTime.Now;
                            newMessage.creatorID = logged.ID;
                            newMessage.messageContent = message;
                            currentConversation.lastMessageTime = newMessage.createdTime;
                            _context.Chats.Update(currentConversation);
                            _context.Messages.Add(newMessage);
                            await _context.SaveChangesAsync();
                            object messageInfo = new { newMessage.chatID, newMessage.createdTime, newMessage.creatorID, logged.displayName, logged.username, newMessage.messageContent, newMessage.messageID, newMessage.readedBy};
                            string messageJson = JsonConvert.SerializeObject(messageInfo);
                            foreach(int convUser in members)
                            {
                                BroadcastToGroup(convUser, messageJson);
                            }
                            
                        }
                    }
                }
            }


        }

        // User search
        public async Task SearchUser(string keyword)
        {

            Session session = new Session(_context);
            session.updateSession();
            if (!String.IsNullOrEmpty(keyword))
            {
                var listOfUsers = from user in _context.User
                                  where user.displayName.Contains(keyword) ||
                                  user.username.Contains(keyword) ||
                                  user.email.Contains(keyword)
                                  orderby user.displayName
                                  select new { user.ID, user.username, user.displayName, user.email, user.lastLogin };
                await Clients.Caller.SendAsync("UserSearchResponse", listOfUsers);
            }
            else
            {
                var empty = new object[0];
                await Clients.Caller.SendAsync("UserSearchResponse", empty);
            }

        }
        public async Task CreateConversation(string membersJson)
        {
            if (membersJson != "")
            {
                List<int> members = new List<int>();
                members = JsonConvert.DeserializeObject<List<int>>(membersJson);
                await CreateConversationFromList(members);
            }
        }
        private async Task CreateConversationFromList(List<int> members)
        {
            Session session = new Session(_context);
            session.updateSession();

            if (members.Count > 0)
            {
                string tk = HttpHelper.HttpContext.Session.GetString("SessionToken");

                if (tk != null)
                {
                    User logged = _context.User.First(user => user.token == tk);

                    if (logged != null)
                    {

                        members.Add(logged.ID);
                        members = members.Distinct().ToList();
                        members.Sort();
                        Chat currentConversation = new Chat();
                        currentConversation.usersIDs = JsonConvert.SerializeObject(members);
                        Chat dbChat;

                        if (_context.Chats.Any(chat => chat.usersIDs == currentConversation.usersIDs))
                        {
                            dbChat = _context.Chats.First(chat => chat.usersIDs == currentConversation.usersIDs);
                            dbChat.lastMessageTime = DateTime.Now;
                            _context.Update(dbChat);
                            await _context.SaveChangesAsync();
                        }
                        else
                        {
                            if (members.Count > 2)
                            {
                                currentConversation.isGroupMessage = true;
                            }
                            else
                            {
                                currentConversation.isGroupMessage = false;
                            }
                            currentConversation.lastMessageTime = DateTime.Now;
                            _context.Chats.Add(currentConversation);
                            await _context.SaveChangesAsync();
                            dbChat = _context.Chats.First(chat => chat.usersIDs == currentConversation.usersIDs);

                        }
                        await Clients.Caller.SendAsync("SwitchToConversation", dbChat.chatID);
                    }
                }


            }


        }



        public async Task AddToGroup(string groupName)
        => await Groups.AddToGroupAsync(Context.ConnectionId, groupName);

        public async Task RemoveFromGroup(string groupName)
        => await Groups.RemoveFromGroupAsync(Context.ConnectionId, groupName);

        public async Task BroadcastToGroup(int groupName, string messageJson)
        => await Clients.Group(groupName.ToString()).SendAsync("newMessage", messageJson);


        public async override Task OnConnectedAsync()
        {
            string tk = HttpHelper.HttpContext.Session.GetString("SessionToken");

            if (tk != null)
            {
                User logged = _context.User.First(user => user.token == tk);

                if (logged != null)
                {
                   await AddToGroup(logged.ID.ToString());
                }
            }
            await base.OnConnectedAsync();
        }
        public async override Task OnDisconnectedAsync(Exception exception)
        {
            string tk = HttpHelper.HttpContext.Session.GetString("SessionToken");

            if (tk != null)
            {
                User logged = _context.User.First(user => user.token == tk);

                if (logged != null)
                {
                    await RemoveFromGroup(logged.ID.ToString());
                }
            }
            await base.OnDisconnectedAsync(exception);
        }


    }
}
