using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DanielOramTradeMeSimple.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult GetHtmlPage(string path)
        {
            return new FilePathResult(path, "text/html");
        }


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
    }
}