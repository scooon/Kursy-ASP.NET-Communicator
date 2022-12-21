using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatMe.Models
{
    public class FrontMessage
    {
        public FrontMessage(string _creatorName, string _username, int _messageID, DateTime _createdTime, string _messageContent, List<Readed> _readedBy, bool _isMyMessage)
        {
            creatorName = _creatorName;
            messageID = _messageID;
            createdTime = _createdTime;
            messageContent = _messageContent;
            readedBy = _readedBy;
            username = _username;
            isMyMessage = _isMyMessage;
            if (String.IsNullOrEmpty(_creatorName))
            {
                shortcut = getShortcut(_username);
            }
            else
            {
                shortcut = getShortcut(_creatorName);
            }
        }
        public int messageID { get; set; }
        public int chatID { get; set; }
        public string creatorName { get; set; }
        public string username { get; set; }
        public string messageContent { get; set; }
        public DateTime createdTime { get; set; }
        public List<Readed> readedBy { get; set; }
        public bool isMyMessage { get; set; }
        public string shortcut { get; set; }

        private string getShortcut(string chatName)
        {
            string shortcut = "";
            string[] words = chatName.Split();
            if (chatName.Contains(' '))
            {
                int i = 1;
                foreach (string word in words)
                {
                    if ((i == 1) || (i == words.Length))
                    {
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
