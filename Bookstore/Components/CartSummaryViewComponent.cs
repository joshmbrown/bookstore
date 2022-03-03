using System;
using Bookstore.Models;
using Microsoft.AspNetCore.Mvc;
namespace Bookstore.Components
{
    public class CartSummaryViewComponent : ViewComponent
    {
        private Cart _cart { get; set; }

        public CartSummaryViewComponent(Cart cartService)
        {
            _cart = cartService;
        }

        public IViewComponentResult Invoke()
        {
            return View(_cart);
        }
    }
}