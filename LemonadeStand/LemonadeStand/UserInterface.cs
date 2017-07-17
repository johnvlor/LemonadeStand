using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public static class UserInterface
    {
        public static void GetRules()
        {
            Console.WriteLine("Your goal is to make as much money as you can in 7 days by selling lemonade at your lemonade stand.");
            Console.WriteLine("Purchase enough inventory (cups, lemons, sugar, and ice cubes) to make and sell your lemonade.");
            Console.WriteLine("Set your price and adjust it accordingly based on the weather conditions as well.");
            Console.WriteLine("At the end of the game, you'll see how much money you made.");
            Console.WriteLine();
        }

        public static void DisplayProfit(Player playerOne)
        {
            Console.WriteLine("Today's Profit: ${0}", playerOne.Profit);
            Console.WriteLine("Total Revenue: ${0}", playerOne.TotalRevenue);
        }

        public static void DisplayRevenue(Player playerOne)
        {
            Console.WriteLine("Total Revenue: ${0}", playerOne.TotalRevenue);
        }


    }
}
