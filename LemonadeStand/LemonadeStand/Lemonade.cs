using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Lemonade
    {
        public List<Lemonade> cupsOfLemonade;
        private decimal lemonadePrice;
        private int lemonadeType;

        public decimal LemonadePrice
        {
            get { return lemonadePrice; }
            set { lemonadePrice = value; }           
        }

        public int LemonadeType
        {
            get { return lemonadeType; }
            set { lemonadeType = value; }
        }

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
            Console.Write("\nSet your price per cup of lemonade: $");
            LemonadePrice = Convert.ToDecimal(Console.ReadLine());
        }

        public void DisplayCupsOfLemonade()
        {
            Console.WriteLine("Cups of Lemonade: {0}", cupsOfLemonade.Count);
        }
    }
}
