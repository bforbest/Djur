using Djur.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Djur.Controllers
{
    public class SearchController : Controller
    {
        // GET: Search

        public ActionResult Index(string SearchString)
        {
            if (!String.IsNullOrEmpty(SearchString))
            {
                List<Product> products = (List<Product>)Session["lista"];
                var items = products.Where(x => x.Title.Contains(SearchString));
                return View(items);
            }
            else
            {
                return View();
            }
        }
    }
}