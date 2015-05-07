using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Social.Controllers;
using Microsoft.Practices.Unity.Mvc;
using Social.CYDE;

namespace Social.Models
{
    public class Bootstrapper
    {
        public static IUnityContainer Initialise()
        {
            var container = BuildUnityContainer();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
            return container;
        }
        private static IUnityContainer BuildUnityContainer()
        {

            var container = new UnityContainer();

            container.RegisterType<IWeatherService, WeatherService>(new InjectionConstructor(23145));
            container.RegisterType<IHomeInjectable, HomeInjectable>();
            container.RegisterType<WeatherSoap,WeatherSoapClient>(new InjectionConstructor("WeatherSoap"));
            container.RegisterType<IUserProfileContext, UserProfileContext>();

            return container;
        }
    }
}
