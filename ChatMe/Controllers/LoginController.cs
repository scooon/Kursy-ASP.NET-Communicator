using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ChatMe.Data;
using ChatMe.Models;
using System.Text;
using Microsoft.AspNetCore.Http;
namespace ChatMe.Controllers
{
    public class LoginController : Controller
    {
        private readonly ChatContext _context;

        public LoginController(ChatContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(object status)
        {
            if (!String.IsNullOrEmpty(HttpContext.Request.Query["failed"])) {
                if (Convert.ToBoolean(HttpContext.Request.Query["failed"])){
                    ViewBag.failed = true;
                }
                else
                {
                    ViewBag.failed = false;
                }
            }
            else
            {
                ViewBag.failed = false;
            }
            
            return View();
        }

        public IActionResult Logged(User currentLogin)
        {
            return View(currentLogin);
        }


        // POST: Messages/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index([Bind("username,password")] User loginData)
        {
            ViewBag.failed = true;
            if (ModelState.IsValid)
            {
                var currentLogin = _context.User.FirstOrDefault(item => item.username.ToLower() == loginData.username.ToLower());
                if (currentLogin == null)
                {
                    return RedirectToAction(nameof(Index), new { failed = true });
                }

                if (loginData.password == currentLogin.password)
                {
                    currentLogin.token = System.Guid.NewGuid().ToString();
                    currentLogin.lastLogin = DateTime.Now;
                    _context.Update(currentLogin);
                    await _context.SaveChangesAsync();
                    HttpHelper.HttpContext.Session.SetString("SessionToken", currentLogin.token);

                   

                    return RedirectToAction("Index", "Home");
                }
                
                //_context.User.Add(message);
                //await _context.SaveChangesAsync();
                
            }
            return View(loginData);
        }


        private bool MessageExists(int id)
        {
            return _context.Messages.Any(e => e.messageID == id);
        }
    }
}
