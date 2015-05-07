using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Social.Controllers
{
    public interface IWeatherService
    {
        string getWeather(int ZipCode);
        string getWeather();
    }

    public class WeatherService : IWeatherService
    {
        private int zip;
    
        public WeatherService() { }


        //[Microsoft.Practices.Unity.InjectionConstructor]
        public WeatherService(int  zipData)
        {
            this.zip = zipData;
        }
        
        public string getWeather(int ZipCode)
        {
            return "The Temprature in " + ZipCode + " is 90 Farhenite";
        }

        public  string getWeather()
        {
            return "The Temprature in " + zip + " is 90 Farhenite";
        }
    }

}
