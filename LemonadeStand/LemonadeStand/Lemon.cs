using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Lemon
    {
        public List<Lemon> lemons;

        public Lemon()
        {
            lemons = new List<Lemon>();
        }

        public void DisplayLemons()
        {
            Console.WriteLine("Lemons: {0}", lemons.Count);
        }

    }
}
