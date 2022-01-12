using ChatMe.Data;
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
            //var listOfUsers = from u in _context.User select u;
            if (!String.IsNullOrEmpty(keyword))
            {
                //TODO: NIE WYSZUKUJE DOBRZE USERÓW LINQ
                var listOfUsers = from user in _context.User
                                           select new { user.ID, user.username, user.displayName, user.email, user.lastLogin };
                //listOfUsers.Where(s => s.username.Contains(keyword));
                await Clients.Caller.SendAsync("UserSearchResponse", listOfUsers);
            }
            
        }
    }
}
