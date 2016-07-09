using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace COMP2007_S2016_Lab4.Controllers
{
    public class HomeController : Controller
    {
        // how to navigate to /Home/Index or /
        public ActionResult Index()
        {
            return View();
        }

        //GET: /Home/About
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