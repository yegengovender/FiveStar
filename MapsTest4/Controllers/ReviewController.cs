using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MapsTest4.Models;

namespace MapsTest4.Controllers
{ 
    public class ReviewController : Controller
    {
        private FiveStarDB db = new FiveStarDB();

        //
        // GET: /Review/

        public ViewResult Index()
        {
            return View(db.Reviews.ToList());
        }

        //
        // GET: /Review/Details/5

        public ViewResult Details(int id)
        {
            Review review = db.Reviews.Find(id);
            return View(review);
        }

        //
        // GET: /Review/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Review/Create

        [HttpPost]
        public ActionResult Create(Review review)
        {
            if (ModelState.IsValid)
            {
                db.Reviews.Add(review);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(review);
        }
        
        //
        // GET: /Review/Edit/5
 
        public ActionResult Edit(int id)
        {
            Review review = db.Reviews.Find(id);
            return View(review);
        }

        //
        // POST: /Review/Edit/5

        [HttpPost]
        public ActionResult Edit(Review review)
        {
            if (ModelState.IsValid)
            {
                db.Entry(review).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(review);
        }

        //
        // GET: /Review/Delete/5
 
        public ActionResult Delete(int id)
        {
            Review review = db.Reviews.Find(id);
            return View(review);
        }

        //
        // POST: /Review/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            Review review = db.Reviews.Find(id);
            db.Reviews.Remove(review);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}