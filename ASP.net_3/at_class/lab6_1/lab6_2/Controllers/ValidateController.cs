using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lab6_2.Controllers
{
    public class ValidateController : Controller
    {
        // GET: Validate
        public ActionResult Index()
        {
            ModelState.AddModelError("ok", "Ban da nhap dung");
            return View();
        }

        public ActionResult Validate()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Validate(string FullName, int Age)
        {
            ModelState.Clear();
            if (string.IsNullOrEmpty(FullName))
            {
                ModelState.AddModelError("FullName", "Khong de trong");
            }
            else if (FullName.Length < 5)
            {
                ModelState.AddModelError("FullName", "It nhat 5 ky tu");
            }
            if (string.IsNullOrEmpty(Age.ToString()))
            {
                ModelState.AddModelError("Age", "Khong de trong");
            }
            else if (Age < 16 || Age > 65)
            {
                ModelState.AddModelError("Age", "Tuoi tu 16 den 65");
            }
            if (ModelState.Count == 0)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}