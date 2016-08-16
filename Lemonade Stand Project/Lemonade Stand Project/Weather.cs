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

        Weather weather = new Weather("sunny", "partly cloudy", "partly cloudy with rain", "cloudy", "cloudy with rain", "rainy");

        List<string> weathers = new List<string>();

        weathers.Add(sunny);
        weathers.Add(partly cloudy);
        weathers.Add(partyly cloudy with rain);
        weathers.Add(cloudy);
        weathers.Add(cloudy with rain);
        weathers.Add(rainy);
        
       

        public void SetWeather()
        {
            this.weatherSet = RandomWeatherSet();
        }

        public string RandomWeatherSet()
        {
            Random t = new Random();
            t.Next(0, weathers.Count);
            string choice = weathers[t.Next(0, weathers.Count)];
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

        public string weatherRecord()
        {
            return weatherReport();
        }

    }

}
