using ChatMe.Data;
using ChatMe.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            string tk = HttpContext.Session.GetString("SessionToken");

            if (tk != null)
            {
                User logged = _context.User.First(user => user.token == tk);
                if (logged != null)
                {
                    return View();
                }
                else
                {
                    return RedirectToAction("Login", "Index"); // do poprawienia nie przekierowuje dobrze
                }
            } 
            else
            {
                return RedirectToAction("Login", "Index"); // do poprawienia nie przekierowuje dobrze
            }
        }

        public IActionResult Privacy()
        {
            byte[] token;
            HttpContext.Session.TryGetValue("SessionToken", out token);
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
