using DotNetReq2Offer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace DotNetReq2Offer.Controllers
{
    public class UserController : Controller
    {
        Req2offerDBEntities1 db = new Req2offerDBEntities1();
        [HttpGet]
        public ActionResult UserIndex()
        {

            List<tbl_User> list = db.tbl_User.ToList();
            return View(list);
        }

        [HttpGet]
        public ActionResult UserCreate()
        {
            IEnumerable<tbl_Role> tr = db.tbl_Role.ToList();
            List<SelectListItem> li = new List<SelectListItem>();
            li.Add(new SelectListItem() { Text = "Select Role", Value = "0" });
            foreach (var item in tr)
            {
                li.Add(new SelectListItem() { Text = item.Role_Name, Value = item.Id.ToString() });

            }
            TempData["li"] = li;
            TempData.Keep();
            TempData["i"] = db.tbl_User.ToList();
            TempData.Keep();
            return View();
        }
        [HttpPost]
        public ActionResult UserCreate(tbl_User tu)
        {

            if (ModelState.IsValid)
            {
                Req2offerDBEntities1 db = new Req2offerDBEntities1();
                db.tbl_User.Add(tu);
                db.SaveChanges();
                return RedirectToAction("UserIndex");
            }
            return View(tu);
        }

        [HttpGet]
        public ActionResult UserEdit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("UserIndex");
            }
            Req2offerDBEntities1 db = new Req2offerDBEntities1();
            tbl_User tu = db.tbl_User.Where(x => x.Employee_Id == id).Single();
            if (tu == null)
            {
                return HttpNotFound();
            }
            return View(tu);
        }
        [HttpPost]
        public ActionResult UserEdit(tbl_User tu)
        {
            Req2offerDBEntities1 db = new Req2offerDBEntities1();
            db.Entry(tu).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("UserIndex");
        }

        [HttpGet]
        public ActionResult UserDelete(int? id)
        {
            Req2offerDBEntities1 db = new Req2offerDBEntities1();
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_User tu = db.tbl_User.Find(id);
            if (tu == null)
            {
                return HttpNotFound();
            }
            return View(tu);
        }
        [HttpPost, ActionName("UserDelete")]
        public ActionResult UDeleteConfirmed(int id)
        {
            Req2offerDBEntities1 db = new Req2offerDBEntities1();
            tbl_User tu = db.tbl_User.Find(id);
            db.tbl_User.Remove(tu);
            db.SaveChanges();
            return RedirectToAction("UserIndex");
        }

    }
}