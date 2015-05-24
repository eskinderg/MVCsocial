using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Social.Models;
using WebMatrix.WebData;
using WebMatrix.Data;
using Microsoft.AspNet.Identity;
using Authentication;
using Microsoft.Owin.Security;
using System.Threading.Tasks;

namespace Social.Controllers
{
    [Authorize]
    public class DashboardController : Controller
    {

        private ApplicationUserManager _userManager = null;

        public DashboardController(ApplicationUserManager userManager)
        {

            this._userManager = userManager;
        }

        public ActionResult Index()
        {

            return View();
        }
// Separate Database Connection Needed ----------------------------------------------------------------
//-----------------------------------------------------------------------------------------------------
//---------------------------------------------------------------------------------------------------------
        //[Authorize (Roles="AdminEsk")]
        public JsonResult GetUserList()
        {

            //List<AppUser> json = new List<AppUser>(); //context.UserProfile;

            //json.Add(new AppUser { UserName = "Jonny", LastName = "Begood" });
            
            var json = _userManager.Users.ToList(); //Cause Async Error
            //_userManager.GetRolesAsync()
            return Json(json, JsonRequestBehavior.AllowGet);
        }
//---------------------------------------------------------------------------------------------------------
//---------------------------------------------------------------------------------------------------------
//---------------------------------------------------------------------------------------------------------

        public JsonResult GetLastUserOnly()
        {
            //var json = context.UserProfile.Where(e=>e.Id== WebSecurity.CurrentUserId);
            //return Json(json, JsonRequestBehavior.AllowGet);
            return Json(null);
        }

	}
}