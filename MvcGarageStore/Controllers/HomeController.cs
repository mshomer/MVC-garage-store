using MvcGarageStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcGarageStore.Controllers
{
    public class HomeController : Controller
    {
        GarageDb db = new GarageDb();

        public ActionResult Index()
        {
            var model =
                from c in db.Vehicles
                where c.ImageUrl != "no_image.gif"
                orderby c.Model ascending
                select c;

            return View(model);
        }

        [HttpGet]
        public ActionResult About(bool sentContact = false)
        {
            ViewBag.Message = "Welcome To MvcGarageStore application.";
            ViewBag.sentContact = sentContact;
            return View();
        }

        [HttpPost]
        [Authorize]
        public ActionResult About(Contact contact)
        {
            if (ModelState.IsValid)
            {
                db.Contact.Add(contact);
                db.SaveChanges();
                return RedirectToAction("About", new { sentContact = true });
            }

            return View(contact);
        }

        [Authorize(Roles = "Admin")]
        public ActionResult ContactList()
        {
            var contact =
               from c in db.Contact
               orderby c.FullName ascending
               select c;

            return View(contact);
        }

        
        [Authorize(Roles = "Admin")]
        public ActionResult DeleteContact(int id = 0)
        {
            Contact contact = db.Contact.Find(id);
            if (contact == null)
            {
                return HttpNotFound();
            }
            return View(contact);
        }

        [Authorize(Roles = "Admin")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Contact contact = db.Contact.Find(id);
            db.Contact.Remove(contact);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Contact()
        {
            return View();
        }

        protected override void Dispose(bool disposing)
        {
            if (db != null)
            {
                db.Dispose();
            }

            base.Dispose(disposing);
        }
    }
}
