using Djur.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Djur.ViewModels
{
    public class ShoppingCartView
    {
        public List<ShoppingCartItem> ShoppingCartItems {get; set;}
        public decimal CartTotal { get; set; }
    }
}