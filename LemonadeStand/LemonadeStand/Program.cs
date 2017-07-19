using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Program
    {
        static void Main(string[] args)
        {
            Game lemonadeStand = new Game();
            lemonadeStand.PlayGame();
            Database.AddToDatabase(lemonadeStand);

            Console.ReadKey();
        }
    }
}
