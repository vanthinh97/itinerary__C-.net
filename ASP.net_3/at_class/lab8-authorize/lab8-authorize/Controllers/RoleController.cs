using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using lab8_authorize.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace lab8_authorize.Controllers
{
    [Authorize(Roles = "Admin")]
    public class RoleController : Controller
    {
        ApplicationDbContext context;

        public RoleController()
        {
            context = new ApplicationDbContext();
        }
        // GET: Role
        public ActionResult Index()
        {
            var Roles = context.Roles.ToList();
            return View(Roles);
        }

        public ActionResult Create()
        {
            var Role = new IdentityRole();
            return View(Role);
        }



        [HttpPost]
        public ActionResult Create(IdentityRole Role)
        {
            context.Roles.Add(Role);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public string GetRoles()
        {
            return "Admin, Managers";
        }

        [HttpGet]
        public ActionResult AddUserToRole()
        {
            using (var context = new ApplicationDbContext())
            {
                var users = from u in context.Users
                            select u;
                // ViewBag.Users = new SelectList(users, "Id", "UserName");
                ViewBag.UserName = users.Select(x => new SelectListItem { Text = x.UserName, Value = x.Id }).ToList();
                var roles = from r in context.Roles
                            select r;
                ViewBag.Name = roles.Select(x => new SelectListItem { Text = x.Name, Value = x.Name }).ToList();
            }
            return View();
        }
        [HttpPost]
        public ActionResult AddUserToRole(string UserName, string Name)
        {
            //var context = new AccountController();
            var context = new ApplicationDbContext();
            //var roleStore = new RoleStore<IdentityRole>(context);
            //var roleManager = new RoleManager<IdentityRole>(roleStore);
            var userStore = new UserStore<ApplicationUser>(context);
            var userManager = new UserManager<ApplicationUser>(userStore);
            userManager.AddToRole(UserName, Name);
            //userManager.AddToRole(UserName, Name);
            ViewBag.Name = UserName;
            ViewBag.Role = Name;
            return View("AddConfirm");
        }



    }
}