using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Training.Models;

namespace Training.Controllers
{
    public class StudentController : Controller
    {
        
        db_TrainingEntities db = new db_TrainingEntities();
        // GET: Student
       [HttpGet]
        public ActionResult Index()
        {
            //read
            var rs = db.TblUsers.OrderByDescending(x => x.Id);
            return View(rs);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(string UserName, string FullName, string DiaChi)
        {
            //create
            TblUsers t = new TblUsers()
            {
                UserName = UserName,
                FullName = FullName,
                Address = DiaChi
            };
            db.TblUsers.Add(t);
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            TblUsers t = db.TblUsers.Find(id);
            return View(t);
        }

        [HttpPost]
        public ActionResult Edit(int Id, string FullName, string Address)
        {
            //update
            TblUsers t = db.TblUsers.Find(Id);
            t.FullName = FullName;
            t.Address = Address;
            db.SaveChanges();
            ViewBag.Message = "Update is success";

            return View(t);
        }
        [HttpPost]
        public ActionResult DeleteAjax(int id)
        {
            //update
            TblUsers t = db.TblUsers.Find(id);
            db.TblUsers.Remove(t);
            db.SaveChanges();          
            return Content("OK");
        }





        [HttpPost]
        public ActionResult CreateCach2(UserVM u)
        {
            //create
            TblUsers t = new TblUsers()
            {
                UserName = u.UserName,
                FullName = u.FullName,
                Address = u.DiaChi
            };
            db.TblUsers.Add(t);
            db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}