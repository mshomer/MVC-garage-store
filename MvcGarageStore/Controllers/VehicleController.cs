using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcGarageStore.Models;
using PagedList;
using System.Web.UI;

namespace MvcGarageStore.Controllers
{
    public class VehicleController : Controller
    {
        private GarageDb db = new GarageDb();

        //
        // GET: /Vehicle/
         public ActionResult Index([Bind(Prefix = "id")] int categoryId, int page = 1)
        {
            var category = db.Categories.Find(categoryId);
            if (category == null)
            {
                return HttpNotFound();               
            }

            ViewBag.CategoryName = category.Name;
            ViewBag.CategoryId = category.Id;

            var list = db.Vehicles
                .OrderByDescending(v => v.Model)
                .Where(v => v.CategoryId.Equals(categoryId))
                .Select(v => new VehicleListViewModel
                {
                    Vehicle = v,
                    Categories = db.Categories
                })
                .ToPagedList(page, 8);

            if (Request.IsAjaxRequest())
            {
                return PartialView("_Vehicle", list);
            }

            return View(list);
        }

        public ActionResult AutoComplete(string term)
        {
            var list = from v in db.Vehicles
                       where (v.Model.StartsWith(term) || v.Type.StartsWith(term))
                       orderby v.Model ascending
                       select v;
            var model = list
                .Take(10)
                .Select(v => new
                {
                    label = v.Model + " " + v.Type
                }
                );

             return Json(model, JsonRequestBehavior.AllowGet);
        }

         public ActionResult List(string searchTerm = null, int page = 1)
        {
            var list = db.Vehicles
                    .OrderByDescending(v => v.Model)
                    .Select(v => new VehicleListViewModel
                {
                    Vehicle = v,
                    Categories = db.Categories
                })
                .ToPagedList(page, 8);

            if (searchTerm != null)
            {
                var term = searchTerm.Split(' ');
                var Term1 = term[0] == null ? "" : term[0];
                var Term2 = term.Length < 2 ? "" : term[1];

                list = db.Vehicles
                    .OrderByDescending(v => v.Model)
                    .Where(v => v.Model.Contains(Term1) && v.Type.Contains(Term2) || v.Model.Contains(Term2) && v.Type.Contains(Term1))
                    .Select(v => new VehicleListViewModel
                    {
                        Vehicle = v,
                        Categories = db.Categories
                    })
                    .ToPagedList(page, 8);
            }


            if (Request.IsAjaxRequest())
            {
                return PartialView("_Vehicle", list);
            }

            return View(list);
        }
        

        //
        // GET: /Vehicle/Details/5

        public ActionResult Details(int id = 0)
        {
            Vehicle vehicle = db.Vehicles.Find(id);
            if (vehicle == null)
            {
                return HttpNotFound();
            }
            return View(vehicle);
        }

        //
        // GET: /Vehicle/Create

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Vehicle/Create

        [HttpPost]
        [Authorize(Roles = "Admin")]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Vehicle vehicle)
        {
            if (ModelState.IsValid)
            {
                db.Vehicles.Add(vehicle);
                db.SaveChanges();
                return RedirectToAction("Index", new { id = vehicle.CategoryId });
            }

            return View(vehicle);
        }

        //
        // GET: /Vehicle/Edit/5
        [Authorize(Roles = "Admin")]
        public ActionResult Edit(int id = 0)
        {
            Vehicle vehicle = db.Vehicles.Find(id);
            if (vehicle == null)
            {
                return HttpNotFound();
            }
            return View(vehicle);
        }

        //
        // POST: /Vehicle/Edit/5

        [HttpPost]
        [Authorize(Roles = "Admin")]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Vehicle vehicle)
        {
            if (ModelState.IsValid)
            {
                db.Entry(vehicle).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index", new { id = vehicle.CategoryId });
            }
            return View(vehicle);
        }

        //
        // GET: /Vehicle/Delete/5
        [Authorize(Roles = "Admin")]
        public ActionResult Delete(int id = 0)
        {
            Vehicle vehicle = db.Vehicles.Find(id);
            if (vehicle == null)
            {
                return HttpNotFound();
            }
            return View(vehicle);
        }

        //
        // POST: /Vehicle/Delete/5

        [HttpPost, ActionName("Delete")]
        [Authorize(Roles = "Admin")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Vehicle vehicle = db.Vehicles.Find(id);
            db.Vehicles.Remove(vehicle);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}