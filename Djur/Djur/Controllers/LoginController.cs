using Djur.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Djur.Controllers
{
    public class LoginController : Controller
    {
        // GET: Logini
        public ActionResult Index()
        {
            string username = Request["username"];
            string password = Request["password"];
            string logoutButton = Request["logoutButton"];
            if (username != null)
            {
                // försök att logga in
                List<UserModel> defaultUsers = UserModel.DefaultUsers();
                foreach (UserModel u in defaultUsers)
                {
                    if (username == u.Name)
                    {
                        if (password == u.Password)
                        {
                            Session["LoginStatus"] = true;
                            Session["username"] = username;
                        }
                        if (u.Admin)
                        {
                            Session["Admin"] = true;
                        }
                        else
                        {
                            Session["Admin"] = false;
                        }
                        break;
                    }
                }
            }
            else if (logoutButton != null)
            {
                // logga ut
                Session["LoginStatus"] = false;
                Session["username"] = null;
                Session["Admin"] = false;
            }
            else
            {
                // business as usual
            }
            return View();
        }
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(UserModel user)
        {
            List<UserModel> defaultUsers = UserModel.DefaultUsers();
            if (ModelState.IsValid)
            {
                var userob = new UserModel() { Name = user.Name, Password = user.Password, Admin = false };
                defaultUsers.Add(userob);
                return RedirectToAction("Index", "Login");
            }
            return View(user);
        }

    }
}