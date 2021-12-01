using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ChatMe.Data;
using ChatMe.Models;

namespace ChatMe.Controllers
{
    public class LoginController : Controller
    {
        private readonly ChatContext _context;

        public LoginController(ChatContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }


        // POST: Messages/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login([Bind("username,password")] User loginData)
        {
            if (ModelState.IsValid)
            {
                var currentLogin = _context.User.FirstOrDefault(item => item.username == loginData.username);
                if(currentLogin == null)
                {
                    return NotFound();
                }
                //_context.User.Add(message);
                //await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(loginData);
        }


        private bool MessageExists(int id)
        {
            return _context.Messages.Any(e => e.messageID == id);
        }
    }
}
