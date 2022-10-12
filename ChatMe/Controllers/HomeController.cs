using ChatMe.Classes;
using ChatMe.Data;
using ChatMe.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
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
                    IEnumerable<FrontMessage> listOfMessages;
                    List<CurrentUserData> usersInConversation = new List<CurrentUserData>();
                    if (true)
                    {
                        IQueryable<FrontMessage> listOfMessagesQuery = from message in _context.Messages
                                          where message.chatID == convId
                                          orderby message.createdTime descending
                                          select new FrontMessage(_context.User.FirstOrDefault(m => m.ID == message.creatorID).displayName, _context.User.FirstOrDefault(m => m.ID == message.creatorID).username, message.messageID, message.createdTime, message.messageContent, message.readedBy, isMyMessage(message.creatorID, logged.ID));
                        listOfMessages = listOfMessagesQuery.Take(20); //.Skip(50)
                        listOfMessages = listOfMessages.OrderBy(message => message.createdTime);
                        foreach (FrontMessage msg in listOfMessages)
                        {
                            // TODO: Zapisywanie odczytywania wiadomości w bazie
                            

                            if ((msg.username != logged.username) && (!msg.readedBy.Any(item => item.userID == logged.ID)))
                            {
                                msg.readedBy.Add(new Readed(logged.ID, DateTime.Now));
                                Message updatedMsg = _context.Messages.First(msgItem => msgItem.messageID == msg.messageID);
                                if (updatedMsg.readedBy == null)
                                {
                                    updatedMsg.readedBy = new List<Readed>();
                                }
                                updatedMsg.readedBy.Add(new Readed(logged.ID, DateTime.Now));
                                _context.Update(updatedMsg);
                                _context.SaveChanges();
                            }

                            foreach (Readed readedUsers in msg.readedBy)
                            {
                                if (!usersInConversation.Any(item => item.myID == readedUsers.userID))
                                {
                                    User usr = _context.User.First(user => user.ID == readedUsers.userID);
                                    usersInConversation.Add(new CurrentUserData(usr));
                                }
                            }
                        }
                    }
                    
                    dynamic mymodel = new ExpandoObject();
                    mymodel.currentUserData = new CurrentUserData(logged);
                    mymodel.listOfMessages = listOfMessages;
                    mymodel.usersInConversation = usersInConversation;
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

        private static bool isMyMessage(int creatorID, int loggedID)
        {
            if (creatorID == loggedID)
            {
                return true;
            }
            else

            {
                return false;
            }
        }

        private IEnumerable<FrontChatItem> getChats(User logged, int currentChat)
        {
            IQueryable<ChatMe.Models.FrontChatItem> listOfConversations;
            if (true)
            {
                listOfConversations = from chat in _context.Chats
                                      where chat.usersIDs.Contains("["+logged.ID+",") || chat.usersIDs.Contains("," + logged.ID + ",") || chat.usersIDs.Contains("," + logged.ID + "]") || chat.usersIDs.Contains("[" + logged.ID + "]")
                                      orderby chat.lastMessageTime descending
                                      select new FrontChatItem(chat, logged, _context); //where chat.chatID == currentChat
                listOfConversations = listOfConversations.Take(20); //.Skip(50)
                return listOfConversations;

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
