using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bookstore.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Bookstore.Controllers
{
    public class CheckoutController : Controller
    {
        private ICheckoutRepository _repo { get; set; }
        private Cart _cart { get; set; }
        public CheckoutController(ICheckoutRepository repo, Cart cart)
        {
            _repo = repo;
            _cart = cart;
        }

        // View the checkout screen
        [HttpGet]
        public IActionResult Checkout()
        {
            return View(new Checkout());
        }

        // Checkout the cart
        [HttpPost]
        public IActionResult Checkout(Checkout checkout)
        {
            if (_cart.Items.Count() == 0)
            {
                ModelState.AddModelError("", "Your cart is empty!");
            }

            if (ModelState.IsValid)
            {
                checkout.LineItems = _cart.Items.ToArray();
                _repo.SaveCheckout(checkout);
                _cart.ClearCart();

                return RedirectToPage("/Confirmation");
            }
            else
            {
                return View();
            }
        }
    }
}
