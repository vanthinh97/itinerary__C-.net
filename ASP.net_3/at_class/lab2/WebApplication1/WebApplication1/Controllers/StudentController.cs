using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{

    public class StudentController : Controller
    {
        // GET: Student
        studentEntities db = new studentEntities();
        public ActionResult Index()
        {
            return View();
        }

        ///mặc định là http get, nên khi định nghĩa post ở dưới thì form register sẽ tự tìm đến
        public ActionResult Register()
        {
            var id = Request.QueryString["Id"].ToString();
            var name = Request.QueryString["Name"].ToString();
            var mark = Request.QueryString["Mark"].ToString();
            ViewBag.Id = id;
            ViewBag.Name = name;
            ViewBag.Mark = mark;
            return View();
        }
        [HttpPost]
        public ActionResult Register(string Id, string Name, string Mark)
        {
            //var id = Request.QueryString["Id"].ToString();
            //var name = Request.QueryString["Name"].ToString();
            //var mark = Request.QueryString["Mark"].ToString();
            ViewBag.Id = Id;
            ViewBag.Name = Name;
            ViewBag.Mark = Mark;
            return View("Registration");
        }


       

       [HttpGet]
        public ActionResult Write()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Write(hocsinh h)
        {
            hocsinh ho = new hocsinh()
            {
                Name = h.Name,
                @class = h.@class,

            };
            db.hocsinh.Add(ho);
            db.SaveChanges();
            ViewBag.Message = "Đã ghi vào file";
            return View();
        }

        [HttpGet]
        public ActionResult Read()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Read(int id)
        {
            hocsinh hs = db.hocsinh.Find(id);
            ViewBag.ID = hs.ID;
            ViewBag.Name = hs.Name;
            ViewBag.Class = hs.@class;
            ViewBag.Message = "Đã đọc từ file";
            return View(hs);
        }
    }
}