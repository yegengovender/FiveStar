using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MapsTest4.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Double click to add a venue.";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
