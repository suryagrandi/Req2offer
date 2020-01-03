﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DotNetReq2Offer.Models;

namespace DotNetReq2Offer.Controllers
{
    public class tbl_Employee_TypeController : Controller
    {
        private Req2offerDBEntities1 db = new Req2offerDBEntities1();

        // GET: tbl_Employee_Type
        public ActionResult Index()
        {
            return View(db.tbl_Employee_Type.ToList());
        }

        // GET: tbl_Employee_Type/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_Employee_Type tbl_Employee_Type = db.tbl_Employee_Type.Find(id);
            if (tbl_Employee_Type == null)
            {
                return HttpNotFound();
            }
            return View(tbl_Employee_Type);
        }

        // GET: tbl_Employee_Type/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: tbl_Employee_Type/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Type_Id,Employee_Type")] tbl_Employee_Type tbl_Employee_Type)
        {
            if (ModelState.IsValid)
            {
                db.tbl_Employee_Type.Add(tbl_Employee_Type);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tbl_Employee_Type);
        }

        // GET: tbl_Employee_Type/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_Employee_Type tbl_Employee_Type = db.tbl_Employee_Type.Find(id);
            if (tbl_Employee_Type == null)
            {
                return HttpNotFound();
            }
            return View(tbl_Employee_Type);
        }

        // POST: tbl_Employee_Type/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Type_Id,Employee_Type")] tbl_Employee_Type tbl_Employee_Type)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tbl_Employee_Type).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tbl_Employee_Type);
        }

        // GET: tbl_Employee_Type/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_Employee_Type tbl_Employee_Type = db.tbl_Employee_Type.Find(id);
            if (tbl_Employee_Type == null)
            {
                return HttpNotFound();
            }
            return View(tbl_Employee_Type);
        }

        // POST: tbl_Employee_Type/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tbl_Employee_Type tbl_Employee_Type = db.tbl_Employee_Type.Find(id);
            db.tbl_Employee_Type.Remove(tbl_Employee_Type);
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
