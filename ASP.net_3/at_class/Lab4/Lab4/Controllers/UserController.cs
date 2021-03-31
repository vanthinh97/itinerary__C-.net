using Lab4.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab4.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Creat()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Creat(int UserId, string Name, string Address, string Email)
        {
            var user = new User{ UserId = UserId, Name = Name, Address = Address, Email = Email };
            ViewBag.User = user;

            return View("CreatInfo");
        }
    }
}