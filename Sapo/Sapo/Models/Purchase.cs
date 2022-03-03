﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Sapo.Models
{
    public class Purchase
    {
        [Key]
        [BindNever]
        public int PurchaseID { get; set; }
        [BindNever]
        public ICollection<BasketLineItem> Lines { get; set; }

        [Required(ErrorMessage = "Please enter a name ")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter an address ")]
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }

        [Required(ErrorMessage = "Please enter a city ")]
        public string City { get; set; }

        [Required(ErrorMessage = "Please enter a State ")]
        public string State { get; set; }

        [Required(ErrorMessage = "Please enter a zip ")]
        public string Zip { get; set; }

        [Required(ErrorMessage = "Please enter a country ")]
        public string Country { get; set; }


    }
}

