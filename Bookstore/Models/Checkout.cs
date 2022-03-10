using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Bookstore.Models
{
    public class Checkout
    {
        [Key]
        [BindNever]
        public int CheckoutID { get; set; }

        [BindNever]
        public ICollection<CartLineItem> LineItems { get; set; }

        [Required (ErrorMessage = "Please enter your Username: ")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Please enter your First Name: ")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter your Last Name: ")]
        public string LastName { get; set; }

        [Required (ErrorMessage = "Please enter your Address: ")]
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }

        [Required(ErrorMessage = "Please enter your City: ")]
        public string City { get; set; }

        [Required(ErrorMessage = "Please enter your State: ")]
        public string State { get; set; }

        [Required(ErrorMessage = "Please enter your Zip: ")]
        public string Zip { get; set; }

        [Required(ErrorMessage = "Please enter your Country: ")]
        public string Country { get; set; }

        [BindNever]
        public bool IsShipped { get; set; }
    }
}
