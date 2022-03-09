using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace OnlineBookstore.Models
{
    //each purchase will be recorded in the database with the following properties
    public class Purchase
    {
        [Key]
        [BindNever]
        public int PurchaseId { get; set; }

        [BindNever]
        public ICollection<CartLineItem> Lines {get; set;}

        [Required(ErrorMessage ="Please enter a name.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter an address.")]
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }

        [Required(ErrorMessage = "Please enter a city.")]
        public string City { get; set; }


        [Required(ErrorMessage = "Please enter a state.")]
        public string State { get; set; }


        public string Zipcode { get; set; }


        [Required(ErrorMessage = "Please enter a country.")]
        public string Country { get; set; }

        //[BindNever]
        public bool OrderShipped { get; set; }


    }
}
