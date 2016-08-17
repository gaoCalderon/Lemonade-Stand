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
        public int forecast;

        public Weather(int temperature, int forecast)
        {
            this.temperature = temperature;
            this.forecast = forecast;
        }

        //List<string> typeOfForecast = new List<string>() { "Sunny", "Partly Cloudy", "Partly Cloudy with Rain", "Cloudy", "Cloudy with Rain", "Rainy" };

        public int getForecast()
        {
            this.forecast = setRandomForecast();
            return this.forecast;
        }

        public int setRandomForecast()
        {
            Random f = new Random();
            //f.Next(0, typeOfForecast.Count);
            //string choice = typeOfForecast[f.Next(0, typeOfForecast.Count)];
            //return choice;
            int setRanForecast = f.Next(1, 6);
            return setRanForecast;
        }

        public void realDayForecast()
        {
            int results = setRandomForecast();
            if (results == 1)
            {
                Console.WriteLine("Weather Forecast: Sunny");
            }
            else if (results == 2)
            {
                Console.WriteLine("Weather Forcast: Partly Cloudy");
            }
            else if (results == 3)
            {
                Console.WriteLine("Weather Forcast: Partly Overcast with Light Rain");
            }
            else if (results == 4)
            {
                Console.WriteLine("Weather Forcast: All Day Overcast");
            }
            else if (results == 5)
            {
                Console.WriteLine("Weather Forcast: Rainy");
            }
            else if (results == 6)
            {
                Console.WriteLine("Weather Forecast: Heavy Rains");
            }
            else
            {
                realDayForecast();
            }
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
            return this.temperature;
        }

        public void temperatureCall()
        {
            Console.WriteLine("Temperature in the hight: {0}F", GetDayTemperature());
        }

        public void realDayTemperature()
        {
            int results = setRandomTemperature();
            if (results <= 72)
            {
                temperatureCall();
            }
            else if (results <= 79)
            {
                temperatureCall();
            }
            else if (results <= 86)
            {
                temperatureCall();
            }
            else if (results <= 93)
            {
                temperatureCall();
            }
            else if (results <= 100)
            {
                temperatureCall();
            }
            else if (results <= 107)
            {
                temperatureCall();
            }
            else
            {
                realDayTemperature();
            }
        }


       public void weatherForecast()
        {
           Console.WriteLine("Weather Forcast:");
           Console.WriteLine("Predicts: {0}", setRandomForecast());
           Console.WriteLine("in the highs of {0} degrees Fahrenheit", setRandomTemperature());
        }

        //public void weatherReport()
        //{
            //Console.WriteLine("Weather report {0} at about {1} degrees Fahrenheit.", getForecast(), GetDayTemperature());
        //}

    }

}
