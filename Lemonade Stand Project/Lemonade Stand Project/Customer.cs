using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand_Project
{
    class Customer
    {
        int teenBoy;
        int teenGirl;
        int parentChild;
        int adultMale;
        int adultFemale;
        int athlete;
        int dogWalker;
        int elderlyFemale;
        int elderlyMale;
        int fireman;
        int policeman;

        public string Customers()
        {
            this.teenBoy = 1;
            this.teenGirl = 1;
            this.parentChild = 2;
            this.adultFemale = 1;
            this.adultMale = 1;
            this.athlete = 1;
            this.dogWalker = 1;
            this.elderlyFemale = 1;
            this.elderlyMale = 1;
            this.fireman = 1;
            this.policeman = 1;
        }

        public string randomCustomerpass()
        {
            Random c = new Random();
            c.Next(0, Customers.Count);
            string choice = Customers[c.Next(0, Customers.Count)];
        }

        public decimal purchaseLemonade()
        {
            
        }

        public string weatherAffects()
        {
            Weather weather = new Weather();
            weather.weatherRecord();
        }

        public string Teen()
        {
            return this.teen;
        }

        public string teenPurchasePrecent()
        {
            Weather weather = new Weather();
            bool weather.weather = true;
            "sunny" = true;
            "partly cloudy" = true;
            "partly cloudy with rain" = true;
            "cloudy" = false;
            "cloudy with rain" = false;
            "rainy" = false;
        }
    }
}
