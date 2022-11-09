using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatMe.Models
{
    public class CurrentUserData
    {
        public CurrentUserData(User usr)
        {
            myID = usr.ID;
            about = usr.about;
            email = usr.email;
            username = usr.username;
            displayName = usr.displayName;
            if (String.IsNullOrEmpty(displayName))
            {
                shortcut = getShortcut(username);
            }
            else
            {
                shortcut = getShortcut(displayName);
            }
        }
        public int myID { get; set; }
        public string about { get; set; }
        public string email { get; set; }
        public string username { get; set; }
        public string displayName { get; set; }
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
