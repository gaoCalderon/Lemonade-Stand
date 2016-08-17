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
        public int temperature;
        public string forecast;

        public Weather(int temperature, string forecast, string weatherSet)
        {
            this.temperature = temperature;
            this.forecast = forecast;
            this.weatherSet = weatherSet;
        }

        public string getWeather()
        {
            this.weatherSet = (); //come back to this
            return this.weatherSet;
        }

        public string RandomWeatherSet()
        {
            Random t = new Random();
            t.Next(0, weathers.Count);
            string choice = weathers[t.Next(0, weathers.Count)];
            return choice;
        }

        public int setWarmTemperature()
        {
            Random tempset = new Random();
            int setTemp = tempset.Next(65, 107);
            return setTemp;
        }

        public void weatherReport()
        {
            Console.WriteLine("The weather report {0} at about {1} degrees Fahrenheit.", getWeather(), ());
        }

        public string weatherRecord()
        {
            return weatherReport();
        }

    }

}
