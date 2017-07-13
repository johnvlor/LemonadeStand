using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Store
    {
        int purchase;
        
        public Store()
        {

        }

        public void DisplayPriceOfCups()
        {
            Console.WriteLine("\nCups");
            Console.WriteLine("1 for $0.05 each");
            Console.WriteLine("15 or more for $0.04 each");
            Console.WriteLine("30 or more for $0.03 each");
        }

        public void BuyCups(Player playerOne)
        {
            Console.WriteLine("How many would you like to buy?");
            purchase = Int32.Parse(Console.ReadLine());

            if (purchase < 15)
            {
                playerOne.inventory.cup.cups += purchase;
                playerOne.money = playerOne.money - .05m;
            }
            else if ((purchase >= 15) && (purchase < 30))
            {
                playerOne.inventory.cup.cups += purchase;
                playerOne.money = playerOne.money - (purchase * .04m);
            }
            else if (purchase > 30)
            {
                playerOne.inventory.cup.cups += purchase;
                playerOne.money = playerOne.money - (purchase * .03m);
            }

        }

        public void DisplayPriceOfLemons()
        {
            Console.WriteLine("\nLemons");
            Console.WriteLine("1 for $0.10 each");
            Console.WriteLine("15 or more for $0.07 each");
            Console.WriteLine("30 or more for $0.05 each");
        }

        public void BuyLemons(Player playerOne)
        {
            Console.WriteLine("How many would you like to buy?");
            purchase = Int32.Parse(Console.ReadLine());

            if (purchase < 15)
            {
                playerOne.inventory.lemon.lemons += purchase;
                playerOne.money = playerOne.money - .10m;
            }
            else if ((purchase >= 15) && (purchase < 30))
            {
                playerOne.inventory.lemon.lemons += purchase;
                playerOne.money = playerOne.money - (purchase * .07m);
            }
            else if (purchase > 30)
            {
                playerOne.inventory.lemon.lemons += purchase;
                playerOne.money = playerOne.money - (purchase * .05m);
            }

        }
    }
}
