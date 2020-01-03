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
    public class tbl_External_ReqController : Controller
    {
        private Req2offerDBEntities1 db = new Req2offerDBEntities1();

        // GET: tbl_External_Req
        public ActionResult Index()
        {
            var tbl_External_Req = db.tbl_External_Req.Include(t => t.tbl_Customer).Include(t => t.tbl_Employee_Type).Include(t => t.tbl_User);
            return View(tbl_External_Req.ToList());
        }

        // GET: tbl_External_Req/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_External_Req tbl_External_Req = db.tbl_External_Req.Find(id);
            if (tbl_External_Req == null)
            {
                return HttpNotFound();
            }
            return View(tbl_External_Req);
        }

        //// GET: tbl_External_Req/Create
        //public ActionResult Create()
        //{
        //    ViewBag.Customer_Id = new SelectList(db.tbl_Customer, "Customer_Id", "Customer__Name");
        //    ViewBag.Employee_Type = new SelectList(db.tbl_Employee_Type, "Type_Id", "Employee_Type");
        //    ViewBag.Employee_Id = new SelectList(db.tbl_User, "Employee_Id", "Employee_Name");
        //    return View();
        //}

        //// POST: tbl_External_Req/Create
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create([Bind(Include = "External_Rqq_Id,Customer_Id,Employee_Id,Employee_Type,Account_Manager,Job_Location,Resource_Location,Current_CTC,Expected_CTC,Request_Raised_date,Date_Of_Joining,approved_Budget,Margin,Notice_Period,flag,Role_Id,Skills,Years_Of_Experience")] tbl_External_Req tbl_External_Req)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.tbl_External_Req.Add(tbl_External_Req);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    ViewBag.Customer_Id = new SelectList(db.tbl_Customer, "Customer_Id", "Customer__Name", tbl_External_Req.Customer_Id);
        //    ViewBag.Employee_Type = new SelectList(db.tbl_Employee_Type, "Type_Id", "Employee_Type", tbl_External_Req.Employee_Type);
        //    ViewBag.Employee_Id = new SelectList(db.tbl_User, "Employee_Id", "Employee_Name", tbl_External_Req.Employee_Id);
        //    return View(tbl_External_Req);
        //}

        //// GET: tbl_External_Req/Edit/5
        //public ActionResult Edit(string id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    tbl_External_Req tbl_External_Req = db.tbl_External_Req.Find(id);
        //    if (tbl_External_Req == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    ViewBag.Customer_Id = new SelectList(db.tbl_Customer, "Customer_Id", "Customer__Name", tbl_External_Req.Customer_Id);
        //    ViewBag.Employee_Type = new SelectList(db.tbl_Employee_Type, "Type_Id", "Employee_Type", tbl_External_Req.Employee_Type);
        //    ViewBag.Employee_Id = new SelectList(db.tbl_User, "Employee_Id", "Employee_Name", tbl_External_Req.Employee_Id);
        //    return View(tbl_External_Req);
        //}

        //// POST: tbl_External_Req/Edit/5
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit([Bind(Include = "External_Rqq_Id,Customer_Id,Employee_Id,Employee_Type,Account_Manager,Job_Location,Resource_Location,Current_CTC,Expected_CTC,Request_Raised_date,Date_Of_Joining,approved_Budget,Margin,Notice_Period,flag,Role_Id,Skills,Years_Of_Experience")] tbl_External_Req tbl_External_Req)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(tbl_External_Req).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    ViewBag.Customer_Id = new SelectList(db.tbl_Customer, "Customer_Id", "Customer__Name", tbl_External_Req.Customer_Id);
        //    ViewBag.Employee_Type = new SelectList(db.tbl_Employee_Type, "Type_Id", "Employee_Type", tbl_External_Req.Employee_Type);
        //    ViewBag.Employee_Id = new SelectList(db.tbl_User, "Employee_Id", "Employee_Name", tbl_External_Req.Employee_Id);
        //    return View(tbl_External_Req);
        //}

        //// GET: tbl_External_Req/Delete/5
        //public ActionResult Delete(string id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    tbl_External_Req tbl_External_Req = db.tbl_External_Req.Find(id);
        //    if (tbl_External_Req == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(tbl_External_Req);
        //}

        //// POST: tbl_External_Req/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(string id)
        //{
        //    tbl_External_Req tbl_External_Req = db.tbl_External_Req.Find(id);
        //    db.tbl_External_Req.Remove(tbl_External_Req);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

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
