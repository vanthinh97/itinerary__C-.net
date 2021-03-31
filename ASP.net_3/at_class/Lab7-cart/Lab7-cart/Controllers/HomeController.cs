using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab7_cart.Models;
namespace Lab7_cart.Controllers
{
    public class HomeController : Controller
    {
        public MyShoppingWebEntities db = new MyShoppingWebEntities();
        public ActionResult Index()
        {
            IEnumerable<Products> products = db.Products.Take(6);
            ViewBag.NewProducts = products.ToList();
            return View();
        }


        public ActionResult AddToCart(int id)
        {
            int quantity = 1;
            ShoppingCart cart = (ShoppingCart)Session["cart"];
            if (cart == null)
            {
                cart = new ShoppingCart();
            }
            foreach (var item in db.Products)
            {
                if (item.Id == id)
                {
                    double unitPrice = item.UnitPrice;
                    cart.AddItem(id.ToString(), quantity, unitPrice);
                }
            }
            //Save cart
            Session["cart"] = cart;
            return RedirectToAction("YourCart");
        }
        public ActionResult YourCart()
        {
            //Models.NorthwindEntities db = new Models.NorthwindEntities();
            //return View(db.Categories.Include("Products").ToList());
            return View();
        }

        public ActionResult RemoveItem(int id)
        {
            ShoppingCart cart = (ShoppingCart)Session["cart"];
            if (cart == null)
            {
                cart = new ShoppingCart();
            }
            cart.RemoveItem(id.ToString());
            return RedirectToAction("YourCart");
        }

        public ActionResult RemoveAllItem()
        {
            ShoppingCart cart = (ShoppingCart)Session["cart"];
            cart.Clear();
            return RedirectToAction("YourCart");
        }

    }
}