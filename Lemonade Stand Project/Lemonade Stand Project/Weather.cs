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

        public Weather()
        {
            this.temperature = 0;
            this.forecast = 0;
        }

        public int getForecast()
        {
            this.forecast = setRandomForecast();
            return this.forecast;
        }

        public int setRandomForecast()
        {
            Random f = new Random();
            int setRanForecast = f.Next(1, 10);
            return setRanForecast;
        }

        public void realDayForecast()
        {
            int results = setRandomForecast();
            if (results == 1)
            {
                Console.WriteLine("Weather Forecast: Clear & Sunny");
            }
            else if (results == 2)
            {
                Console.WriteLine("Weather Forcast: Bright & Sunny");
            }
            else if (results == 3)
            {
                Console.WriteLine("Weather Forcast: Sunny");
            }
            else if (results == 4)
            {
                Console.WriteLine("Weather Forcast: Partly Cloudy");
            }
            else if (results == 5)
            {
                Console.WriteLine("Weather Forcast: Light Overcast");
            }
            else if (results == 6)
            {
                Console.WriteLine("Weather Forecast: All Day Overcast");
            }
            else if (results == 7)
            {
                Console.WriteLine("Weather Forecast: Sun & Light Rains");
            }
            else if (results == 8)
            {
                Console.WriteLine("Weather Forecast: Sunny w/ high Winds");
            }
            else if (results == 9)
            {
                Console.WriteLine("Weather Forecast: Rainy");
            }
            else if (results == 10)
            {
                Console.WriteLine("Weather Forecast: Heavy Rainstorms");
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

        public void realDayTemperature()
        {
            setRandomForecast();
            Console.WriteLine("Temperature in the hight: {0}F", GetDayTemperature());
        }

       public void weatherForecast()
        {
           Console.WriteLine("Weather Forcast:");
           Console.WriteLine("Predicts: {0}", setRandomForecast());
           Console.WriteLine("in the highs of {0} degrees Fahrenheit", setRandomTemperature());
        }

        public void getWeatherForecast()
        {
            Console.WriteLine("Weather Forcast:");
            Console.WriteLine("Predicts: {0}", getForecast());
            Console.WriteLine("in the highs of {0} degrees Fahrenheit", GetDayTemperature());
        }

    }

}
