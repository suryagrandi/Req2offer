using DotNetReq2Offer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DotNetReq2Offer.Controllers
{
    public class UserDashBoardController : Controller
    {
        // GET: UserDashBoard
        Req2offerDBEntities1 db = new Req2offerDBEntities1();
        // GET: User
        [HttpGet]
        public ActionResult Role()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Role(tbl_Role r)
        {

            db.tbl_Role.Add(r);
            db.SaveChanges();
            return RedirectToAction("List");
        }
        [HttpGet]
        public ActionResult List()
        {
            return View(db.tbl_Role.ToList());

        }
        [HttpGet]
        public ActionResult UserCreate()
        {
            IEnumerable<tbl_Role> t = db.tbl_Role.ToList();
            List<SelectListItem> li = new List<SelectListItem>();
            li.Add(new SelectListItem() { Text = "Select Role", Value = "0" });
            foreach (var item in t)
            {
                li.Add(new SelectListItem() { Text = item.Role_Name, Value = item.Id.ToString() });

            }
            TempData["li"] = li;
            TempData.Keep();
            return View();
        }
        [HttpPost]
        public ActionResult UserCreate(tbl_User u)
        {
            db.tbl_User.Add(u);
            db.SaveChanges();
            return RedirectToAction("UserList");
        }
        public ActionResult UserList()
        {
            return View(db.tbl_User.ToList());

        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(tbl_User user)
        {
            if (ModelState.IsValid)
            {
                var obj = db.tbl_User.Where(p => p.Employee_Name == user.Employee_Name && p.Password == user.Password).FirstOrDefault();

                if (obj != null)
                {
                    Session["Id"] = obj.Employee_Id.ToString();
                    Session["Employee_Name"] = obj.Employee_Name.ToString();
                    return RedirectToAction("UserDashBoard");
                }
            }
            else
            {
                ViewBag.msg = "UserName or Password does not match";
            }
            return View();
        }
        public ActionResult UserDashBoard()
        {
            if (Session["Id"] != null)
            {
                ViewBag.message = "Welcome" + "   " + Session["Employee_Name"];
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }

        }
      
        public ActionResult Logout()
        {
            Session.Abandon();
            return RedirectToAction("Login");
           
        }
    }
}