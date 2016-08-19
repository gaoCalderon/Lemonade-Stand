using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand_Project
{
    class Consumer
    {
        public string customer;
        public double cash;
        public int temperatureAffect;
        public int weatherAffect;

        public void Consumer(string customer)
        {
            this.customer = customer;
            this.cash = 2;
            this.temperatureAffect = 0;
            this.weatherAffect = 0;
        }

        public double getCash()
        {
            return this.cash;
        }

        public void thirst()
        {

        }


    }
}
