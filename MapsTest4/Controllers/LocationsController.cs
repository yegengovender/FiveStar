using MapsTest4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MapsTest4.Controllers
{
    public class LocationsController : Controller
    {
        private FiveStarDB db = new FiveStarDB();
        //
        // GET: /Locations/

        public ActionResult Index()
        {
            var venues = db.Venues.ToList();
            return Json(venues, JsonRequestBehavior.AllowGet);
        }

        public ActionResult PopupContent(int id)
        {
            var venue = db.Venues.Find(id);
            return View(venue);
        }

        public ActionResult ClickAddVenue(double x, double y)
        {
            var venue = new Venue() { XPos = x, YPos = y };
            db.Venues.Add(venue);
            db.SaveChanges();

            var url = "/Venue/Edit/" + venue.Id.ToString();
            return Content(url);
        }

    }
}
