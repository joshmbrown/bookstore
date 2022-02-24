using System;
using System.Linq;
using Bookstore.Models;
using Microsoft.AspNetCore.Mvc;

namespace Bookstore.Components
{
    public class CategoryViewComponent : ViewComponent
    {
        private IBookstoreRepository _repo { get; set; }

        public CategoryViewComponent(IBookstoreRepository repo)
        {
            _repo = repo;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedCategory = RouteData?.Values["category"];

            var categories = _repo.Books
                .Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x);

            return View(categories);
        }
    }
}
