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
                if (members.Count > 1)
                {
                    members.Remove(logged.ID);
                }

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

                        shortcut = getShortcut(chatName);

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

            try
            {
                Message lastMessageObject = _context.Messages.OrderByDescending(d => d.createdTime).FirstOrDefault(m => m.chatID == chatID);
                if (lastMessageObject != null)
                {
                    lastMessage = lastMessageObject.messageContent;
                }
                else
                {
                    lastMessage = "Brak wiadomości 🙁";
                }
            }
            catch (NullReferenceException e)
            {
                lastMessage = "Brak wiadomości 🙁";
            }

            // TODO: Dopisać sprawdzanie odczytania wiadomości;
            // TODO: Aktualizacja Daty i ostatniej wiadomości po wysłaniu lub przyjściu nowej wiadomości
            // TODO: Sortowanie konwersacji po zmianie daty ostatniej wiadomości;
        }
        public int chatID { get; set; }
        public string chatName { get; set; }
        public DateTime lastMessageTime { get; set; }
        public List<MemberUser> users { get; set; } // TODO: Zrobić obiekt memberów: id, displayName, userName
        public string chatColor { get; set; }
        
        public string shortcut { get; set; }
        public bool isGroupMessage { get; set; }

        public bool readed { get; set; }
        public string lastMessage { get; set; }

        private string getShortcut(string chatName)
        {
            string shortcut = "";
            string[] words = chatName.Split();
            if (chatName.Contains(' '))
            {
                int i = 1;
                foreach(string word in words)
                {
                    if((i == 1) || (i == words.Length)) {
                        shortcut += word.Substring(0, 1);
                    }
                }
                return shortcut;
            }
            else
            {
                if (chatName.Length > 2)
                {
                    shortcut = words[0].Substring(0, 1);
                    shortcut += words[0].Substring(chatName.Length - 1);
                }
                else
                {
                    shortcut = chatName;
                }
                return shortcut;
            }
            
        }
    }
}
