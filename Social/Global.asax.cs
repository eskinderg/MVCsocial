using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using WebMatrix.WebData;
using System.Data.Entity;
using Social.Models;
using Authentication;
   

namespace Social
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            Database.SetInitializer<Social.Models.UserProfileContext>(null);
            //Database.SetInitializer<Social.Models.UserFriendsContext>(null);

            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);


            Bootstrapper.Initialise();


            //WebSecurity.InitializeDatabaseConnection("DBConn", "User", "UserId", "Username", true);

            Database.SetInitializer<ApplicationDbContext>(null);
        }
    }
}
