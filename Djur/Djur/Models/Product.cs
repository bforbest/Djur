using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Djur.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        [Required()]
        [StringLength(100, MinimumLength = 2)]
        public string Title { get; set; }
        public int Price { get; set; }
        public int Amount { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
    }
}