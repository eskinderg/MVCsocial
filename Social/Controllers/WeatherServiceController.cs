using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Social.Controllers
{
    public class WeatherServiceController : Controller
    {

        
        
        public readonly IWeatherService weatherService = null;


        public WeatherServiceController(): base() { }


        public WeatherServiceController(IWeatherService tempWeatherService)
        {
            this.weatherService = tempWeatherService;
        }



        public ActionResult Index()
        {
            string content = weatherService.getWeather();
            ViewBag.Weather = content;
            return View();
        }
	}
}