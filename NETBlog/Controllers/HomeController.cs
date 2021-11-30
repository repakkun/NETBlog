using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NETBlog.Models;

namespace NETBlog.Controllers
{
    public class HomeController : Controller
    {
        private BlogContext db;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, BlogContext context)
        {
            _logger = logger;
            db = context;
        }

        public IActionResult Index()
        {
            return View(db.Users.ToList());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
        
        
        [HttpGet]
        public  IActionResult Register()
        {
            ViewBag.JoinDate = DateTime.Now;
            return View();
        }
        [HttpPost]
        public string Register(User user)
        {
            db.Users.Add(user);
            // сохраняем в бд все изменения
            db.SaveChanges();
            return "Спасибо, " + user.UserName + " " + user.Id + " " + user.JoinDate + ", за регистрацию!";
        }
    }
}