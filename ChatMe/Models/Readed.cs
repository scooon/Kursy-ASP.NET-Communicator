using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatMe.Models
{
    public class Readed
    {
        public Readed()
        {

        }
        public Readed(int _userID)
        {
            userID = _userID;
        }
        public Readed(int _userID, DateTime _readTime)
        {
            userID = _userID;
            readTime = _readTime;
        }
        public int id { get; set; }
        public int userID { get; set; }
        public DateTime readTime { get; set; }
    }
}
