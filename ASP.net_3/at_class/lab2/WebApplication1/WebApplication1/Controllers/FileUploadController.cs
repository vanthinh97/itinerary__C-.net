using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class FileUploadController : Controller
    {
        // GET: Upload
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Upload()
        {
            var g = Request.Files["Image"];
            if (g != null && g.ContentLength > 0)
            {
                var path = Server.MapPath("~/UploadFiles/" + g.FileName);
                g.SaveAs(path);

                ViewBag.ImageName = g.FileName;
                ViewBag.ImageType = g.ContentType;
                ViewBag.ImageSize = g.ContentLength;
            }

            var f = Request.Files["Document"];
            if (f != null && f.ContentLength > 0)
            {
                var path = Server.MapPath("~/UploadFiles/" + f.FileName);
                f.SaveAs(path);

                ViewBag.FileName = f.FileName;
                ViewBag.FileType = f.ContentType;
                ViewBag.FileSize = f.ContentLength;
            }
            return View();
        }
    }
}