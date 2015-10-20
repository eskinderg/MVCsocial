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
using System.Diagnostics.Contracts;

namespace Social.Controllers
{
    [Authorize]
    public class DashboardController : Controller
    {
        
        public ActionResult Index()
        {


            return View();
        }


	}

}