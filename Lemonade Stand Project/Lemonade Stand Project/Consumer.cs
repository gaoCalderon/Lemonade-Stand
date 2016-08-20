﻿using System;
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
        public int recordNonBuyCustomers;

        Weather sky = new Weather();
        Cups cup = new Cups();
        Stand sta = new Stand();

        public Consumer(string Name, int TemperatureAffect, int WeatherAffect, double Demand)
        {
            this.name = Name;
            this.temperatureAffect = TemperatureAffect;
            this.weatherAffect = WeatherAffect;
            this.demand = Demand;
            this.recordNonBuyCustomers = 0;
        }

        public string getCustomerName()
        {
            return name;
        }

        public int getPersonTempPrefer()
        {
            return temperatureAffect;
        }

        public void setPersonTempPrefer()
        {
            temperatureAffect = sky.setRandomTemperature();
        }

        public int getPersonForecastPrefer()
        {
            return weatherAffect;
        }

        public void setPersonForecastPrefer()
        {
            weatherAffect = sky.setRandomForecast();
        }

        public double getDemandPriceOfCup()
        {
            return demand;
        }

        public int getCustomersNotBuy()
        {
            return recordNonBuyCustomers;
        }

        public void setCustomerDemandPriceOfCup()
        {
            double demand = cup.getCupCharge();
            if (demand <= 0.18)
            {
                sta.actionConsumerBuyRealCup();
            }
            else
            {
                recordNonBuyCustomers += 1;
            }
        }

        



    }
}
