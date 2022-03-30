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
        }
        public int myID { get; set; }
        public string about { get; set; }
        public string email { get; set; }
        public string username { get; set; }
        public string displayName { get; set; }

    }
}
