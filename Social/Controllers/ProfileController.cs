using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Social.Models;
using WebMatrix.WebData;
using System.Data.Entity;

namespace Social.Controllers
{
    public class ProfileController : Controller
    {
        IUserProfileContext context = null;

        public ProfileController(IUserProfileContext dataContext)
        {
            this.context = dataContext;
        }
        
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Authorize]
        public ActionResult UserProfile()
        {
            UserProfile profile = context.UserProfile.Where(p => p.UserId == WebSecurity.CurrentUserId).SingleOrDefault();

            return View(profile);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult UserProfile(UserProfile model )
        {
            if (ModelState.IsValid)
            {
                UserProfile profileToUpdate = context.UserProfile.Where(p => p.UserId == WebSecurity.CurrentUserId).SingleOrDefault();

                UpdateModel(profileToUpdate);
                context.SaveChanges();
                return View(model);
            }
            else
            {
                
                return View(model);
            }
        }

        [HttpPost]
        public JsonResult Update(UserProfile user)
        {
            if (ModelState.IsValid)
            {
                UserProfile profileToUpdate = context.UserProfile.Where(p => p.UserId == WebSecurity.CurrentUserId).SingleOrDefault();

                UpdateModel(profileToUpdate);
                context.SaveChanges();
                return Json(user);
            }
            else
            {

                return Json(user);
            }
        }

	}
}