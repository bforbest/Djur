using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcLoginDemo.Controllers
{
    public class SecureController : Controller
    {
        // GET: Secure
        public ActionResult Index()
        {
            if ((bool)Session["LoginStatus"])
            {
                return View();
            }
            else
            {
                return Redirect("/");  //   /Login/Index
            }
        }
    }
}