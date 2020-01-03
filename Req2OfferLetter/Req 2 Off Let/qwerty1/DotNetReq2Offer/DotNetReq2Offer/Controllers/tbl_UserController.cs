using System;
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
    public class tbl_UserController : Controller
    {
        private Req2offerEntities db = new Req2offerEntities();

        // GET: tbl_User
        public ActionResult Index()
        {
            var tbl_User = db.tbl_User.Include(t => t.tbl_Role);
            return View(tbl_User.ToList());
        }

        // GET: tbl_User/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_User tbl_User = db.tbl_User.Find(id);
            if (tbl_User == null)
            {
                return HttpNotFound();
            }
            return View(tbl_User);
        }

        // GET: tbl_User/Create
        public ActionResult Create()
        {
            ViewBag.Role_Id = new SelectList(db.tbl_Role, "Id", "Role_Name");
            return View();
        }

        // POST: tbl_User/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Employee_Id,Employee_Name,Email_Id,Contact_Number,Password,Password_Date,Role_Id,Created_Date,Flag,Reporting_Manager")] tbl_User tbl_User)
        {
            if (ModelState.IsValid)
            {
                db.tbl_User.Add(tbl_User);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Role_Id = new SelectList(db.tbl_Role, "Id", "Role_Name", tbl_User.Role_Id);
            return View(tbl_User);
        }

        // GET: tbl_User/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_User tbl_User = db.tbl_User.Find(id);
            if (tbl_User == null)
            {
                return HttpNotFound();
            }
            ViewBag.Role_Id = new SelectList(db.tbl_Role, "Id", "Role_Name", tbl_User.Role_Id);
            return View(tbl_User);
        }

        // POST: tbl_User/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Employee_Id,Employee_Name,Email_Id,Contact_Number,Password,Password_Date,Role_Id,Created_Date,Flag,Reporting_Manager")] tbl_User tbl_User)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tbl_User).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Role_Id = new SelectList(db.tbl_Role, "Id", "Role_Name", tbl_User.Role_Id);
            return View(tbl_User);
        }

        // GET: tbl_User/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_User tbl_User = db.tbl_User.Find(id);
            if (tbl_User == null)
            {
                return HttpNotFound();
            }
            return View(tbl_User);
        }

        // POST: tbl_User/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tbl_User tbl_User = db.tbl_User.Find(id);
            db.tbl_User.Remove(tbl_User);
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
