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

        public void SaveBook(Book b)
        {
            _context.SaveChanges();
        }

        public void AddBook(Book b)
        {
            _context.Add(b);
            _context.SaveChanges();
        }

        public void DeleteBook(Book b)
        {
            _context.Remove(b);
            _context.SaveChanges();
        }
    }
}
