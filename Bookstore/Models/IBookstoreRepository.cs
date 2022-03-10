using System;
using System.Linq;

namespace Bookstore.Models
{
    public interface IBookstoreRepository
    {
        IQueryable<Book> Books { get; }

        public void SaveBook(Book b);
        public void AddBook(Book b);
        public void DeleteBook(Book b);
    }
}
