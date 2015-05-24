using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Social.Models;
using WebMatrix.WebData;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Authentication;
using Microsoft.Owin;
using Microsoft.Owin.Security;
using System.Web.Security;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Threading.Tasks;

namespace Social.Controllers
{
    public class AccountController : Controller
    {
        private ApplicationUserManager _userManager = null;

        public AccountController() { }

        public AccountController(ApplicationUserManager userManager)
        {

           UserManager = userManager;

        }


        [HttpPost]
        public async Task<ActionResult> Login(Login model, string ReturnUrl)
        {

            if (ModelState.IsValid)
            {
                var user = await UserManager.FindAsync(model.Username, model.Password);

                await SignInAsync(user, true);
                //WebSecurity.Login(model.Username, model.Password, persistCookie: true);
                
                //signIn(_userManager, model);

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


        public ApplicationUserManager UserManager
        {
            get
            {
                return _userManager ?? HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
            private set
            {
                _userManager = value;
            }
        }

        private IAuthenticationManager AuthenticationManager
        {
            get
            {
                return HttpContext.GetOwinContext().Authentication;
            }
        }

        private async Task SignInAsync(ApplicationUser user, bool isPersistent)
        {
            AuthenticationManager.SignOut(DefaultAuthenticationTypes.ExternalCookie);
            AuthenticationManager.SignIn(new AuthenticationProperties() { IsPersistent = isPersistent }, await user.GenerateUserIdentityAsync(UserManager));
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
            AuthenticationManager.SignOut();
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public async Task<ActionResult> Register(Register model)
        {
             
            if(ModelState.IsValid && !User.Identity.IsAuthenticated)
            {
                ApplicationUser newUser = new ApplicationUser
                {
                    UserName = model.Username,
                    Email=model.EMail
                };

                //newUser.Roles.Add();
                

               IdentityResult result = await UserManager.CreateAsync(newUser, model.Password);
                if(result.Succeeded)
                {
                    await this.SignInAsync(newUser,true);

                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    return View(model);
                }
                               
                
            }
            else
            {
                return View(model);
            }
        }

        [HttpGet]
        public ActionResult Register()
        {
            if (!User.Identity.IsAuthenticated)
                return View();
            else
                return RedirectToAction("Index", "Home");
        }


        [ChildActionOnly]
        private void signOut()
        {
            

        }
    }

    
}