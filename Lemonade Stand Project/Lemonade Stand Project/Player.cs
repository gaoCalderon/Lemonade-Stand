using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand_Project
{
    class Player
    {
        public static string name;
        public static string aiName;

        public void SetName()
        {
            Console.WriteLine("Please create a name: [ENTER]");
            name = Console.ReadLine();
        }

        public void RandomAiName()
        {
            Random ai = new Random();
            aiName = Console.ReadLine();
            switch (aiName)
            {
                case "Max":
                    break;
                case "Jay":
                    break;
                case "Tiffany":
                    break;
                case "Mini":
                    break;
                default:
                    RandomAiName();
                    break;
            }
        }



        public void createPlayerMode()
        {
            Game game = new Game();
            Day day = new Day();
            Inventory inv = new Inventory();
            Console.WriteLine("How many number of players.");
            Console.WriteLine("Please TYPE in a choice between: 1 or 2 (2 is to play against computer) [ENTER KEY]");
            string input = Console.ReadLine();
            int numberOfPlayers = int.Parse(input);
            if (numberOfPlayers == 1)
            {
                SetName();
                Inventory.totalMoney = 20;
                day.singleDayPath();
            }
            else if (numberOfPlayers == 2)
            {
                SetName();
                RandomAiName();
                Inventory.totalMoney = 20;
                day.humanAiDayPath();
            }
            else
            {
                Console.WriteLine("Invalid: Please pick between: 1, 2, 1 and");
                createPlayerMode();
            }
        }
    }
}
