using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand_Project
{
    class Weather
    {

        string weatherSet;

        public void setWeather(string weatherSet)
        {
            this.weatherSet = weatherSet;
        }

        List<string> weather = new List<string>() { "sunny", "partly cloudy", "partly cloudy with rain", "cloudy", "cloudy with rain", "rainy" };

        public void SetWeather()
        {
            this.weatherSet = "weather";
        }

        public string RandomWeatherSet()
        {
            Random t = new Random();
            t.Next(0, weather.Count);
            string choice = weather[t.Next(0, weather.Count)];
        }

        public void setTemperature()
        {
            Random tempset = new Random();
            tempset.Next(65, 110).ToString();
        }

        public string weatherReport()
        {
            Console.WriteLine("The weather report today is {0} at about {1} degrees Fahrenheit.", RandomWeatherSet(), setTemperature());
        }

    }

}
