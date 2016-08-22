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

        public int getForecastNumber()
        {
            return forecast;
        }

        public int ConsumerRandomChoice()
        {
            Random f = new Random();
            forecast = f.Next(1, 5);
            return forecast;
        }

        public void setForecast()
        {
            Random f = new Random();
            forecast = f.Next(1, 5);
            switch (forecast)
            {
                case 1:
                    Console.WriteLine("Forecast: Bright & Sunny");
                    break;
                case 2:
                    Console.WriteLine("Forecast: Part Cloudy & Sunny");
                    break;
                case 3:
                    Console.WriteLine("Forecast: Strong Overcast");
                    break;
                case 4:
                    Console.WriteLine("Forecast: Light Rains");
                    break;
                case 5:
                    Console.WriteLine("Forecast: Rainy Day");
                    break;
                default:
                    setForecast();
                    break;
            }
        }

        public int getTemperature()
        {
            temperature = setRandomTemperature();
            return temperature;
        }

        public int setRandomTemperature()
        {
            Random tempset = new Random();
            temperature = tempset.Next(63, 102);
            return temperature;
        }

        public void setweatherForecast()
        {
            Console.WriteLine("Weather Forcast:");
            setForecast();
            Console.WriteLine("High: {0} F", setRandomTemperature());
        }

        public void getweatherForecast()
        {
            Console.WriteLine("Weather Forcast:");
            getForecast();
            Console.WriteLine("High: {0} F", getTemperature());
        }

        public void setPredictWeather()
        {
            Console.WriteLine("Weather Prediction:");
            setForecast();
            Console.WriteLine("High: {0} F", setRandomTemperature());
        }

        public void getPrdictWeather()
        {
            Console.WriteLine("Weather Prediction:");
            getForecast();
            Console.WriteLine("High: {0} F", getTemperature());
        }

        public void getForecast()
        {
            forecast = Console.Read();
            if (forecast == 1)
            {
                Console.WriteLine("Forecast: Bright & Sunny");
            }
            else if (forecast == 2)
            {
                Console.WriteLine("Forcast: Part Cloudy & Sunny");
            }
            else if (forecast == 3)
            {
                Console.WriteLine("Forcast: Strong Overcast");
            }
            else if (forecast == 4)
            {
                Console.WriteLine("Forcast: Light Rains");
            }
            else if (forecast == 5)
            {
                Console.WriteLine("Forcast: Rainy Day");
            }
            else
            {
                getForecast();
            }
        }

    }

}
