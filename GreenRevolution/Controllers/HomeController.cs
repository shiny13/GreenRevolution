using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GreenRevolution.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "We care about you more than you think.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Green Revolution contact page.";

            return View();
        }
    }
}