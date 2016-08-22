using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand_Project
{
    class Player
    {
        string name;
        string aiName;

        public Player(string name, string aiName)
        {
            this.name = name;
            this.aiName = aiName;
        }

         public string getName()
        {
            return this.name;
        }

        public void SetName()
        {
            Console.WriteLine("Please create a name: [ENTER]");
            name = Console.ReadLine();
        }

        List<string> AiNames = new List<string>() {"Sent", "Tey", "Cater", "Fin", "Einner"};

        public string getAiName()
        {
            aiName = RandomAiName();
            return aiName;
        }

        public string RandomAiName()
        {
            Random a = new Random();
            a.Next(0, AiNames.Count);
            string choice = AiNames[a.Next(0, AiNames.Count)];
            return choice;
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
                inv.startMoney();
                day.singleDayPath();
            }
            else if (numberOfPlayers == 2)
            {
                SetName();
                RandomAiName();
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
