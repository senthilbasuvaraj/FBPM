using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using fbpm_cs.Models;

namespace fbpm_cs.Controllers
{
    public class PaymentScheduleController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            var entities = new fbpmEntities();
            Console.WriteLine("Model Count:" + entities.PaymentSchedules.Count());
            return View(entities.PaymentSchedules);
        }

        //
        // GET: /PaymentSchedule/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /PaymentSchedule/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /PaymentSchedule/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        
        //
        // GET: /PaymentSchedule/Edit/5
 
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /PaymentSchedule/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /PaymentSchedule/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /PaymentSchedule/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
