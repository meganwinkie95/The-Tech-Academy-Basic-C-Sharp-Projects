using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance_3.Models;

namespace CarInsurance_3.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        public decimal calculatequote(Insuree insuree)
        {
            insuree.Quote = 50;
            int now = int.Parse(DateTime.Now.ToString("yyyyMMdd"));
            int dob = int.Parse(insuree.DateOFBirth.ToString("yyyyMMdd"));
            int age = (now - dob) / 10000; ;
            int y = Convert.ToInt32(insuree.CarYear);
            string z = insuree.CarMake;
            string a = insuree.CarModel;
            int b = Convert.ToInt32(insuree.SpeedingTickets);
            bool c = insuree.DUI;
            bool d = insuree.CoverageType;
            if (age <= 18)
            {
                insuree.Quote += 100;
            }
                if (age >= 19 && age <= 25)
                {
                    insuree.Quote += 50;
                }
                if (age >= 26)
                {
                    insuree.Quote += 25;
                }
                if (y < 2000)
                {
                    insuree.Quote += 25;
                }
                if (y > 2015)

                {
                    insuree.Quote += 25;
                }
                if (z == "Porche")
                {
                    insuree.Quote += 25;
                }
                if (z == "Porche" && a == "911 Carrera")
                {
                    insuree.Quote += 25;
                }
                if (b >= 1)
                {
                    insuree.Quote += b * 10;
                }
                if (c == true)
                {

                    insuree.Quote *= 1.25m;
                }
                if (d == true)
                {
                    insuree.Quote *= 1.5m;
               
                }
              
            return (insuree.Quote);
        }
     


        // GET: Insuree
        public ActionResult Index()
        {
            
            return View(db.Insurees.ToList());
        }
        public ActionResult Admin()
        {

            return View(db.Insurees.ToList());
        }

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // GET: Insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insuree/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOFBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                insuree.Quote = calculatequote(insuree);
                db.Insurees.Add(insuree);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(insuree);
        }

        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOFBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                db.Entry(insuree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insuree);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insuree insuree = db.Insurees.Find(id);
            db.Insurees.Remove(insuree);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
