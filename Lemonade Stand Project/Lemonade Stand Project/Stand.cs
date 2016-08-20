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

        public void stand()
        {
            this.pitcher = 8;
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

        public void Customers()
        {
            Weather w = new Weather();
            List<Consumer> customerList = new List<Consumer>();
            customerList.Add(new Consumer("Angie Ling", 75, 1));

        }


    }
}
