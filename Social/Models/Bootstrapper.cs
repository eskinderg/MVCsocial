using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Social.Controllers;
//using Microsoft.Practices.Unity.Mvc;
using Social.CYDE;
using Authentication;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;
using System.Web;
using Social.DictionaryService;
using System.Web.Http;


namespace Social.Models
{
    public class Bootstrapper
    {
        //{
        //    public Bootstrapper() { }
        //    public static IUnityContainer Initialise()
        //    {
        //        var container = BuildUnityContainer();

        //        DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        //        return container;
        //    }
        //    private static IUnityContainer BuildUnityContainer()
        //    {

        //        var container = new UnityContainer();

        //        container.RegisterType<IWeatherService, WeatherService>(new InjectionConstructor(23145));
        //        container.RegisterType<IHomeInjectable, HomeInjectable>();
        //        container.RegisterType<WeatherSoap,WeatherSoapClient>(new InjectionConstructor("WeatherSoap"));

        //        container.RegisterType<IUserProfileContext, UserProfileContext>(new HierarchicalLifetimeManager());// HierarchialLigetimeManager Auto dispose elements


        //        var accountInjectionConstructor = new InjectionConstructor(new ApplicationDbContext());


        //        container.RegisterType<IUserStore<ApplicationUser>, UserStore<ApplicationUser>>(accountInjectionConstructor);

        //        container.RegisterType<IAuthenticationManager>(new InjectionFactory(o => HttpContext.Current.GetOwinContext().Authentication));


        //        container.RegisterType<DictServiceSoap, DictServiceSoapClient>(new InjectionConstructor("DictServiceSoap"));


        //        //container.RegisterType<AppUserDbContext>();


        //        //Dependecy for the webApicontrollers
        //        GlobalConfiguration.Configuration.DependencyResolver = new Unity.WebApi.UnityDependencyResolver(container);

        //        return container;
        //    }
        //}
    }
}
            //container.RegisterType<IRoleStore<ApplicationRole>, RoleStore<ApplicationRole>>(new InjectionConstructor(typeof(ApplicationDbContext)));

            //container.RegisterType<IRoleStore<IdentityRole>, RoleStore<IdentityRole>>(accountInjectionConstructor);

            //container.RegisterType<IRoleStore<ApplicationRole>, RoleStore<ApplicationRole>>(accountInjectionConstructor);

            //container.RegisterType<IRoleStore<IdentityRole>, RoleStore<IdentityRole>>(accountInjectionConstructor);

