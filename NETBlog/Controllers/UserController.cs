using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NETBlog.Models;

namespace NETBlog.Controllers
{
    public class UserController : Controller
    {
        
        private BlogContext db;
        private readonly ILogger<HomeController> _logger;

        public UserController(ILogger<HomeController> logger, BlogContext context)
        {
            _logger = logger;
            db = context;
        }

        public IActionResult Index()
        {
            return View(db.Users.ToList());
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