using ChatMe.Data;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatMe.Models
{
    public class FrontChatItem
    {
        public FrontChatItem(Chat chat, User logged, ChatContext _context)
        {
            
            if(!String.IsNullOrEmpty(chatName))
            {
                chatName = chat.chatName;
            }
            else
            {
                List<int> members = JsonConvert.DeserializeObject<List<int>>(chat.usersIDs);
                users = new List<MemberUser>(); 
                members.Remove(logged.ID);
                foreach(int user in members)
                {
                    if (_context.User.FirstOrDefault(usr => usr.ID == user) != null){
                        users.Add(new MemberUser(_context.User.FirstOrDefault(usr => usr.ID == user)));
                        if (String.IsNullOrEmpty(_context.User.FirstOrDefault(usr => usr.ID == user).displayName))
                        {
                            chatName = chatName + _context.User.FirstOrDefault(usr => usr.ID == user).username;
                        }
                        else
                        {
                            chatName = chatName + _context.User.FirstOrDefault(usr => usr.ID == user).displayName;
                        }

                        if (members.Count > 1)
                        {
                            chatName += ", ";
                        }
                    }
                }

            }
            chatID = chat.chatID;
            lastMessageTime = chat.lastMessageTime;
            
            chatColor = chat.chatColor;
            isGroupMessage = chat.isGroupMessage;
        }
        public int chatID { get; set; }
        public string chatName { get; set; }
        public DateTime lastMessageTime { get; set; }
        public List<MemberUser> users { get; set; } // TODO: Zrobić obiekt memberów: id, displayName, userName
        public string chatColor { get; set; }
        public bool isGroupMessage { get; set; }
    }
}
