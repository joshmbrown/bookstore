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

        public Cart cart { get; set; }
        public string ReturnURL { get; set; }

        public CartModel (IBookstoreRepository repo, Cart c)
        {
            _repo = repo;
            cart = c;
        }

        public void OnGet(string returnURL)
        {
            ReturnURL = returnURL ?? "/";
        }

        public IActionResult OnPost(int bookID, string returnURL)
        {
            Book book = _repo.Books.FirstOrDefault(x => x.BookId == bookID);

            cart.AddItem(book, 1);

            return RedirectToPage(new { ReturnURL = returnURL });
        }

        public IActionResult OnPostRemove(int bookID, string returnURL)
        {
            cart.RemoveItem(cart.Items.First(x => x.Book.BookId == bookID).Book);

            return RedirectToPage(new { ReturnURL = returnURL });
        }
    }
}
