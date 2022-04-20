using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace ChatMe.Models
{
    public class MemberUser
    {
        public MemberUser(User member)
        {
            ID = member.ID;
            username = member.username;
            email = member.email;
            displayName = member.displayName;
            about = member.about;
            lastLogin = member.lastLogin;
            created = member.created;
        }

        public int ID { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public string displayName { get; set; }
        public string about { get; set; }
        public DateTime lastLogin { get; set; }
        public DateTime created { get; set; }


    }


}
