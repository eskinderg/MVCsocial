using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Social.Models;
using WebMatrix.WebData;
using WebMatrix.Data;

namespace Social.Controllers
{
    [Authorize]
    public class DashboardController : Controller
    {
        
        private IUserProfileContext context = null;

        
        public DashboardController(IUserProfileContext dataContext)
        {
            this.context = dataContext;
        }

        public ActionResult Index()
        {
            IEnumerable<UserProfile> list = context.UserProfile;

            return View(list);
        }

        public JsonResult GetLastUser()
        {
            var json = context.UserProfile;
            return Json(json, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetLastUserOnly()
        {
            var json = context.UserProfile.Where(e=>e.UserId== WebSecurity.CurrentUserId);
            return Json(json, JsonRequestBehavior.AllowGet);
        }

	}
}