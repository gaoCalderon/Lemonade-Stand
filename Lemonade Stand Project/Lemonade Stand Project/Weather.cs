using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand_Project
{
    class Weather
    {
        public int temperature;
        public string forecast;

        public Weather(int temperature, string forecast)
        {
            this.temperature = temperature;
            this.forecast = forecast;
        }

        List<string> typeOfForecast = new List<string>() { "Sunny", "Partly Cloudy", "Partly Cloudy with Rain", "Cloudy", "Cloudy with Rain", "Rainy" };

        public string getForecast()
        {
            this.forecast = randomForecast();
            return this.forecast;
        }

        public string randomForecast()
        {
            Random f = new Random();
            f.Next(0, typeOfForecast.Count);
            string choice = typeOfForecast[f.Next(0, typeOfForecast.Count)];
            return choice;
        }

        public int setRandomTemperature()
        {
            Random tempset = new Random();
            int setTemp = tempset.Next(65, 107);
            return setTemp;
        }

        public int GetDayTemperature()
        {
            this.temperature = setRandomTemperature();
            return temperature;
        }

        public void weatherReport()
        {
            Console.WriteLine("Weather report {0} at about {1} degrees Fahrenheit.", getForecast(), GetDayTemperature());
        }

    }

}
