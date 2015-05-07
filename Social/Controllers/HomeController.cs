using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Social.Models;

namespace Social.Controllers
{
    public class HomeController : Controller
    {
        IUserProfileContext context = null;

        string inJectedText = string.Empty;
        
        public HomeController(IHomeInjectable injectable,IUserProfileContext dataContext) 
        {
            this.inJectedText = injectable.GetName();
            this.context = dataContext;
        }

        public ActionResult Index()
        {
            IEnumerable<UserProfile> users = context.UserProfile;
            
            return View(users);
        }

        public ActionResult About()
        {
            Response.Write(inJectedText);
            ViewBag.Message = "Your application description page.";

            return View();
        }


        [Authorize]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Wizard()
        {
            return View();
        }
    }
}