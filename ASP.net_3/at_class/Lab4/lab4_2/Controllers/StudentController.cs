using lab4_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lab4_2.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }

       
        [HttpGet]
        public ActionResult Create(Student student)
        {
            return View(student);
        }
    }
}