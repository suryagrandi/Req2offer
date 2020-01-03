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
    public class tbl_Internal_ReqController : Controller
    {
        private Req2offerDBEntities1 db = new Req2offerDBEntities1();

        // GET: tbl_Internal_Req
        public ActionResult Index()
        {
            var tbl_Internal_Req = db.tbl_Internal_Req.Include(t => t.tbl_Business_Unit).Include(t => t.tbl_Cost_Center).Include(t => t.tbl_Employee_Type).Include(t => t.tbl_User).Include(t => t.tbl_User1).Include(t => t.tbl_Sub_Business_Unit);
            return View(tbl_Internal_Req.ToList());
        }

        // GET: tbl_Internal_Req/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_Internal_Req tbl_Internal_Req = db.tbl_Internal_Req.Find(id);
            if (tbl_Internal_Req == null)
            {
                return HttpNotFound();
            }
            return View(tbl_Internal_Req);
        }

        //// GET: tbl_Internal_Req/Create
        //public ActionResult Create()
        //{
        //    ViewBag.Bu_Id = new SelectList(db.tbl_Business_Unit, "Bu_Id", "Bu_Name");
        //    ViewBag.Cost_Center_Id = new SelectList(db.tbl_Cost_Center, "Cost_Center_Id", "Cost_Center_Name");
        //    ViewBag.Employee_Type = new SelectList(db.tbl_Employee_Type, "Type_Id", "Employee_Type");
        //    ViewBag.Employee_Id = new SelectList(db.tbl_User, "Employee_Id", "Employee_Name");
        //    ViewBag.Reporting_Manager = new SelectList(db.tbl_User, "Employee_Id", "Employee_Name");
        //    ViewBag.Sub_Id = new SelectList(db.tbl_Sub_Business_Unit, "Sub_Id", "Sub_Name");
        //    return View();
        //}

        //// POST: tbl_Internal_Req/Create
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create([Bind(Include = "Internal_Rqq_Id,Employee_Id,Employee_Type,Skill,Reporting_Manager,Cost_Center_Id,Budget,Request_Raised_Date,Date_Of_Joining,Flag,Notice_period,Years_Of_Experience,Sub_Id,Bu_Id")] tbl_Internal_Req tbl_Internal_Req)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.tbl_Internal_Req.Add(tbl_Internal_Req);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    ViewBag.Bu_Id = new SelectList(db.tbl_Business_Unit, "Bu_Id", "Bu_Name", tbl_Internal_Req.Bu_Id);
        //    ViewBag.Cost_Center_Id = new SelectList(db.tbl_Cost_Center, "Cost_Center_Id", "Cost_Center_Name", tbl_Internal_Req.Cost_Center_Id);
        //    ViewBag.Employee_Type = new SelectList(db.tbl_Employee_Type, "Type_Id", "Employee_Type", tbl_Internal_Req.Employee_Type);
        //    ViewBag.Employee_Id = new SelectList(db.tbl_User, "Employee_Id", "Employee_Name", tbl_Internal_Req.Employee_Id);
        //    ViewBag.Reporting_Manager = new SelectList(db.tbl_User, "Employee_Id", "Employee_Name", tbl_Internal_Req.Reporting_Manager);
        //    ViewBag.Sub_Id = new SelectList(db.tbl_Sub_Business_Unit, "Sub_Id", "Sub_Name", tbl_Internal_Req.Sub_Id);
        //    return View(tbl_Internal_Req);
        //}

        //// GET: tbl_Internal_Req/Edit/5
        //public ActionResult Edit(string id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    tbl_Internal_Req tbl_Internal_Req = db.tbl_Internal_Req.Find(id);
        //    if (tbl_Internal_Req == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    ViewBag.Bu_Id = new SelectList(db.tbl_Business_Unit, "Bu_Id", "Bu_Name", tbl_Internal_Req.Bu_Id);
        //    ViewBag.Cost_Center_Id = new SelectList(db.tbl_Cost_Center, "Cost_Center_Id", "Cost_Center_Name", tbl_Internal_Req.Cost_Center_Id);
        //    ViewBag.Employee_Type = new SelectList(db.tbl_Employee_Type, "Type_Id", "Employee_Type", tbl_Internal_Req.Employee_Type);
        //    ViewBag.Employee_Id = new SelectList(db.tbl_User, "Employee_Id", "Employee_Name", tbl_Internal_Req.Employee_Id);
        //    ViewBag.Reporting_Manager = new SelectList(db.tbl_User, "Employee_Id", "Employee_Name", tbl_Internal_Req.Reporting_Manager);
        //    ViewBag.Sub_Id = new SelectList(db.tbl_Sub_Business_Unit, "Sub_Id", "Sub_Name", tbl_Internal_Req.Sub_Id);
        //    return View(tbl_Internal_Req);
        //}

        //// POST: tbl_Internal_Req/Edit/5
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit([Bind(Include = "Internal_Rqq_Id,Employee_Id,Employee_Type,Skill,Reporting_Manager,Cost_Center_Id,Budget,Request_Raised_Date,Date_Of_Joining,Flag,Notice_period,Years_Of_Experience,Sub_Id,Bu_Id")] tbl_Internal_Req tbl_Internal_Req)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(tbl_Internal_Req).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    ViewBag.Bu_Id = new SelectList(db.tbl_Business_Unit, "Bu_Id", "Bu_Name", tbl_Internal_Req.Bu_Id);
        //    ViewBag.Cost_Center_Id = new SelectList(db.tbl_Cost_Center, "Cost_Center_Id", "Cost_Center_Name", tbl_Internal_Req.Cost_Center_Id);
        //    ViewBag.Employee_Type = new SelectList(db.tbl_Employee_Type, "Type_Id", "Employee_Type", tbl_Internal_Req.Employee_Type);
        //    ViewBag.Employee_Id = new SelectList(db.tbl_User, "Employee_Id", "Employee_Name", tbl_Internal_Req.Employee_Id);
        //    ViewBag.Reporting_Manager = new SelectList(db.tbl_User, "Employee_Id", "Employee_Name", tbl_Internal_Req.Reporting_Manager);
        //    ViewBag.Sub_Id = new SelectList(db.tbl_Sub_Business_Unit, "Sub_Id", "Sub_Name", tbl_Internal_Req.Sub_Id);
        //    return View(tbl_Internal_Req);
        //}

        //// GET: tbl_Internal_Req/Delete/5
        //public ActionResult Delete(string id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    tbl_Internal_Req tbl_Internal_Req = db.tbl_Internal_Req.Find(id);
        //    if (tbl_Internal_Req == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(tbl_Internal_Req);
        //}

        //// POST: tbl_Internal_Req/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(string id)
        //{
        //    tbl_Internal_Req tbl_Internal_Req = db.tbl_Internal_Req.Find(id);
        //    db.tbl_Internal_Req.Remove(tbl_Internal_Req);
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
