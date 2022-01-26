using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChatMe.Data;
using ChatMe.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ChatMe.Classes
{

    public class Session : Controller
    {
        private readonly ChatContext _context;

        public Session(ChatContext context)
        {
            _context = context;
        }

        public bool updateSession() {
            string token = HttpHelper.HttpContext.Session.GetString("SessionToken");
            User currentUser = _context.User.FirstOrDefault(item => item.token == token);
            if(currentUser == null)
            {
                return false;
            }
            if(currentUser.lastLogin.AddHours(24) > DateTime.Now)
            {
                return false;
            }
            currentUser.lastLogin = DateTime.Now;
            _context.Update(currentUser);
            _context.SaveChangesAsync();
            return true;
        }
    }

    
}
