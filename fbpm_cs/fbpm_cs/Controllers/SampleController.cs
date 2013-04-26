using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using fbpm_cs.Models;

namespace fbpm_cs.Controllers
{ 
    public class SampleController : Controller
    {
        private fbpmSample db = new fbpmSample();

        //
        // GET: /Sample/

        public ViewResult Index()
        {
            return View(db.Samples.ToList());
        }

        //
        // GET: /Sample/Details/5

        public ViewResult Details(Guid id)
        {
            Sample sample = db.Samples.Single(s => s.SampleID == id);
            return View(sample);
        }

        //
        // GET: /Sample/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Sample/Create

        [HttpPost]
        public ActionResult Create(Sample sample)
        {
            if (ModelState.IsValid)
            {
                sample.SampleID = Guid.NewGuid();
                db.Samples.AddObject(sample);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(sample);
        }
        
        //
        // GET: /Sample/Edit/5
 
        public ActionResult Edit(Guid id)
        {
            Sample sample = db.Samples.Single(s => s.SampleID == id);
            return View(sample);
        }

        //
        // POST: /Sample/Edit/5

        [HttpPost]
        public ActionResult Edit(Sample sample)
        {
            if (ModelState.IsValid)
            {
                db.Samples.Attach(sample);
                db.ObjectStateManager.ChangeObjectState(sample, EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sample);
        }

        //
        // GET: /Sample/Delete/5
 
        public ActionResult Delete(Guid id)
        {
            Sample sample = db.Samples.Single(s => s.SampleID == id);
            return View(sample);
        }

        //
        // POST: /Sample/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(Guid id)
        {            
            Sample sample = db.Samples.Single(s => s.SampleID == id);
            db.Samples.DeleteObject(sample);
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