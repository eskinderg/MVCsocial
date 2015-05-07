using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Social.Models;
using WebMatrix.WebData;

namespace Social.Controllers
{
    public class AccountController : Controller
    {

        [HttpPost]
        public ActionResult Login(Login model, string ReturnUrl)
        {
            if (ModelState.IsValid)
            {
                WebSecurity.Login(model.Username, model.Password,persistCookie:true);

                if (!string.IsNullOrEmpty(ReturnUrl))
                    return Redirect(ReturnUrl);
                else
                    return Redirect("~/Home/Index");
            }
            else
            {
                return View(model);
            }
        }


        [HttpGet]
        public ActionResult Login()
        {
            if(WebSecurity.IsAuthenticated)
            {
                return Redirect("~/Home/Index");
            }
            return View();
        }

        public ActionResult Logout()
        {
            WebSecurity.Logout();
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public ActionResult Register(Register model)
        {
            if(ModelState.IsValid)
            {
                WebSecurity.CreateUserAndAccount(model.Username, model.Password);
                WebSecurity.Login(model.Username, model.Password);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View(model);
            }
        }

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

	}
}