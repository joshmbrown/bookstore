using System;
using System.Collections.Generic;
using System.Linq;

namespace Bookstore.Models
{
    public class Cart
    {
        public List<CartLineItem> Items { get; set; } = new List<CartLineItem>();

        public void AddItem(Book book, int quantity)
        {
            CartLineItem line = Items
                .Where(b => b.Book.BookId == book.BookId)
                .FirstOrDefault();

            if (line == null)
            {
                Items.Add(new CartLineItem
                {
                    Book = book,
                    Quantity = quantity
                });
            }
            else
            {
                line.Quantity += quantity;
            }
        }

        public double CalculateTotalPrice()
        {
            double sum = Items.Sum(x => x.Price * x.Quantity);

            return sum;
        }

        public int CalculateTotalBooks()
        {
            int sum = Items.Sum(x => x.Quantity);

            return sum;
        }
    }

    public class CartLineItem
    {
        public int LineID { get; set; }
        public Book Book { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; } = 10.00;
    }
}
