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
            Console.WriteLine("Welcome, to the Lemonade Stand Game!");
            Console.WriteLine("\nYour goal is to make as much money as you can in 7 days by selling lemonade at your lemonade stand.");
            Console.WriteLine("Purchase enough inventory (cups, lemons, sugar, and ice cubes) to make and sell your lemonade.");
            Console.WriteLine("Set your price and adjust it accordingly based on the weather conditions as well.");
            Console.WriteLine("At the end of the game, you'll see how much money you made.");
            Console.WriteLine();
        }

        public static void DisplayMoney(Player playerOne)
        {
            Console.WriteLine("\nCurrent Funds onhand");
            Console.WriteLine("Money: ${0}", playerOne.Money);
        }

        public static void DisplayExpense(Player playerOne)
        {
            Console.WriteLine("Expense: ${0}", playerOne.Expense);
        }

        public static void DisplayProfit(Player playerOne)
        {
            Console.WriteLine("Today's Profit: ${0}", playerOne.Profit);
        }

        public static void DisplayRevenue(Player playerOne)
        {
            Console.WriteLine("Total Revenue: ${0}", playerOne.TotalRevenue);
        }

        public static void DisplayTotalExpense(Player playerOne)
        {
            Console.WriteLine("Total Expense: ${0}", playerOne.TotalExpense);
        }

        public static void MainMenu(Player playerOne)
        {

        }



    }
}
