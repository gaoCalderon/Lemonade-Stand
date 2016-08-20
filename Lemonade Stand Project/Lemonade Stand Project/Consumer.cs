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
        public double demand;

        Weather sky = new Weather();
        Cups cup = new Cups();
        Stand sta = new Stand();

        public Consumer(string Name, int TemperatureAffect, int WeatherAffect, double Demand)
        {
            this.name = Name;
            this.temperatureAffect = TemperatureAffect;
            this.weatherAffect = WeatherAffect;
            this.demand = Demand;
        }

        public string getCustomerName()
        {
            return name;
        }

        public int getPersonTempPrefer()
        {
            return temperatureAffect;
        }

        public int getPersonForecastPrefer()
        {
            return weatherAffect;
        }

        public double demandPriceOfCup()
        {
            return demand;
        }

        public void ifThirsty()
        {
            double check = sky.getForecast;
            if (check >= double.Parse.sta.Customers)
            {

            }
        }
    }

}
