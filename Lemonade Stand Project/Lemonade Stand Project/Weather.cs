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
        int temperature;

        public void setWeather(string weatherSet)
        {
            this.weatherSet = weatherSet;
            this.temperature = 0;
        }

        Weather weather = new Weather("sunny", "partly cloudy", "partly cloudy with rain", "cloudy", "cloudy with rain", "rainy");
        List<string> weathers = new List<string>();
        weathers.Add(sunny);
        weathers.Add(partly cloudy);
        weathers.Add(partyly cloudy with rain);
        weathers.Add(cloudy);
        weathers.Add(cloudy with rain);
        weathers.Add(rainy);

        public string getWeather()
        {
            this.weatherSet = RandomWeatherSet();
        }

        public string RandomWeatherSet()
        {
            Random t = new Random();
            t.Next(0, weathers.Count);
            string choice = weathers[t.Next(0, weathers.Count)];
        }

        public string getTemperature()
        {
            this.temperature = setWarmTemperature();
        }

        public string setWarmTemperature()
        {
            Random tempset = new Random();
            tempset.Next(65, 107).ToString();
        }

        public string weatherReport()
        {
            Console.WriteLine("The weather report today is {0} at about {1} degrees Fahrenheit.", getWeather(), getTemperature());
        }

        public string weatherRecord()
        {
            return weatherReport();
        }

    }

}
