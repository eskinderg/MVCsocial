using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Social.Models;
using WebMatrix.WebData;
using System.Data.Entity;
using Microsoft.Owin.Security;
using Authentication;
using Microsoft.AspNet.Identity;
using System.Threading.Tasks;

namespace Social.Controllers
{
    public class ProfileController : Controller
    {

        private ApplicationUserManager _userManager = null;

        public ProfileController() { }

        public ProfileController(ApplicationUserManager userManager)
        {
            this._userManager = userManager;

        }
        
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Authorize]
        public async Task<ActionResult> UserProfile()
        {
            //UserProfile profile = context.UserProfile.Where(p => p.UserId == WebSecurity.CurrentUserId).SingleOrDefault();
            //string id = _userManager.FindByName(User.Identity.Name).;
            ApplicationUser user = await _userManager.FindByNameAsync (User.Identity.Name);
            //Response.Write(user.LastName);
            return View(user);
            //return View(profile);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult UserProfile(ApplicationUser model )
        {
            if (ModelState.IsValid)
            {
                //ApplicationUser profileToUpdate = _userManager.FindByName(User.Identity.Name); //context.UserProfile.Where(p => p.UserId == WebSecurity.CurrentUserId).SingleOrDefault();

                ////UpdateModel(profileToUpdate);
                //_userManager.Update(profileToUpdate);
                
                ////context.SaveChanges();
                return View(model);
            }
            else
            {
                
                return View(model);
            }
        }

        [Authorize]
        [HttpPost]
        public JsonResult Update(ApplicationUser user)
        {
            if (ModelState.IsValid)
            {
                ApplicationUser profileToUpdate = _userManager.FindByName(user.UserName);
                
                profileToUpdate.FirstName = user.FirstName;
                profileToUpdate.LastName = user.LastName;
                profileToUpdate.Email = user.Email;
                profileToUpdate.Address = user.Address;

                _userManager.Update(profileToUpdate);
                //UpdateModel(profileToUpdate);
                
                //context.SaveChanges();
                return Json(profileToUpdate);
            }
            else
            {

                return Json(user);
            }
        }


        public async Task<JsonResult> GetProfile()
        {
            var json = await _userManager.FindByNameAsync(User.Identity.Name);

            return Json(json, JsonRequestBehavior.AllowGet);
        }


	}
}