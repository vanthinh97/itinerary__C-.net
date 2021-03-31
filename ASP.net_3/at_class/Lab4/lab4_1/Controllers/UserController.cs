using Lab4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lab4_1.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            var user = new List<User>();
            var user1 = new User();
            user1.Name = "Mark";
            user1.Address = "DN";
            user1.Email = "async@gmail.com";
            var user2 = new User();
            user2.Name = "Rob";
            user2.Address = "Qn";
            user2.Email = "bfnjc@gmail.com";
            user.Add(user1);
            user.Add(user2);
            ViewBag.User = user;
            return View();
        }

        public ActionResult Index2()
        {
            var user = new List<User>();
            var user1 = new User();
            user1.Name = "Mark";
            user1.Address = "DN";
            user1.Email = "async@gmail.com";
            var user2 = new User();
            user2.Name = "Rob";
            user2.Address = "Qn";
            user2.Email = "bfnjc@gmail.com";
            user.Add(user1);
            user.Add(user2);
            return View(user);
        }
    }
}