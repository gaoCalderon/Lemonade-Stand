using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand_Project
{
    class Consumer
    {
        public string customerName;
        public int temperatureAffect;
        public int weatherAffect;

        Weather sky = new Weather();

        public void Consumer(string CustomerName, int TemperatureAffect, int WeatherAffect)
        {
            this.customerName = CustomerName;
            this.temperatureAffect = TemperatureAffect;
            this.weatherAffect = WeatherAffect;
        }


        public void thirst()
        {
            
        }

        public void demand()
        {

        }

        public void consumerPreffer()
        {
            int results = sky.GetDayTemperature();
            if (results <= 72)
            {
                int check = sky.getForecast();
                if (check <= 3)
                {
                    thirst();
                }
                else
                {
                    demand();
                }
            }
            else if (results <= 79)
            {
                int check = sky.getForecast();
                if (check <= 4)
                {
                    thirst();
                }
                else
                {
                    demand();
                }
            }
            else if (results <= 86)
            {

            }
            else if (results <= 93)
            {

            }
            else if (results <= 100)
            {

            }
            else if (results <= 107)
            {

            }
            else
            {
                consumerPreffer();
            }
        }


    }
}
