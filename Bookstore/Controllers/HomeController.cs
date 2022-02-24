using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Bookstore.Models;
using Bookstore.Models.ViewModels;

namespace Bookstore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IBookstoreRepository _repo;

        public HomeController(ILogger<HomeController> logger, IBookstoreRepository repo)
        {
            _logger = logger;
            _repo = repo;
        }

        public IActionResult Index(string category, int pageNum = 1)
        {
            int booksPerPage = 10;
            int booksToSkip = (pageNum - 1) * booksPerPage;

            var viewModel = new BooksViewModel
            {
                Books = _repo.Books
                .Where(b => category == null || b.Category == category)
                .OrderBy(b => b.Title)
                .Skip(booksToSkip)
                .Take(booksPerPage),

                PageInfo = new PageInfo
                {
                    TotalNumBooks =
                        (category == null
                            ? _repo.Books.Count()
                            : _repo.Books.Where(x => x.Category == category).Count()),
                    BooksPerPage = booksPerPage,
                    CurrentPage = pageNum
                }
            };

            return View(viewModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
