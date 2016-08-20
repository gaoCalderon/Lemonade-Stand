using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand_Project
{
    class FixClass
    {
        public int temperature;
        public int forecast;

        public int setForecast()
        {
            forecast = RandomForecast();
            return forecast;
        }

        public int RandomForecast()
        {
            Random f = new Random();
            int setRanForecast = f.Next(1, 5);
            return setRanForecast;
        }

        public void getForecast() //change name
        {
            int results = setForecast();
            if (results == 1)
            {
                Console.WriteLine("Bright & Sunny");
            }
            else if (results == 2)
            {
                Console.WriteLine("Part Cloudy & Sunny");
            }
            else if (results == 3)
            {
                Console.WriteLine("Strong Overcast");
            }
            else if (results == 4)
            {
                Console.WriteLine("Light Rains");
            }
            else if (results == 5)
            {
                Console.WriteLine("Rainy Day");
            }
            else
            {
                getTheForecast();
            }
        }



        public int getTemperature() //I changed this
        {
            return temperature;
        }

        public int setRandomTemperature()
        {
            Random tempset = new Random();
            int setTemp = tempset.Next(63, 102);
            return setTemp;
        }

        public void weatherForecast()
        {
            RandomForecast();
            setForecast();
            Console.WriteLine("Weather Forcast:");
            Console.WriteLine("Predicts: {0}", getForecast());
            Console.WriteLine("in the highs of {0} degrees Fahrenheit", setRandomTemperature());
        }

    }
}
