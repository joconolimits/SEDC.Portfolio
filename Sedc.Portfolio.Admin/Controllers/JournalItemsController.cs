﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SEDC.Portfolio.Core.Entities;
using SEDC.Portfolio.Infrastructure;

namespace Sedc.Portfolio.Admin.Controllers
{
    public class JournalItemsController : Controller
    {
        private PortfolioDbContext db = new PortfolioDbContext();

        // GET: JournalItems
        public ActionResult Index()
        {
            return View(db.JournalItems.ToList());
        }

        // GET: JournalItems/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            JournalItem journalItem = db.JournalItems.Find(id);
            if (journalItem == null)
            {
                return HttpNotFound();
            }
            return View(journalItem);
        }

        // GET: JournalItems/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: JournalItems/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Title,Description,ImageUrl,ItemUrl")] JournalItem journalItem)
        {
            if (ModelState.IsValid)
            {
                db.JournalItems.Add(journalItem);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(journalItem);
        }

        // GET: JournalItems/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            JournalItem journalItem = db.JournalItems.Find(id);
            if (journalItem == null)
            {
                return HttpNotFound();
            }
            return View(journalItem);
        }

        // POST: JournalItems/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Title,Description,ImageUrl,ItemUrl")] JournalItem journalItem)
        {
            if (ModelState.IsValid)
            {
                db.Entry(journalItem).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(journalItem);
        }

        // GET: JournalItems/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            JournalItem journalItem = db.JournalItems.Find(id);
            if (journalItem == null)
            {
                return HttpNotFound();
            }
            return View(journalItem);
        }

        // POST: JournalItems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            JournalItem journalItem = db.JournalItems.Find(id);
            db.JournalItems.Remove(journalItem);
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
