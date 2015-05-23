using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Social.Models;
using WebMatrix.WebData;
using Microsoft.AspNet.Identity;
using Authentication;
using Microsoft.Owin;
using Microsoft.Owin.Security;
using System.Web.Security;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Social.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IAuthenticationManager _authenticationManager;
        

        public AccountController(IUserStore<ApplicationUser> userStore,IAuthenticationManager authenticationManager)
        {
           _userManager = new UserManager<ApplicationUser>(userStore);
           _authenticationManager = authenticationManager;


        }


        [HttpPost]
        public ActionResult Login(Login model, string ReturnUrl)
        {

            if (ModelState.IsValid)
            {

                //WebSecurity.Login(model.Username, model.Password, persistCookie: true);
                
                signIn(_authenticationManager, _userManager, model);

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
            this.signOut();
            //WebSecurity.Logout();
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public ActionResult Register(Register model)
        {
             
            if(ModelState.IsValid && !User.Identity.IsAuthenticated)
            {
                ApplicationUser newUser = new ApplicationUser
                {
                    UserName = model.Username,
                    Email=model.EMail
                };

                //newUser.Roles.Add();
                

               var returnVal = _userManager.Create(newUser, model.Password);

               


                signIn(_authenticationManager, _userManager, new Login { Username=model.Username,Password=model.Password});
                //WebSecurity.CreateUserAndAccount(model.Username, model.Password);
                //WebSecurity.Login(model.Username, model.Password);
                
                

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
            if (!User.Identity.IsAuthenticated)
                return View();
            else
                return RedirectToAction("Index", "Home");
        }

        [ChildActionOnly]
	    private  void signIn(IAuthenticationManager authenticationmanager,
            UserManager<ApplicationUser> userManager,Login loginModel)
        {
            
            ApplicationUser user =  userManager.Find(loginModel.Username, loginModel.Password);

            
            //RoleManager<IdentityRole> rm = new
            //    RoleManager<IdentityRole>(new RoleStore<IdentityRole>(new ApplicationDbContext()));

            //rm.Create(new IdentityRole("AdminEsk"));

            //_userManager.AddToRole(user.Id, rm.FindByName("AdminEsk").Name);
            

            if (user != null)
            {
                var identity =  userManager.CreateIdentity(user, DefaultAuthenticationTypes.ApplicationCookie);
                    
                authenticationmanager.SignIn(new AuthenticationProperties() { IsPersistent = true,ExpiresUtc=DateTime.Now.AddDays(20) }, identity);
                FormsAuthentication.SetAuthCookie(identity.Name, true);
            }
            //Response.Write(User.Identity.IsAuthenticated.ToString() + " " + user.Id.ToString());
        }


        [ChildActionOnly]
        private void signOut()
        {
            _authenticationManager.SignOut(DefaultAuthenticationTypes.ApplicationCookie, DefaultAuthenticationTypes.ExternalCookie);
            FormsAuthentication.SignOut();
        }
    }

    
}