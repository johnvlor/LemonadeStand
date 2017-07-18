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
            Console.WriteLine("Money: ${0}", playerOne.wallet.Money);
        }

        public static void DisplayExpense(Player playerOne)
        {
            Console.WriteLine("  Expense: ${0}", playerOne.Expense);
        }

        public static void DisplayProfit(Player playerOne)
        {
            Console.WriteLine("  Profit: ${0}", playerOne.Profit);
        }

        public static void DisplayNetProfit(Player playerOne)
        {
            Console.WriteLine("  Today you made a net profit: ${0}", playerOne.NetProfit);
        }

        public static void DisplayNetLoss(Player playerOne)
        {
            Console.WriteLine("  Today you had a net loss: $({0})", decimal.Negate(playerOne.NetProfit));
        }

        public static void DisplayTotalProfit(Player playerOne)
        {
            Console.WriteLine("  Total Profit: ${0}", playerOne.TotalProfit);
        }

        public static void DisplayTotalExpense(Player playerOne)
        {
            Console.WriteLine("  Total Expense: ${0}", playerOne.TotalExpense);
        }

        public static void DisplayTotalNetProfit(Player playerOne)
        {
            Console.WriteLine("  Total Net Profit: ${0}", playerOne.TotalNetProfit);
        }

        public static void DisplayTotalNetLoss(Player playerOne)
        {
            Console.WriteLine("  Total Net Loss: $({0})", decimal.Negate(playerOne.TotalNetProfit));
        }

        public static void MainMenu(Player playerOne)
        {
            Console.WriteLine("Let's start with the store");
        }



    }
}
