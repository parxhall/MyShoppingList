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
    public class LISTsController : Controller
    {
        private ShoppingDatabaseEntities db = new ShoppingDatabaseEntities();

        // GET: LISTs
        public ActionResult Index()
        {
            var lISTs = db.LISTs.Include(l => l.ITEM).Include(l => l.PERSON).Include(l => l.STATUS);
            return View(lISTs.ToList());
        }

        // GET: LISTs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LIST lIST = db.LISTs.Find(id);
            if (lIST == null)
            {
                return HttpNotFound();
            }
            return View(lIST);
        }

        // GET: LISTs/Create
        public ActionResult Create()
        {
            ViewBag.item_id = new SelectList(db.ITEMS, "id", "item1");
            ViewBag.person_id = new SelectList(db.People, "id", "full_name");
            ViewBag.status_id = new SelectList(db.STATUS, "id", "status1");
            return View();
        }

        // POST: LISTs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,item_id,quantity,person_id,status_id")] LIST lIST)
        {
            if (ModelState.IsValid)
            {
                db.LISTs.Add(lIST);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.item_id = new SelectList(db.ITEMS, "id", "item1", lIST.item_id);
            ViewBag.person_id = new SelectList(db.People, "id", "full_name", lIST.person_id);
            ViewBag.status_id = new SelectList(db.STATUS, "id", "status1", lIST.status_id);
            return View(lIST);
        }

        // GET: LISTs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LIST lIST = db.LISTs.Find(id);
            if (lIST == null)
            {
                return HttpNotFound();
            }
            ViewBag.item_id = new SelectList(db.ITEMS, "id", "item1", lIST.item_id);
            ViewBag.person_id = new SelectList(db.People, "id", "full_name", lIST.person_id);
            ViewBag.status_id = new SelectList(db.STATUS, "id", "status1", lIST.status_id);
            return View(lIST);
        }

        // POST: LISTs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,item_id,quantity,person_id,status_id")] LIST lIST)
        {
            if (ModelState.IsValid)
            {
                db.Entry(lIST).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.item_id = new SelectList(db.ITEMS, "id", "item1", lIST.item_id);
            ViewBag.person_id = new SelectList(db.People, "id", "full_name", lIST.person_id);
            ViewBag.status_id = new SelectList(db.STATUS, "id", "status1", lIST.status_id);
            return View(lIST);
        }

        // GET: LISTs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LIST lIST = db.LISTs.Find(id);
            if (lIST == null)
            {
                return HttpNotFound();
            }
            return View(lIST);
        }

        // POST: LISTs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            LIST lIST = db.LISTs.Find(id);
            db.LISTs.Remove(lIST);
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
