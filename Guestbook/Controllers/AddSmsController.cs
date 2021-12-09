using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Guestbook.Models;

namespace Guestbook.Controllers
{
    public class AddSmsController : Controller
    {
        private Model1 db = new Model1();

        // GET: AddSms
        public ActionResult Index()
        {
            return View(db.AddSms.ToList());
        }

        // GET: AddSms/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AddSms addSms = db.AddSms.Find(id);
            if (addSms == null)
            {
                return HttpNotFound();
            }
            return View(addSms);
        }

        // GET: AddSms/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AddSms/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdMs,ContentMs")] AddSms addSms)
        {
            if (ModelState.IsValid)
            {
                db.AddSms.Add(addSms);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(addSms);
        }

        // GET: AddSms/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AddSms addSms = db.AddSms.Find(id);
            if (addSms == null)
            {
                return HttpNotFound();
            }
            return View(addSms);
        }

        // POST: AddSms/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdMs,ContentMs")] AddSms addSms)
        {
            if (ModelState.IsValid)
            {
                db.Entry(addSms).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(addSms);
        }

        // GET: AddSms/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AddSms addSms = db.AddSms.Find(id);
            if (addSms == null)
            {
                return HttpNotFound();
            }
            return View(addSms);
        }

        // POST: AddSms/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AddSms addSms = db.AddSms.Find(id);
            db.AddSms.Remove(addSms);
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
