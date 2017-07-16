using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Cup
    {
        public List<Cup> cups;
        private decimal price;

        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        public Cup()
        {
            cups = new List<Cup>();
            price = .05m;
        }

        public void DisplayCups()
        {
            Console.WriteLine("Cups: {0}", cups.Count);
        }

    }
}
