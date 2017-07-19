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
            lemonadePrice = .25m;
            
        }

        public decimal GetPricePerCupLemonade()
        {
            return lemonadePrice;
        }

        public void DisplayCupsOfLemonade()
        {
            Console.WriteLine("\nCups of Lemonade Made: {0}", cupsOfLemonade.Count);
        }

        public void AddCupsOfLemonade(Recipe recipe)
        {
            for (int i = 0; i < recipe.CupQty; i++)
            {
                cupsOfLemonade.Add(new Lemonade());
            }
        }

        public void GetLemonadeType(Recipe recipe)
        {
            if (recipe.LemonQty == recipe.SugarQty)
            {
                LemonadeType = 1;
            }
            else if (recipe.LemonQty > recipe.SugarQty)
            {
                LemonadeType = 2;
            }
            else if (recipe.LemonQty < recipe.SugarQty)
            {
                LemonadeType = 3;
            }
        }
    }
}
