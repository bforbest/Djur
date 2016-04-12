using Djur.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Djur
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
        void Session_Start(object sender, EventArgs e)
        {
            Session["CountCart"] = 0;
            Session["LoginStatus"] = false;
            Session["Admin"] = false;
            Session["lista"] = new List<Product>() {
                new Product() { ProductID=1,Title = "English Shepherd", Amount = 4, ImageUrl="http://yupdaily.com/wp-content/uploads/2015/10/kfuh-kuvasz.jpg", Price = 7000, Category = "Dogs" },
                new Product() { ProductID=2,Title = "Kuvasz", Amount = 1,  ImageUrl="https://englishshepherd.files.wordpress.com/2010/03/picture-008-bess-5x7.jpg", Price = 300 },
                new Product() { ProductID=3,Title = "Siberian Husky", Amount = 3,  ImageUrl="http://www.dogtemperament.com/wp-content/uploads/2013/02/siberian-husky.jpg", Price = 300 },
                new Product() { ProductID=4,Title = "Teacup Pomeranian", Amount = 6, ImageUrl="https://s-media-cache-ak0.pinimg.com/736x/2b/8d/0f/2b8d0fe811c08dc3eb9f03b6668f6522.jpg", Price = 300 },
                new Product() { ProductID=5,Title = "American Bobtail", Amount = 7,  ImageUrl="http://cdn1-www.cattime.com/assets/uploads/2011/12/file_2738_american-bobtail-460x290.jpg", Price = 300 },
                new Product() { ProductID=6,Title = "Bengal", Amount = 8,  ImageUrl="http://www.bengalcatworld.com/home/wp-content/uploads/2012/02/bengal-cats-and-kittens-028.jpg", Price = 300, Category="Cats" },
                new Product() { ProductID=7,Title = "Chartreux", Amount = 9, ImageUrl="https://s-media-cache-ak0.pinimg.com/236x/7b/6d/8e/7b6d8e231551bc6b175ab38098047b2e.jpg", Price = 300, Category="Cats" },
                new Product() { ProductID=8,Title = "Norwegian Forest Cat", Amount = 10, ImageUrl="https://upload.wikimedia.org/wikipedia/commons/6/6e/Norskskogkatt_Evita_3.JPG", Price = 300, Category="Cats" },
                new Product() { ProductID=8,Title = "American Fuzzy Lop", Amount = 10,  ImageUrl="https://rabbitsforsaleinidaho.files.wordpress.com/2014/12/205.jpg?w=640", Price = 300, Category="Rabbits" },
                new Product() { ProductID=8,Title = "Angora", Amount = 10, ImageUrl="http://4.bp.blogspot.com/-QPk86FZ87iM/TpI0jWi-WlI/AAAAAAAABeU/T1L1-UmNHIc/s1600/DSC02485.JPG", Price = 300, Category="Rabbits" },
                new Product() { ProductID=8,Title = "Giant Papillon", Amount = 10, ImageUrl="http://vetbook.org/wiki/rabbit/images/4/42/Giant_Papillon.jpg", Price = 300, Category="Rabbits" },
                new Product() { ProductID=8,Title = "Czech Red", Amount = 10,  ImageUrl="https://s-media-cache-ak0.pinimg.com/736x/20/52/99/205299943204c6aa0826012f83b3c416.jpg", Price = 300, Category="Rabbits" }
            };
            Session["ShoppingCartList"] = new ShoppingCart() { };
        }
    }
}
