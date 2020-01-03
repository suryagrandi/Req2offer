using DotNetReq2Offer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace DotNetReq2Offer.Controllers
{
    public class RoleController : Controller
    {
        [HttpGet]
        public ActionResult RoleIndex()
        {
            Req2offerDBEntities1 db = new Req2offerDBEntities1();
            List<tbl_Role> list = db.tbl_Role.ToList();
            return View(list);
        }

        [HttpGet]
        public ActionResult RoleCreate()
        {
            return View();
        }
        [HttpPost]
        public ActionResult RoleCreate(tbl_Role tr)
        {
            if (ModelState.IsValid)
            {
                Req2offerDBEntities1 db = new Req2offerDBEntities1();
                db.tbl_Role.Add(tr);
                db.SaveChanges();
                return RedirectToAction("RoleIndex");
            }
            return View(tr);
        }

        [HttpGet]
        public ActionResult RoleEdit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("RoleIndex");
            }
            Req2offerDBEntities1 db = new Req2offerDBEntities1();
            tbl_Role tr1 = db.tbl_Role.Where(x => x.Id == id).Single();
            if (tr1 == null)
            {
                return HttpNotFound();
            }
            return View(tr1);
        }
        [HttpPost]
        public ActionResult RoleEdit(tbl_Role tr)
        {
            Req2offerDBEntities1 db = new Req2offerDBEntities1();
            db.Entry(tr).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("RoleIndex");
        }

        [HttpGet]
        public ActionResult RoleDelete(int? id)
        {
            Req2offerDBEntities1 db = new Req2offerDBEntities1();
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_Role tr = db.tbl_Role.Find(id);
            if (tr == null)
            {
                return HttpNotFound();
            }
            return View(tr);
        }
        [HttpPost, ActionName("RoleDelete")]
        public ActionResult RDeleteConfirm(int? id)
        {
            Req2offerDBEntities1 db = new Req2offerDBEntities1();
            tbl_Role tr = db.tbl_Role.Find(id);
            db.tbl_Role.Remove(tr);
            db.SaveChanges();
            return RedirectToAction("RoleIndex");
        }

    }
}