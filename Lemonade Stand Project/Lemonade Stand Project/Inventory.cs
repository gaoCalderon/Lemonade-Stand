using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand_Project
{
    class Inventory
    {
        decimal money;
        int cups;
        int lemons;
        int sugar;
        int iceCubes;

        public void inventoryProducts()
        {
            this.money = 20;
            this.cups = 0;
            this.lemons = 0;
            this.sugar = 0;
            this.iceCubes = 0;
        }

        public decimal getMoney()
        {
            return this.money;
        }
        
        public int getCups()
        {
            return this.cups;
        }

        public int getLemons()
        {
            return this.lemons;
        }

        public int getSugar()
        {
            return this.sugar;
        }

        public int getIceCubes()
        {
            return this.iceCubes;
        }

        public string enterInventory()
        {
            Player person = new Player();
            Console.WriteLine("{0} currently have ${1} avaialbe", person.getName(),getMoney());
            Console.WriteLine("{0} number of Cups", getCups());
            Console.WriteLine("{0} number of Lemons", getLemons());
            Console.WriteLine("{0} number cups of Sugar", getSugar());
            Console.WriteLine("{0} number of Ice Cubes", getIceCubes());
        }

        public string stockInventory()
        {
            Console.WriteLine("Would you like to purchase items for your inventory? Yes/No [ENTER]");
            Day day = new Day();
            
            string userchoice = Console.ReadLine();
            if (userchoice == "yes")
            {
                Console.WriteLine("What would you like to purchase?");
                Console.WriteLine("Type in one: cups /lemons/sugar/ice [ENTER KEY]");
                inventoryStore();
            }
            else if (userchoice == "no")
            {
                continue;
            }
            else
            {
                Console.WriteLine("yes/no [ENTER KEY]");
                stockInventory();
            }
        }

        private string inventoryStore()
        {

        }
}
