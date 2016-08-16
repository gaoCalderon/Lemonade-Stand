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
        public string playerOne()
        {
            player.SetName();
        }

        public string playerTwo()
        {
            player.SetName();
        }

        public void runGame()
        {
            Player player = new Player();
            Console.WriteLine("Welcome to Lemonade Stand");
            player.createPlayerMode();
            Day numberOfDays = new Day();



            

        }
    }
}
