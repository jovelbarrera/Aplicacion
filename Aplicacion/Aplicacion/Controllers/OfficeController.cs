using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Aplicacion.Models;

namespace Aplicacion.Controllers
{
    public class OfficeController : Controller
    {
        private AplicacionDBContext db = new AplicacionDBContext();

        //
        // GET: /Office/

        public ActionResult Index()
        {
            return View(db.Offices.ToList());
        }

        //
        // GET: /Office/Details/5

        public ActionResult Details(int id = 0)
        {
            Office office = db.Offices.Find(id);
            if (office == null)
            {
                return HttpNotFound();
            }
            return View(office);
        }

        //
        // GET: /Office/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Office/Create

        [HttpPost]
        public ActionResult Create(Office office)
        {
            if (ModelState.IsValid)
            {
                db.Offices.Add(office);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(office);
        }

        //
        // GET: /Office/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Office office = db.Offices.Find(id);
            if (office == null)
            {
                return HttpNotFound();
            }
            return View(office);
        }

        //
        // POST: /Office/Edit/5

        [HttpPost]
        public ActionResult Edit(Office office)
        {
            if (ModelState.IsValid)
            {
                db.Entry(office).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(office);
        }

        //
        // GET: /Office/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Office office = db.Offices.Find(id);
            if (office == null)
            {
                return HttpNotFound();
            }
            return View(office);
        }

        //
        // POST: /Office/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Office office = db.Offices.Find(id);
            db.Offices.Remove(office);
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