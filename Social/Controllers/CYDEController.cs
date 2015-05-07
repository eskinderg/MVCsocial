using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Social.CYDE;

namespace Social.Controllers
{
    public class CYDEController : Controller
    {
        WeatherSoap weather = null;

       public CYDEController(WeatherSoap injected)
        {
            this.weather = injected;
        }
        
        
        public ActionResult Index()
        {

            ViewData["WeatherStation"] = weather.GetCityForecastByZIP("22151").WeatherStationCity;
            ViewData["State"] = weather.GetCityForecastByZIP("22151").State;
            ViewData["DayTimeHigh"]+= weather.GetCityForecastByZIP("22151").ForecastResult[0].Temperatures.DaytimeHigh;
            ViewData["MorningLow"] += weather.GetCityForecastByZIP("22151").ForecastResult[0].Temperatures.MorningLow;


            return View();
        }
	}
}