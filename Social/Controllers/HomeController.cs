using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Social.Models;
using Authentication;
using System.Threading.Tasks;

namespace Social.Controllers
{
    public class HomeController : Controller
    {
        ApplicationUserManager _userManager = null;

        

        public HomeController() { }

        public HomeController(ApplicationUserManager userManager) 
        {
            //this.inJectedText = injectable.GetName();
            //this.context = dataContext;
            this._userManager = userManager;
        }

        public  ActionResult Index()
        {
            //IEnumerable<AppUser> users =  context.UserProfile;
            
            
            return View();
        }

        public ActionResult About()
        {
            //Response.Write(inJectedText);
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