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
            Session["LoginStatus"] = false;
            Session["Admin"] = false;
            Session["lista"] = new List<Product>() {
                new Product() {ProductID=1,  Title = "English Shepherd", Amount = 1, Description="A very nice dog", ImageUrl="http://placehold.it/350x150?text=English+Shepherd", Price = 7000 },
                new Product() { ProductID=2,Title = "Kuvasz", Amount = 1, Description="A very nice dog", ImageUrl="http://placehold.it/350x150?text=a+nice+dog", Price = 300 },
                new Product() { ProductID=3,Title = "Siberian Husky", Amount = 1, Description="A very nice dog", ImageUrl="http://placehold.it/350x150?text=a+nice+dog", Price = 300 },
                new Product() { ProductID=4,Title = "Teacup Pomeranian", Amount = 1, Description="A very nice dog", ImageUrl="http://placehold.it/350x150?text=a+nice+dog", Price = 300 },
                new Product() { ProductID=5,Title = "American Bobtail", Amount = 1, Description="A very nice dog", ImageUrl="http://placehold.it/350x150?text=a+nice+dog", Price = 300 }
            };
        }
    }
}
