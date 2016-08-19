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
        Lemons lem = new Lemons();
        Sugar sug = new Sugar();
        Ice ice = new Ice();
        Consumer con = new Consumer();
        Recipe rec = new Recipe();

        public int pitcher;

        public void stand()
        {
            this.pitcher = 8;
        }

        public int makePitcher()
        {
            rec.useRecipeMakePitcher();
            return pitcher;
        }

        public void checkHowMuchInPitcher()
        {
            string liquid = Console.ReadLine();
            pitcher = int.Parse(liquid);
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

        


    }
}
