using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _2ndClassAmazon.Models
{
    public class Order
    {
        [Key]
        [BindNever]
        public int PurchaseId { get; set; }

        [BindNever]
        public ICollection<CartLineItem> Lines { get; set; }

        [Required(ErrorMessage = "Please enter a first name:")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter a last name:")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please enter a phone number:")]
        public int Phone { get; set; }

        [Required(ErrorMessage = "Please enter an email:")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter an address line:")]
        public string AddressLine { get; set; }

        [Required(ErrorMessage = "Please enter a city:")]
        public string City { get; set; }

        [Required(ErrorMessage = "Please enter a state:")]
        public string State { get; set; }

        [Required(ErrorMessage = "Please enter a zip code:")]
        public int Zip { get; set; }

    }
}
