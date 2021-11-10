﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace ChatMe.Models
{
    public class User
    {
        public int ID { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public string displayName { get; set; }
        public string token { get; set; }
        public DateTime expire { get; set; }
        public string about { get; set; }
        public string password { get; set; }
        public DateTime lastLogin { get; set; }
        public DateTime created { get; set; }


    }


}
