using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatMe.Models
{
    public class Chat
    {
        public int chatID { get; set; }
        public bool isGroupMessage { get; set; }
        public string usersIDs { get; set; }
        public string chatName { get; set; }
        
        public string chatColor { get; set; }
        public DateTime lastMessageTime { get; set; }

    }
}
