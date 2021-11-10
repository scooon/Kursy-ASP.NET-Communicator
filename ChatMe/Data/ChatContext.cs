using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ChatMe.Models;

namespace ChatMe.Data
{
    public class ChatContext : DbContext
    {
        public ChatContext (DbContextOptions<ChatContext> options)
            : base(options)
        {
        }

        public DbSet<ChatMe.Models.User> User { get; set; }
        public DbSet<ChatMe.Models.Chat> Chats { get; set; }
        public DbSet<ChatMe.Models.Message> Messages { get; set; }
        public DbSet<ChatMe.Models.Settings> Settings { get; set; }


    }
}
