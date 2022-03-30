using ChatMe.Classes;
using ChatMe.Data;
using ChatMe.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatMe.Controllers
{
    public class HomeController : Controller
    {
        private readonly ChatContext _context;

        public HomeController(ChatContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            string tk = HttpHelper.HttpContext.Session.GetString("SessionToken");

            if (tk != null)
            {
                User logged = _context.User.First(user => user.token == tk);

                if (logged != null)
                {
                    Session session = new Session(_context);
                    session.updateSession();
                    int convId = -1;
                    try
                    {
                        convId = int.Parse(HttpContext.Request.Query["conversation"].First<string>());
                    }
                    catch(Exception e)
                    {

                    }
                    IQueryable<ChatMe.Models.FrontMessage> listOfMessages;
                    if (true)
                    {
                        listOfMessages = from message in _context.Messages
                                          where message.chatID == convId
                                          orderby message.createdTime
                                          select new FrontMessage(_context.User.FirstOrDefault(m => m.ID == message.creatorID).displayName, _context.User.FirstOrDefault(m => m.ID == message.creatorID).username, message.messageID, message.createdTime, message.messageContent, message.readedBy);
                        listOfMessages = listOfMessages.Take(10); //.Skip(50)
                    }
                    // TODO: Segreguje wiadomości od najstarszych ukrywa najnowsze!!!
                    dynamic mymodel = new ExpandoObject();
                    mymodel.currentUserData = new CurrentUserData(logged);
                    mymodel.listOfMessages = listOfMessages;
                    mymodel.listOfConversations = getChats(logged, convId);
                    return View(mymodel);
                }
                else
                {
                    return RedirectToAction("Index", "Login");
                }
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }

        private IEnumerable<Chat> getChats(User logged, int currentChat)
        {
            IQueryable<ChatMe.Models.Chat> listOfConversations;
            if (true)
            {
                listOfConversations = from chat in _context.Chats
                                      orderby chat.lastMessageTime
                                      select chat; //where chat.chatID == currentChat
                listOfConversations = listOfConversations.Take(10); //.Skip(50)
                return listOfConversations;
                // TODO: Listowanie konwersacji użytkownika
                // TODO: Customowy obiekt konwersacji na froncie
                // TODO: Wyświetlanie konwersacji w Home View na dynamic model
            }
        }

        public IActionResult Privacy()
        {
            byte[] token;
            HttpHelper.HttpContext.Session.TryGetValue("SessionToken", out token);
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
