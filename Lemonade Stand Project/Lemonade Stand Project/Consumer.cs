using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand_Project
{
    class Consumer
    {
        public string name;
        public int temperatureAffect;
        public int weatherAffect;

        Weather sky = new Weather();
        Cups cup = new Cups();
        Stand sta = new Stand();

        public Consumer(string Name, int TemperatureAffect, int WeatherAffect)
        {
            this.name = Name;
            this.temperatureAffect = TemperatureAffect;
            this.weatherAffect = WeatherAffect;
        }


        public void thirst()
        {
            sta.actionConsumerBuyRealCup();
        }

        public int makeNumberOFCustomersPerDay()
        {
            Random people = new Random();
            int numberOfCustomers = people.Next(2, 62);
            return numberOfCustomers;
        }


        public string getNumberOfCustomersInDay()
        {
            return name;
        }

        public int setPersonTempPrefer()
        {
            temperatureAffect = sky.setRandomTemperature();
            return temperatureAffect;
        }

        public int getPersonTempPrefer()
        {
            return temperatureAffect;
        }

        public int setPersonForecastPrefer()
        {
            weatherAffect = sky.setRandomForecast();
            return weatherAffect;
        }

        public int getPersonForecastPrefer()
        {
            return weatherAffect;
        }

        
    }
}
