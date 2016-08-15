using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand_Project
{
    class Customer
    {
        string teen;
        string parentChild;
        string adult;
        string athlete;
        string dogWalker;
        string elderly;
        string fireman;
        string policeman;

        public string Customers(string teen, string parentChild, string adult, string athlete, string dogWalker, string elderly, string fireman, string policeman)
        {
            this.teen = teen;
            this.parentChild = parentChild;
            this.adult = adult;
            this.athlete = athlete;
            this.dogWalker = dogWalker;
            this.elderly = elderly;
            this.fireman = fireman;
            this.policeman = policeman;
        }

        public string randomCustomer()
        {
            Random c = new Random();
            c.Next(0, Customers.Count);
            string choice = Customers[c.Next(0, Customers.Count)];
        }

        public string Teen()
        {
            return this.teen;
        }

        public string teenPurchase()
        {

        }
    }
}
