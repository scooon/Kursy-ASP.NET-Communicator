using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatMe.Models
{
    public class FrontMessage
    {
        public FrontMessage(string _creatorName, string _username, int _messageID, DateTime _createdTime, string _messageContent, List<Readed> _readedBy)
        {
            creatorName = _creatorName;
            messageID = _messageID;
            createdTime = _createdTime;
            messageContent = _messageContent;
            readedBy = _readedBy;
            username = _username;
        }
        public int messageID { get; set; }
        public int chatID { get; set; }
        public string creatorName { get; set; }
        public string username { get; set; }
        public string messageContent { get; set; }
        public DateTime createdTime { get; set; }
        public List<Readed> readedBy { get; set; }
    }
}
