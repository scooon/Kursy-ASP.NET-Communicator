using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatMe.Models
{
    public class Readed
    {
        public int id { get; set; }
        public int userID { get; set; }
        public DateTime readTime { get; set; }
    }
}
