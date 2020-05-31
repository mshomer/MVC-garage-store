using MvcGarageStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcGarageStore.Controllers
{
    public class ShoppingCartController : Controller
    {
        GarageDb db = new GarageDb();

        //
        // GET: /ShoppingCart/

        public ActionResult Index()
        {
            var cart = ShoppingCart.GetCart(this.HttpContext);

            // Set up our ViewModel
            var viewModel = new ShoppingCartViewModel
            {
                CartItems = cart.GetCartItems(),
                CartTotal = cart.GetTotal()
            };

            // Return the view
            return View(viewModel);
        }

        //
        // GET: /Store/AddToCart/
        [Authorize]
        public ActionResult AddToCart(int id)
        {

            // Retrieve the product from the database
            var addedProduct = db.Vehicles
                .Single(vehicle => vehicle.Id == id);

            // Add it to the shopping cart
            var cart = ShoppingCart.GetCart(this.HttpContext);

            cart.AddToCart(addedProduct);

            // Go back to the main store page for more shopping
            return RedirectToAction("Index");
        }

        //
        // AJAX: /ShoppingCart/RemoveFromCart/

        [HttpPost]
        [Authorize]
        public ActionResult RemoveFromCart(int id)
        {
            // Remove the item from the cart
            var cart = ShoppingCart.GetCart(this.HttpContext);

            // Get the Model of the vehicle to display confirmation
            string vehicleModel = db.Carts
                .Single(item => item.RecordId == id).Vehicle.Model;

            // Get the Type of the vehicle to display confirmation
            string vehicleType = db.Carts
                .Single(item => item.RecordId == id).Vehicle.Type;


            // Remove from cart
            int itemCount = cart.RemoveFromCart(id);

            return RedirectToAction("Index");           
        }

        //
        // GET: /ShoppingCart/CartSummary

        [ChildActionOnly]
        public ActionResult CartSummary()
        {
            var cart = ShoppingCart.GetCart(this.HttpContext);

            ViewData["CartCount"] = cart.GetCount();

            return PartialView("CartSummary");
        }

    }
}
