using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Djur.Models
{
    public class ShoppingCartItem
    {
        public int id { get; set; }
        public int Amount { get; set; }
        public Product product { get; set; }
    }
}