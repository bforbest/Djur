using Djur.Models;
using Djur.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Djur.Controllers
{
    public class ShoppingCartController : Controller
    {
        // GET: ShoppingCart
        public ActionResult Index()
        {
            ShoppingCartView cartView = new ShoppingCartView();
            var products = (ShoppingCart) Session["ShoppingCartList"];
            cartView.ShoppingCartItems = products.GetCartItems();
            decimal totalPrice = products.GetTotal();
            cartView.CartTotal = totalPrice;
            return View(cartView);
        }
        public ActionResult Addtocart(int id, int amount)
        {
            var shoppingCart = (ShoppingCart)Session["ShoppingCartList"];
            var products = (List<Product>)Session["lista"];
            var item = products.Where(x => x.ProductID == id).First();
            var tempItem = shoppingCart.GetCartItems().Find(x => x.id == id);
            if (tempItem==null)
            {
                ShoppingCartItem cartItem = new ShoppingCartItem() { Amount = amount, id = id, product = item };
                shoppingCart.AddToCart(cartItem);
            }
            else
            {
                tempItem.Amount+=amount;
            }
            
            
            return RedirectToAction("Index");
        }

        public ActionResult RemoveToCart(int id, int amount)
        {
            var shoppingCart = (ShoppingCart)Session["ShoppingCartList"];
            var products = (List<Product>)Session["lista"];
            var item = products.Where(x => x.ProductID == id).First();
            var tempItem = shoppingCart.GetCartItems().Find(x => x.id == id);
            if (tempItem == null)
            {
                ShoppingCartItem cartItem = new ShoppingCartItem() { Amount = amount, id = id, product = item };
                shoppingCart.RemoveFromCart(cartItem);
            }
            else
            {
                tempItem.Amount -= amount;
            }


            return RedirectToAction("Index");
        }

    }

}