using DotNetReq2Offer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DotNetReq2Offer.Controllers
{
	public class CustomerDetailsController : Controller
	{
		// GET: CustomerDetails
		Req2offerDBEntities1 db = new Req2offerDBEntities1();
		// GET: Home
		[HttpGet]
		public ActionResult Index()
		{
			List<tbl_Customer> list = db.tbl_Customer.ToList();
			return View(list);

		}
		//	[HttpGet]
		//	public ActionResult Create()
		//	{

		//			IEnumerable<tbl_Customer> t = db.tbl_Customer.ToList();
		//			List<SelectListItem> li = new List<SelectListItem>();
		//			li.Add(new SelectListItem() { Text = "Select Location", Value = "0" });
		//			foreach (var item in t)
		//			{
		//				li.Add(new SelectListItem() { Text = item.Location, Value = item.Customer_Id.ToString() });
		//			}


		//	TempData["li"] = li;
		//          TempData.Keep();
		//          return View();
		//}


		//	[HttpPost, ActionName("Create")]
		//	public ActionResult create(tbl_Customer objEmp)
		//	{
		//		if (ModelState.IsValid)
		//		{
		//			db.tbl_Customer.Add(objEmp);
		//			db.SaveChanges();
		//			return RedirectToAction("Index");
		//		}
		//		return View();
		//	}

		public ActionResult Create()
		{

			return View();
		}
		[HttpPost]
		public ActionResult Create(tbl_Customer userinfo)
		{
			string message = "";
			if (ModelState.IsValid)
			{
				try
				{
					using (Req2offerDBEntities1 db = new Req2offerDBEntities1())
					{
						db.tbl_Customer.Add(userinfo);
						db.SaveChanges();
						message = "Successfully Saved!";
					}
				}
				catch (Exception ex)
				
				{ message = "Error! Please try again."; }
			}

			else
			{
				//return View();
				message = "Please provide required fields value.";
			}
			if (Request.IsAjaxRequest())
			{
				return new JsonResult { Data = message, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
			}
			else
			{
				ViewBag.Message = message;

				return View(userinfo);
			}


		}
			

	



		public ActionResult Delete(int? id)
		{

			if (id != null)
			{
				tbl_Customer tr = db.tbl_Customer.Find(id);
				db.tbl_Customer.Remove(tr);
				db.SaveChanges();
				return RedirectToAction("Index");
			}
			return View();
		}
		public ActionResult Edit(int? id)
		{

			if (id == null)
			{
				return RedirectToAction("Index");
			}

			tbl_Customer tr1 = db.tbl_Customer.Where(x => x.Customer_Id == id).Single();
			if (tr1 == null)
			{
				return HttpNotFound();
			}
			return View(tr1);
		}


		[HttpPost]
		public ActionResult Edit(tbl_Customer tr)
		{

			db.Entry(tr).State = System.Data.Entity.EntityState.Modified;
			db.SaveChanges();

			//return RedirectToAction("Index");

			if (Request.IsAjaxRequest())
			{
				return new JsonResult { JsonRequestBehavior = JsonRequestBehavior.AllowGet };
			}
			else
			{
				//ViewBag.Message = message;
				return View(tr);
			}
		}
		public ActionResult Details(int id)
		{

			tbl_Customer tbl = db.tbl_Customer.Single(tbl_Customer => tbl_Customer.Customer_Id == id);
			return View(tbl);
		}
	}
}