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
                members.Remove(logged.ID);
                foreach(int user in members)
                {
                    // TODO: Przeczyścić bazę z wiadomości i Chatów z NULLEM!!!
                    if(String.IsNullOrEmpty(_context.User.FirstOrDefault(usr => usr.ID == user).displayName))
                    {
                        chatName = chatName + _context.User.FirstOrDefault(usr => usr.ID == user).username;
                    }
                    else
                    {
                        chatName = chatName + _context.User.FirstOrDefault(usr => usr.ID == user).displayName;
                    }
                    
                    if(members.Count > 1)
                    {
                        chatName += ", ";
                    }
                }
                // TODO: Zbudować konstruktor, który będzie zawierał pełne info o usernameach użytkowników i displaynameach. Jeżeli displayname jest pusty, użyj username
            }
            chatID = chat.chatID;
            lastMessageTime = chat.lastMessageTime;
            userIDs = chat.usersIDs;
            // TODO: Dodać kolor czatu i inne elementy
        }
        public int chatID { get; set; }
        public string chatName { get; set; }
        public DateTime lastMessageTime { get; set; }
        public string userIDs { get; set; } // TODO: Zrobić obiekt memberów: id, displayName, userName

    }
}
