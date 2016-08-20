using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand_Project
{
    class Stand
    {
        Cups cup = new Cups();
        Ice ice = new Ice();
        Recipe rec = new Recipe();

        public int pitcher;
        public int recordTotalCustomers;

        public void stand()
        {
            this.pitcher = 8;
            this.recordTotalCustomers = 0;
        }

        public int getPicter()
        {
            return pitcher;
        }

        public int makeFirstPitcher()
        {
            rec.useRecipeMakePitcher();
            return pitcher;
        }

        public void checkHowMuchInPitcher()
        {
            if (pitcher <= 0)
            {
                rec.useRecipeMakePitcher();
                pitcher += 8;
            }
            else
            {
                pitcher -= 1;
            }
        }

        public void PourDrink()
        {
            checkHowMuchInPitcher();
        }

        public void actionConsumerBuyRealCup()
        {
            cup.purchaseCup();
            ice.useIceCube();
            PourDrink();
        }

        public int getTotalNumberOfCustomers()
        {
            return recordTotalCustomers;
        }

        public int setNumberOFCustomersPerDay()
        {
            Random people = new Random();
            recordTotalCustomers = people.Next(2, 62);
            return recordTotalCustomers;
        }

        public void Customers()
        {
            Weather w = new Weather();
            List<Consumer> customerList = new List<Consumer>();
            customerList.Add(new Consumer("Angie Ling", 75, 1, 0.5));
            customerList.Add(new Consumer("Lola Fisher", 79, 2, 0.40));
            customerList.Add(new Consumer("Kim Mocholie", 82, 3, 0.35));
            customerList.Add(new Consumer("Ellision Jam", 87, 4, 0.75));
            customerList.Add(new Consumer("Mary Nano", 65, 5, 0.60));
            customerList.Add(new Consumer("Jane Boost", 92, 1, 0.30));
            customerList.Add(new Consumer("Barbie Stone", 66, 2, 0.72));
            customerList.Add(new Consumer("Zilena Halls", 89, 3, 0.33));
            customerList.Add(new Consumer("Clare Porter", 95, 4, 0.95));
            customerList.Add(new Consumer("Micheal Mark", 85, 1, 0.35));
            customerList.Add(new Consumer("Eric Dog", 92, 2, 0.25));
            customerList.Add(new Consumer("Marco Polo", 78, 3, 0.18));
            customerList.Add(new Consumer("Lenard Pine", 96, 4, 0.35));
            customerList.Add(new Consumer("Rick Lucy", 72, 1, 0.85));
            customerList.Add(new Consumer("Isac Duber", 84, 2, 0.10));
            customerList.Add(new Consumer("Sean Nicker", 66, 3, 1.00));
            customerList.Add(new Consumer("Oscer Yamin", 93, 4, 0.22));
            customerList.Add(new Consumer("Aaron Drew", 86, 5, 0.25));
        }


    }
}
