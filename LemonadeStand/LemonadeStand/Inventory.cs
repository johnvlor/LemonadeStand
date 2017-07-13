using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Inventory
    {
        public Cup cup;
        public Lemon lemon;

        public Inventory()
        {
            cup = new Cup();
            lemon = new Lemon();

        }

        public void CheckInventory()
        {
            Console.WriteLine("Current Inventory");
            cup.DisplayCups();
            lemon.DisplayLemons();
        }

    }
}
