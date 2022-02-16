using System;
using System.Linq;

namespace Bookstore.Models
{
    public class EFBookstoreRepository : IBookstoreRepository
    {
        private BookstoreContext _context { get; set; }

        public EFBookstoreRepository (BookstoreContext context)
        {
            _context = context;
        }

        public IQueryable<Book> Books => _context.Books;
    }
}
