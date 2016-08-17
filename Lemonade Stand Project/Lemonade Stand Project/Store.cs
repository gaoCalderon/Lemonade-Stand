using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand_Project
{
    class Store
    {
        public void purchaseCups()
        {
            Console.WriteLine("How many cups do you want to buy?");
            Console.WriteLine("a.) 25 cups for $1.00");
            Console.WriteLine("b.) 50 cups for $1.50");
            Console.WriteLine("c.) 100 cups for $2.80");
            string buy = Console.ReadLine();
            if (buy == "a")
            {
                //insert return remaining subtraction amount from $20 bill

                keepBuyingCups();
            }
            else if (buy == "b")
            {
                //insert return remaining subtraction amount from $20 bill

                keepBuyingCups();
            }
            else if (buy == "c")
            {
                //insert return remaining subtraction amount from $20 bill

                keepBuyingCups();
            }
            else
            {
                Console.WriteLine("INVALID / Please type in choices between: a, b, or c + [ENTER KEY]");
                purchaseCups();
            }

        }

        public void purchaseLemons()
        {
            Console.WriteLine("How many lemons do you want to buy?");
            Console.WriteLine("a.) 10 lemons for $1.00");
            Console.WriteLine("b.) 30 lemons for $2.40");
            Console.WriteLine("c.) 75 of lemons for $3.75");
            string buy = Console.ReadLine();
            if (buy == "a")
            {
                //insert return remaining subtraction amount from $20 bill

                keepBuyingLemons();
            }
            else if (buy == "b")
            {
                //insert return remaining subtraction amount from $20 bill

                keepBuyingLemons();
            }
            else if (buy == "c")
            {
                //insert return remaining subtraction amount from $20 bill

                keepBuyingLemons();
            }
            else
            {
                Console.WriteLine("INVALID / Please type in choices between: a, b, or c + [ENTER KEY]");
                purchaseLemons();
            }
        }

        public void purchaseSugar()
        {
            Console.WriteLine("How many cups of sugar do you want to buy?");
            Console.WriteLine("a.) 8 cups of sugar for $0.80");
            Console.WriteLine("b.) 20 cups of sugar for $1.60");
            Console.WriteLine("c.) 48 cups of sugar for $4.32");
            string buy = Console.ReadLine();
            if (buy == "a")
            {
                //insert return remaining subtraction amount from $20 bill

                keepBuyingSugar();
            }
            else if (buy == "b")
            {
                //insert return remaining subtraction amount from $20 bill

                keepBuyingSugar();
            }
            else if (buy == "c")
            {
                //insert return remaining subtraction amount from $20 bill

                keepBuyingSugar();
            }
            else
            {
                Console.WriteLine("INVALID / Please type in choices between: a, b, or c + [ENTER KEY]");
                purchaseSugar();
            }
        }

        public void purchaseIceCubes()
        {
            Console.WriteLine("How many ice cubes do you want to buy?");
            Console.WriteLine("a.) 100 ice cubes for $0.75");
            Console.WriteLine("b.) 250 ice cubes for $2.00");
            Console.WriteLine("c.) 500 ice cubes for $3.55");
            string buy = Console.ReadLine();
            if (buy == "a")
            {
                //insert return remaining subtraction amount from $20 bill

                keepBuyingIce();
            }
            else if (buy == "b")
            {
                //insert return remaining subtraction amount from $20 bill

                keepBuyingIce();
            }
            else if (buy == "c")
            {
                //insert return remaining subtraction amount from $20 bill

                keepBuyingIce();
            }
            else
            {
                Console.WriteLine("INVALID / Please type in choice between: a, b, c + [ENTER KEY]");
                purchaseIceCubes();
            }
        }

        public void noMoreBuying()
        {
            Inventory inventory = new Inventory();
            inventory.showInventory();
            Console.WriteLine("What item would you like to purchase?");
            Console.WriteLine("Type in a letter: a.) cups / b.) lemons / c.) sugar / d.) ice");
            Console.WriteLine("Other Options: e.) bankrupt / f.) help / g.)exit [ENTER KEY]");
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
            else if (response == "no")
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
            else if (response == "no")
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
            else if (response == "no")
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
            else if (response == "no")
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
