using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand_Project
{
    class Customer
    {
        string teenBoy;
        string teenGirl;
        string parentChild;
        string adultMale;
        string adultFemale;
        string athlete;
        string dogWalker;
        string elderlyFemale;
        string elderlyMale;
        string fireman;
        string policeman;

        public Customer(string teenBoy, string teenGirl, string parentChild, string adultMale, string adultFemale, string athlete, string dogWalker, string elderlyFemale, string elderlyMale, string fireman, string policeman)
        {
            this.teenBoy = teenBoy;
            this.teenGirl = teenGirl;
            this.parentChild = parentChild;
            this.adultFemale = adultFemale;
            this.adultMale = adultMale;
            this.athlete = athlete;
            this.dogWalker = dogWalker;
            this.elderlyFemale = elderlyFemale;
            this.elderlyMale = elderlyMale;
            this.fireman = fireman;
            this.policeman = policeman;
        }

        public string randomCustomerpass()
        {
            Random c = new Random();
            c.Next(0, Customers.Count);
            string choice = Customers[c.Next(0, Customers.Count)];
            return choice;
        }

        public decimal purchaseLemonade()
        {
            
        }

        public string weatherAffects()
        {
            Weather weather = new Weather(0);
            weather.weatherRecord();
        }

        public string Teen()
        {
            return this.teen;
        }

        public string teenPurchasePrecent()
        {
            Weather weathers = new Weather();
            bool weathers.weather = true;
            "sunny" = true;
            "partly cloudy" = true;
            "partly cloudy with rain" = true;
            "cloudy" = false;
            "cloudy with rain" = false;
            "rainy" = false;
        }
    }
}
