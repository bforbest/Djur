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
            items.Remove(items.Where(x => x.id == id).First());
        }
        public void EmptyCart()
        {
            items.Clear();
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
        public void UpdateCart(int id, int amount)
        {
            items.Where(x => x.id == id).First().Amount = amount;
        }
    }
}