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
        public async Task SendMessage(string user, string message)
        {
            Console.WriteLine(user + ": " + message);
            await Clients.All.SendAsync("ReceiveMessage", user, message);
            //Zrobić żeby do konkretnego usera były wysyłane wiadomości;
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

        public async Task CreateConversation(int id)
        {
            Session session = new Session(_context);
            session.updateSession();

            if (id != -1)
            {
                string tk = HttpHelper.HttpContext.Session.GetString("SessionToken");

                if (tk != null)
                {
                    User logged = _context.User.First(user => user.token == tk);
                    
                    if (logged != null)
                    {
                        List<int> members = new List<int>();
                        members.Add(logged.ID);
                        members.Add(id);
                        Chat currentConversation = new Chat();
                        currentConversation.usersIDs = JsonConvert.SerializeObject(members);
                        Chat dbChat;
                        // TODO: Sprawdzić czy nie dodajemy do konwersacji dwa razy tego samego usera
                        // TODO: Updatować ostatnią aktywność użytkownika
                        if (_context.Chats.Any(chat => chat.usersIDs == currentConversation.usersIDs))
                        {
                            dbChat = _context.Chats.First(chat => chat.usersIDs == currentConversation.usersIDs);
                            dbChat.lastMessageTime = DateTime.Now;
                            _context.Update(dbChat);
                            await _context.SaveChangesAsync();
                        }
                        else
                        {
                            currentConversation.isGroupMessage = false;
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

    }
}
