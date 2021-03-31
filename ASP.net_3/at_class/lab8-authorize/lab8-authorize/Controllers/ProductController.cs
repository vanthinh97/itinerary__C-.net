using lab8_authorize.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lab8_authorize.Controllers
{
    public class ProductController : Controller
    {
        MywebEntities db = new MywebEntities();
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Products pro)
        {
            //var NewPro = new Products();
            //NewPro.ProductName = pro.ProductName;
            //NewPro.UnitPrice = pro.UnitPrice;
            //NewPro.IsActive = pro.IsActive;
            db.Products.Add(pro);
            db.SaveChanges();
            string message = "SUCCESS";
            return Json(new { Message = message, JsonRequestBehavior.AllowGet });
        }

        //Get students
        public JsonResult GetProduct(string id)
        {
            List<Products> Pros = new List<Products>();
            Pros = db.Products.ToList();
            return Json(Pros, JsonRequestBehavior.AllowGet);
        }

    }
}