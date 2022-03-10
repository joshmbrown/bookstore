using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Bookstore.Models
{
    public class EFCheckoutRepository : ICheckoutRepository
    {
        private BookstoreContext _context;
        public EFCheckoutRepository(BookstoreContext context)
        {
            _context = context;
        }

        public IQueryable<Checkout> Checkouts => _context.Checkouts.Include(x => x.LineItems).ThenInclude(x => x.Book);

        public void SaveCheckout(Checkout checkout)
        {
            _context.AttachRange(checkout.LineItems.Select(x => x.Book));

            if (checkout.CheckoutID == 0)
            {
                _context.Checkouts.Add(checkout);
            }

            _context.SaveChanges();
        }
    }
}
