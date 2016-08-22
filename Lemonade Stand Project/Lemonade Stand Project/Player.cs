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
        int fill;

        public void SetName()
        {
            Console.WriteLine("Please create a name: [ENTER]");
            name = Console.ReadLine();
        }

        public void RandomAiName()
        {
            Random ai = new Random();
            fill = ai.Next(1, 4);
            switch (fill)
            {
                case 1:
                    aiName = "Max";
                    Console.WriteLine("Computer Player: {0}", aiName);
                    break;
                case 2:
                    aiName = "Jay";
                    Console.WriteLine("Computer Player: {0}", aiName);
                    break;
                case 3:
                    aiName = "Tiffany";
                    Console.WriteLine("Computer Player: {0}", aiName);
                    break;
                case 4:
                    aiName = "Mini";
                    Console.WriteLine("Computer Player: {0}", aiName);
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
                Console.WriteLine("Welcome {0} to Lemonade Stand", name);
                day.singleDayPath();
            }
            else if (numberOfPlayers == 2)
            {
                SetName();
                RandomAiName();
                Inventory.totalMoney = 20;
                Inventory.aiTotalMoney = 20;
                Console.WriteLine("Welcome {0} & {1} to Lemonade Stand", name, aiName);
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
