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

        public void player(string name)
        {
            this.name = name;
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
        public void AiSetName()
        {
            this.name = "Computer";
        }

        public string RandomAiName()
        {
            Random a = new Random();
            a.Next(0, AiNames.Count);
            string choice = AiNames[a.Next(0, AiNames.Count)];
        }

        public string createPlayerMode()
        {
            Game game = new Game();
            Console.WriteLine("Number of players: [TYPE] 1, or 2, or 1 and = verses Computer?");
            string numberOfPlayers = Console.ReadLine();

            if (numberOfPlayers == "1")
            {
                game.playerOne();
            }
            else if (numberOfPlayers == "2")
            {
                game.playerOne();
                game.playerTwo();

            }
            else if (numberOfPlayers == "1 and")
            {
                game.playerOne();
                RandomAiName();
            }
            else
            {
                Console.WriteLine("Invalid: Please pick between: 1, 2, or 1 and");
                createPlayerMode();
            }
        }
    }
}
