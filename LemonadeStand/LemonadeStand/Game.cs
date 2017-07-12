using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {
        Player playerOne;

        public Game()
        {

        }

        public void PlayGame()
        {
            GetPlayer();
        }

        public void GetPlayer()
        {
            playerOne = new Human("player one");

        }
    }
}
