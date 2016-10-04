using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace myCv.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetPartialView(string view)
        {            
            //Si esto fuera algo serio, es un gran fallo de seguridad.
            return PartialView(view);
        }

        public FileResult DownloadPDF()
        {
            byte[] fileBytes = System.IO.File.ReadAllBytes(AppDomain.CurrentDomain.BaseDirectory + "/Content/CV-Facundo-Wasinger.pdf");
            string fileName = "CV-Facundo-Wasinger.pdf";
            return File(fileBytes, System.Net.Mime.MediaTypeNames.Application.Octet, fileName);
        }

        /*
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
        */
    }
}