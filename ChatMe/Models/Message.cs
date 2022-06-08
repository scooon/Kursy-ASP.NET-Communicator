using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatMe.Models
{
    public class Message
    {
        public Message()
        {
            List<Readed> readedBy = new List<Readed>();
        }
        public int messageID { get; set; }
        public int chatID { get; set; }
        public int creatorID { get; set; }
        public string messageContent { get; set; }
        public DateTime createdTime { get; set; }
        public List<Readed> readedBy { get; set; }
    }
}
