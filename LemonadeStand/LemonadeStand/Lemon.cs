using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Lemon
    {
        public List<Lemon> lemons;
        private decimal price;

        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        public Lemon()
        {
            lemons = new List<Lemon>();
            price = .10m;
        }

        public void DisplayLemons()
        {
            Console.WriteLine("Lemons: {0}", lemons.Count);
        }

    }
}
