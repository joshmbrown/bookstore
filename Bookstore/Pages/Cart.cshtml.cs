using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bookstore.Infrastructure;
using Bookstore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Bookstore.Pages
{
    public class CartModel : PageModel
    {
        private IBookstoreRepository _repo { get; set; }

        public CartModel (IBookstoreRepository repo)
        {
            _repo = repo;
        }

        public Cart cart { get; set; }
        public string ReturnURL { get; set; }

        public void OnGet(string returnURL)
        {
            cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();
            ReturnURL = returnURL ?? "/";
        }

        public IActionResult OnPost(int bookID, string returnURL)
        {
            Book book = _repo.Books.FirstOrDefault(x => x.BookId == bookID);

            Cart cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();
            cart.AddItem(book, 1);

            HttpContext.Session.SetJson("cart", cart);

            return RedirectToPage(new { ReturnURL = returnURL });
        }
    }
}
