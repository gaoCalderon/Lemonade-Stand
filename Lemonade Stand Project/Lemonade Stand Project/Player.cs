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

        public void player(string name, string aiName)
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
            this.name = Console.ReadLine();
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
            Console.WriteLine("Number of players, Please TYPE either: 1, 2, or 1 and (play against computer) [ENTER KEY]");
            string numberOfPlayers = Console.ReadLine();

            if (numberOfPlayers == "1")
            {
                game.playerOne();
                day.singleDayPath();
            }
            else if (numberOfPlayers == "2")
            {
                game.playerOne();
                game.playerTwo();
                day.doubleDayPay();

            }
            else if (numberOfPlayers == "1 and")
            {
                game.playerOne();
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
