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
    public class tbl_Select_CandidateController : Controller
    {
        private Req2offerDBEntities1 db = new Req2offerDBEntities1();

        // GET: tbl_Select_Candidate
        public ActionResult Index()
        {
            var tbl_Select_Candidate = db.tbl_Select_Candidate.Include(t => t.tbl_Employee_Type).Include(t => t.tbl_External_Req).Include(t => t.tbl_Internal_Req);
            return View(tbl_Select_Candidate.ToList());
        }

        // GET: tbl_Select_Candidate/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_Select_Candidate tbl_Select_Candidate = db.tbl_Select_Candidate.Find(id);
            if (tbl_Select_Candidate == null)
            {
                return HttpNotFound();
            }
            return View(tbl_Select_Candidate);
        }

        // GET: tbl_Select_Candidate/Create
        public ActionResult Create()
        {
            ViewBag.Employee_Type = new SelectList(db.tbl_Employee_Type, "Type_Id", "Employee_Type");
            ViewBag.External_Rqq_Id = new SelectList(db.tbl_External_Req, "External_Rqq_Id", "Account_Manager");
            ViewBag.Internal_Rqq_Id = new SelectList(db.tbl_Internal_Req, "Internal_Rqq_Id", "Skill");
            return View();
        }

        // POST: tbl_Select_Candidate/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Reference_number,Creation_Date,Employee_Name,Employee_Type,Email_Id,Contact_Number,Job_Location,External_Rqq_Id,Internal_Rqq_Id,Designation,Offer_Validity_Date,CTC,Joining_Date,Flag")] tbl_Select_Candidate tbl_Select_Candidate)
        {
            if (ModelState.IsValid)
            {
                db.tbl_Select_Candidate.Add(tbl_Select_Candidate);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Employee_Type = new SelectList(db.tbl_Employee_Type, "Type_Id", "Employee_Type", tbl_Select_Candidate.Employee_Type);
            ViewBag.External_Rqq_Id = new SelectList(db.tbl_External_Req, "External_Rqq_Id", "Account_Manager", tbl_Select_Candidate.External_Rqq_Id);
            ViewBag.Internal_Rqq_Id = new SelectList(db.tbl_Internal_Req, "Internal_Rqq_Id", "Skill", tbl_Select_Candidate.Internal_Rqq_Id);
            return View(tbl_Select_Candidate);
        }

        // GET: tbl_Select_Candidate/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_Select_Candidate tbl_Select_Candidate = db.tbl_Select_Candidate.Find(id);
            if (tbl_Select_Candidate == null)
            {
                return HttpNotFound();
            }
            ViewBag.Employee_Type = new SelectList(db.tbl_Employee_Type, "Type_Id", "Employee_Type", tbl_Select_Candidate.Employee_Type);
            ViewBag.External_Rqq_Id = new SelectList(db.tbl_External_Req, "External_Rqq_Id", "Account_Manager", tbl_Select_Candidate.External_Rqq_Id);
            ViewBag.Internal_Rqq_Id = new SelectList(db.tbl_Internal_Req, "Internal_Rqq_Id", "Skill", tbl_Select_Candidate.Internal_Rqq_Id);
            return View(tbl_Select_Candidate);
        }

        // POST: tbl_Select_Candidate/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Reference_number,Creation_Date,Employee_Name,Employee_Type,Email_Id,Contact_Number,Job_Location,External_Rqq_Id,Internal_Rqq_Id,Designation,Offer_Validity_Date,CTC,Joining_Date,Flag")] tbl_Select_Candidate tbl_Select_Candidate)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tbl_Select_Candidate).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Employee_Type = new SelectList(db.tbl_Employee_Type, "Type_Id", "Employee_Type", tbl_Select_Candidate.Employee_Type);
            ViewBag.External_Rqq_Id = new SelectList(db.tbl_External_Req, "External_Rqq_Id", "Account_Manager", tbl_Select_Candidate.External_Rqq_Id);
            ViewBag.Internal_Rqq_Id = new SelectList(db.tbl_Internal_Req, "Internal_Rqq_Id", "Skill", tbl_Select_Candidate.Internal_Rqq_Id);
            return View(tbl_Select_Candidate);
        }

        // GET: tbl_Select_Candidate/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_Select_Candidate tbl_Select_Candidate = db.tbl_Select_Candidate.Find(id);
            if (tbl_Select_Candidate == null)
            {
                return HttpNotFound();
            }
            return View(tbl_Select_Candidate);
        }

        // POST: tbl_Select_Candidate/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tbl_Select_Candidate tbl_Select_Candidate = db.tbl_Select_Candidate.Find(id);
            db.tbl_Select_Candidate.Remove(tbl_Select_Candidate);
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
