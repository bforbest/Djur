using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Djur.Models
{
    public class ShoppingCart
    {
        List<ShoppingCartItem> items=new List<ShoppingCartItem>();
        public void AddToCart(ShoppingCartItem shoppingCartItem)
        {
            ShoppingCartItem item=null;
            //Kolla om varan finns redan med på kundvagnen
            if (items != null)
            {
                 item = items.Where(x => x.id == shoppingCartItem.id).FirstOrDefault();
            }
            if (item==null)
                {
                    items.Add(shoppingCartItem);
                }
            
        }
        public List<ShoppingCartItem> GetCartItems()
        {
            return items;
        }
        public void RemoveFromCart(int id)
        {

        }
        public void EmptyCart()
        {

        }
        public decimal GetTotal()
        {
            decimal sum = 0;
            foreach(var item in items)
            {
                sum += item.Amount * item.product.Price;
            }
            return sum;
        }
    }
}