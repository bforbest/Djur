using Djur.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Djur.Controllers
{
    public class AdminController : Controller
    {
         
        // GET: Admin
        public ActionResult Index()
        {
            if (Session["Admin"]==null)
            {
                return Redirect("login");
            }
            if ((bool)Session["Admin"])
            {
                List<Product> products = (List<Product>)Session["lista"];
                return View(products);
            }
            else
            {
                return Redirect("/");  //   /Login/Index
            }
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Title,Price,Amount,ImageUrl,Description")] Product product)
        {
            var products = (List<Product>)Session["lista"];
            if (ModelState.IsValid)
            {
                product.ProductID = products.Count()+1;
                products.Add(product);
                return RedirectToAction("Index");
            }
            return View(product);
        }
        public ActionResult Edit(int? id)
        {
            var products = (List<Product>)Session["lista"];
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Product product = products.Where(i=>i.ProductID == id).First();
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Product product)
        {
            var products = (List<Product>)Session["lista"];
            if (ModelState.IsValid)
            {
                var i = products.FindIndex(x=>x.ProductID == product.ProductID);
                products[i] = product;
                return RedirectToAction("Index");
            }
            return View(product);
        }


        public ActionResult Delete(int? id)
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

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var products = (List<Product>)Session["lista"];
            Product product = products.Where(i => i.ProductID == id).First();
            products.Remove(product);
            return RedirectToAction("Index");
        }

    }
}