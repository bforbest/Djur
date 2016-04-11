using Djur.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Djur.Controllers
{
    public class DjurController : Controller
    {
        // GET: Djur
        public ActionResult Index()
        {
            var products = (List<Product>)Session["lista"];  
            return View(products);
        }
        public ActionResult Details(int? id)
        {
            var products = (List<Product>)Session["lista"];
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = products.Where(i => i.ProductID == id).First();
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

    }
}