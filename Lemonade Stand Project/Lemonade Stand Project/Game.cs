using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand_Project
{
    class Game
    {

        Player player = new Player();
        public void playerOne()
        {
            player.SetName();
        }

        public void playerTwo()
        {
            player.SetName();
        }

        public void runGame()
        {
            Console.WriteLine("Welcome to Lemonade Stand");
            player.createPlayerMode();
            Console.WriteLine("Would you like to play again? Yes/No [ENTER]");
            replay();
        }

        public void replay()
        {
            string response = Console.ReadLine();
            if (response == "yes")
            {
                runGame();
            }
            else if (response == "no")
            {
                Console.WriteLine("Come back and play again!");
            }
            else
            {
                Console.WriteLine("Would you like to play again? Yes/No [ENTER]");
                replay();
            }
        }
    }
}
