using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lab3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(FormCollection fields)
        {
            string username = fields["UserName"];
            string address = fields["Address"];
            string password = fields["Password"];
            string email = fields["ChkEmail"];
            string city = fields["City"];
            string gender = fields["Gender"];
            ViewBag.UserName = username;
            ViewBag.Address = address;
            ViewBag.Password = password;
            ViewBag.Email = email;
            ViewBag.City = city;
            ViewBag.Gender = gender;

            //string fileLPath = Server.MapPath("~/Models/folder1/text1.txt");
            //string[] lines = 
            //{
            //    username,
            //    address,
            //    password,
            //    email,
            //    city,
            //    gender
            //};
            //System.IO.File.WriteAllLines(fileLPath, lines);
            string file = Server.MapPath("~/Files/text1.txt");
            string line = "";
            line = username + ";" + address + ";" + password + ";" + email + ";" + city + ";" + gender;
            FileStream fsout = new FileStream(file, FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fsout);
            sw.WriteLine(line);
            sw.Close();
            fsout.Close();

            return View("RegistrationInfo");
        }

    }
}