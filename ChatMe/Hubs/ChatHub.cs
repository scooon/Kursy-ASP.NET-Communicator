using ChatMe.Classes;
using ChatMe.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatMe.Hubs
{
    public class ChatHub : Hub
    {
        private readonly ChatContext _context;
        

        public ChatHub(ChatContext context)
        {

            _context = context;
        }
        public async Task SendMessage(string user, string message)
        {
            Console.WriteLine(user + ": " + message);
            await Clients.All.SendAsync("ReceiveMessage", user, message);
            //Zrobić żeby do konkretnego usera były wysyłane wiadomości;
        }

        // User search
        public async Task SearchUser(string keyword)
        {
            
            Session session = new Session(_context);
            session.updateSession();
            if (!String.IsNullOrEmpty(keyword))
            {
                var listOfUsers = from user in _context.User
                                  where user.displayName.Contains(keyword) ||
                                  user.username.Contains(keyword) ||
                                  user.email.Contains(keyword)
                                  orderby user.displayName
                                  select new { user.ID, user.username, user.displayName, user.email, user.lastLogin };
                await Clients.Caller.SendAsync("UserSearchResponse", listOfUsers);
            }
            else
            {
                var empty = new object[0];
                await Clients.Caller.SendAsync("UserSearchResponse", empty);
            }
            
        }
    }
}
