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
using Authentication.Users;
using Authentication.UnitOfWork;

namespace Social.Controllers
{
    [Authorize]
    public class DashboardController : Controller
    {

        //private ApplicationUserManager _userManager = null;
        //private readonly IUnitOfWorkManager _unitOfWorkManager = null;
        //private readonly IUserRepository _userRepo = null;

        //public DashboardController(ApplicationUserManager userManager)
        //{

        //    this._userManager = userManager;
        //    //this._unitOfWorkManager = unitOfWorkManager;
        //    //this._userRepo = userRepo;
            
        //}

        public ActionResult Index()
        {

            return View();
        }
// Separate Database Connection Needed ----------------------------------------------------------------
//-----------------------------------------------------------------------------------------------------
//---------------------------------------------------------------------------------------------------------
        //[Authorize (Roles="AdminEsk")]
        //public JsonResult GetUserList()
        //{


        //    var json = _userManager.Users.ToList(); //Cause Async Error

        //    //var json = _userRepo.GetAll();

        //    //_userManager.GetRolesAsync()
        //    return Json(json, JsonRequestBehavior.AllowGet);
        //}
//---------------------------------------------------------------------------------------------------------
//---------------------------------------------------------------------------------------------------------
//---------------------------------------------------------------------------------------------------------

        //public JsonResult GetLastUserOnly()
        //{
        //    //var json = context.UserProfile.Where(e=>e.Id== WebSecurity.CurrentUserId);
        //    //return Json(json, JsonRequestBehavior.AllowGet);
        //    return Json(null);
        //}

	}
}