using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ReadWriteOfTeacher.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(string StuID, string StuName, string StuMark)
        {
            string line = StuID + ";" + StuName + ";" + StuMark;
            string file = Server.MapPath("~/Data/students.txt");
            FileStream fi = new FileStream(file, FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fi);
            sw.WriteLine(line);
            sw.Close();
            fi.Close();
            return View("RegisterConfirm");
        }

        public ActionResult Read()
        {
            string line = "";
            string file = Server.MapPath("~/Data/students.txt");
            List<string> students = new List<string>();
            FileStream fi = new FileStream(file, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fi);
            while ((line = sr.ReadLine()) != null)
            {
                students.Add(line);
            }
            sr.Close();
            fi.Close();
            ViewBag.Students = students;
            return View("Students");
        }
    }
}