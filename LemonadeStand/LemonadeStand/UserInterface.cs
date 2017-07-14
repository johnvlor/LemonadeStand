using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public static class UserInterface
    {

        public static void DisplayProfit(Player playerOne)
        {
            Console.WriteLine("Profit: ${0}", playerOne.Profit);
        }


    }
}
