using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MyShoppingList.Models;

namespace MyShoppingList.Controllers
{
    public class RECIPEsController : Controller
    {
        private ShoppingDatabaseEntities db = new ShoppingDatabaseEntities();

        // GET: RECIPEs
        public ActionResult Index()
        {
            return View(db.RECIPEs.ToList());
        }

        // GET: RECIPEs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RECIPE rECIPE = db.RECIPEs.Find(id);
            if (rECIPE == null)
            {
                return HttpNotFound();
            }
            return View(rECIPE);
        }

        // GET: RECIPEs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RECIPEs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,name,description")] RECIPE rECIPE)
        {
            if (ModelState.IsValid)
            {
                db.RECIPEs.Add(rECIPE);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(rECIPE);
        }

        // GET: RECIPEs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RECIPE rECIPE = db.RECIPEs.Find(id);
            if (rECIPE == null)
            {
                return HttpNotFound();
            }
            return View(rECIPE);
        }

        // POST: RECIPEs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,name,description")] RECIPE rECIPE)
        {
            if (ModelState.IsValid)
            {
                db.Entry(rECIPE).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(rECIPE);
        }

        // GET: RECIPEs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RECIPE rECIPE = db.RECIPEs.Find(id);
            if (rECIPE == null)
            {
                return HttpNotFound();
            }
            return View(rECIPE);
        }

        // POST: RECIPEs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            RECIPE rECIPE = db.RECIPEs.Find(id);
            db.RECIPEs.Remove(rECIPE);
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
