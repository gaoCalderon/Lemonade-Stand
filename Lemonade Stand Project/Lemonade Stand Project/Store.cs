using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand_Project
{
    class Store
    {

        Recipe back = new Recipe();

        public void invalid()
        {
            Console.WriteLine("INVALID / Please type in choices between: a, b, c or g [ENTER KEY]");
        }

        Cups cup = new Cups();

        public void purchaseCups()
        {
            Console.WriteLine("How many cups do you want to buy?");
            Console.WriteLine("a.) 25 cups for $1.00");
            Console.WriteLine("b.) 50 cups for $1.50");
            Console.WriteLine("c.) 100 cups for $2.80");
            Console.WriteLine("g.) go back");
            string buy = Console.ReadLine();
            if (buy == "a")
            {
                cup.buy25Cups();
                keepBuyingCups();
            }
            else if (buy == "b")
            {
                cup.buy50Cups();
                keepBuyingCups();
            }
            else if (buy == "c")
            {
                cup.buy100Cups();
                keepBuyingCups();
            }
            else if (buy == "g")
            {
                back.stockInventory();
            }
            else
            {
                invalid();
                back.stockInventory();
            }

        }

        Lemons lemon = new Lemons();

        public void purchaseLemons()
        {
            Console.WriteLine("How many lemons do you want to buy?");
            Console.WriteLine("a.) 10 lemons for $1.00");
            Console.WriteLine("b.) 30 lemons for $2.40");
            Console.WriteLine("c.) 75 of lemons for $3.75");
            Console.WriteLine("g.) go back");
            string buy = Console.ReadLine();
            if (buy == "a")
            {
                lemon.buy10Lemons();
                keepBuyingLemons();
            }
            else if (buy == "b")
            {
                lemon.buy30Lemons();
                keepBuyingLemons();
            }
            else if (buy == "c")
            {
                lemon.buy75Lemons();
                keepBuyingLemons();
            }
            else if (buy == "g")
            {
                back.stockInventory();
            }
            else
            {
                invalid();
                back.stockInventory();
            }
        }

        Sugar sugar = new Sugar();

        public void purchaseSugar()
        {
            Console.WriteLine("How many cups of sugar do you want to buy?");
            Console.WriteLine("a.) 8 cups of sugar for $0.80");
            Console.WriteLine("b.) 20 cups of sugar for $1.60");
            Console.WriteLine("c.) 48 cups of sugar for $4.32");
            Console.WriteLine("g.) go back");
            string buy = Console.ReadLine();
            if (buy == "a")
            {
                sugar.buy8cupSugar();
                keepBuyingSugar();
            }
            else if (buy == "b")
            {
                sugar.buy20cupSugar();
                keepBuyingSugar();
            }
            else if (buy == "c")
            {
                sugar.buy48cupSugar();
                keepBuyingSugar();
            }
            else if (buy == "g")
            {
                back.stockInventory();
            }
            else
            {
                invalid();
                back.stockInventory();
            }
        }

        Ice ice = new Ice();

        public void purchaseIceCubes()
        {
            Console.WriteLine("How many ice cubes do you want to buy?");
            Console.WriteLine("a.) 100 ice cubes for $0.75");
            Console.WriteLine("b.) 250 ice cubes for $2.00");
            Console.WriteLine("c.) 500 ice cubes for $3.55");
            Console.WriteLine("g.) go back");
            string buy = Console.ReadLine();
            if (buy == "a")
            {
                ice.buy100iceCube();
                keepBuyingIce();
            }
            else if (buy == "b")
            {
                ice.buy250iceCube();
                keepBuyingIce();
            }
            else if (buy == "c")
            {
                ice.buy500iceCubes();
                keepBuyingIce();
            }
            else if (buy == "g")
            {
                back.stockInventory();
            }
            else
            {
                invalid();
                back.stockInventory();
            }
        }

        public void noMoreBuying()
        {
            Recipe inventory = new Recipe();
            inventory.showInventory();
            Console.WriteLine("What item would you like to purchase?");
            Console.WriteLine("Type in a letter: a.) cups / b.) lemons / c.) sugar / d.) ice");
            Console.WriteLine("Other Options:");
            Console.WriteLine("e.)done buying / f.)exit [ENTER KEY]");
            inventory.addInventory();
        }

        public void keepBuyingCups()
        {
            Console.WriteLine("Do you want to keep buying more cups? Yes/No [ENTER KEY]");
            string response = Console.ReadLine();
            if (response == "yes")
            {
                purchaseCups();
            }
            else if(response == "y")
            {
                purchaseCups();
            }
            else if (response == "no")
            {
                noMoreBuying();
            }
            else if (response == "n")
            {
                noMoreBuying();
            }
            else
            {
                Console.WriteLine("INVALID");
                keepBuyingCups();
            }
        }

        public void keepBuyingLemons()
        {
            Console.WriteLine("Do you want to keep buying more lemons? Yes/No [ENTER KEY]");
            string response = Console.ReadLine();
            if (response == "yes")
            {
                purchaseLemons();
            }
            else if (response == "y")
            {
                purchaseLemons();
            }
            else if (response == "no")
            {
                noMoreBuying();
            }
            else if (response == "n")
            {
                noMoreBuying();
            }
            else
            {
                Console.WriteLine("INVALID");
                keepBuyingCups();
            }
        }

        public void keepBuyingSugar()
        {
            Console.WriteLine("Do you want to keep buying more sugar? Yes/No [ENTER KEY]");
            string response = Console.ReadLine();
            if (response == "yes")
            {
                purchaseSugar();
            }
            else if (response == "y")
            {
                purchaseSugar();
            }
            else if (response == "no")
            {
                noMoreBuying();
            }
            else if (response == "n")
            {
                noMoreBuying();
            }
            else
            {
                Console.WriteLine("INVALID");
                keepBuyingSugar();
            }
        }

        public void keepBuyingIce()
        {
            Console.WriteLine("Do you want to keep buying more ice cubes? Yes/No [ENTER KEY]");
            string response = Console.ReadLine();
            if (response == "yes")
            {
                purchaseIceCubes();
            }
            else if (response == "y")
            {
                purchaseIceCubes();
            }
            else if (response == "no")
            {
                noMoreBuying();
            }
            else if (response == "n")
            {
                noMoreBuying();
            }
            else
            {
                Console.WriteLine("INVALID");
                keepBuyingIce();
            }
        }


    }
}
