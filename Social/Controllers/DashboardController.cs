﻿using System;
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

namespace Social.Controllers
{
    [Authorize]
    public class DashboardController : Controller
    {
        
        //private IUserProfileContext context = null;

        private readonly IAuthenticationManager _authenticationManager;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IUserStore<ApplicationUser> _userStore;

        public DashboardController(IUserProfileContext dataContext, 
            IUserStore<ApplicationUser> userStore,
            IAuthenticationManager authenticationManager)
        {
            //this.context = dataContext;

            _userManager = new UserManager<ApplicationUser>(userStore);
            _authenticationManager = authenticationManager;
            _userStore = userStore;
        }

        public ActionResult Index()
        {
            //IEnumerable<UserProfile> list = context.UserProfile;

            IEnumerable<ApplicationUser> list = _userManager.Users;

            return View(list);
        }

        public JsonResult GetLastUser()
        {

            //List<AppUser> json = new List<AppUser>(); //context.UserProfile;

            //json.Add(new AppUser { UserName = "Jonny", LastName = "Begood" });
            var json = _userManager.Users.ToList();
            return Json(json, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetLastUserOnly()
        {
            //var json = context.UserProfile.Where(e=>e.Id== WebSecurity.CurrentUserId);
            //return Json(json, JsonRequestBehavior.AllowGet);
            return Json(null);
        }

	}
}