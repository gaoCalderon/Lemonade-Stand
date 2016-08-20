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
            return this.forecast;
        }

        public int forecastEqualRandomCall() 
{ 
            forecast = setRandomForecast();
            return this.forecast;
        }

        public int setRandomForecast()
        {
            Random f = new Random();
            int setRanForecast = f.Next(1, 5);
            return setRanForecast;
        }

        public void realDayForecast()
        {
            int results = setRandomForecast();
            if (results == 1)
            {
                Console.WriteLine("Weather Forecast: Bright & Sunny");
            }
            else if (results == 2)
            {
                Console.WriteLine("Weather Forcast: Part Cloudy & Sunny");
            }
            else if (results == 3)
            {
                Console.WriteLine("Weather Forcast: Strong Overcast");
            }
            else if (results == 4)
            {
                Console.WriteLine("Weather Forcast: Light Rains");
            }
            else if (results == 5)
            {
                Console.WriteLine("Weather Forcast: Rainy Day");
            }
            else
            {
                realDayForecast();
            }
        }

        public int setRandomTemperature()
        {
            Random tempset = new Random();
            int setTemp = tempset.Next(63, 102);
            return setTemp;
        }

        public int GetDayTemperature()
        {
            return temperature;
        }

        public int temperatureEqualRandomCall()
        { 
            temperature = setRandomTemperature();
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
