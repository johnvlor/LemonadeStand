using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Lemonade
    {
        public List<Lemonade> cupsOfLemonade;
        public decimal lemonadePrice;

        public Lemonade()
        {
            cupsOfLemonade = new List<Lemonade>();
            lemonadePrice = .05m;
        }

        public decimal GetPricePerCupLemonade()
        {
            return lemonadePrice;
        }

        public void SetLemonadePrice()
        {
            Console.Write("Set your price per cup of lemonade: $");
            lemonadePrice = decimal.Parse(Console.ReadLine());
            Console.WriteLine(lemonadePrice);
        }

        public void DisplayCupsOfLemonade()
        {
            Console.WriteLine("Cups of Lemonade made: {0}", cupsOfLemonade.Count);
        }
    }
}
