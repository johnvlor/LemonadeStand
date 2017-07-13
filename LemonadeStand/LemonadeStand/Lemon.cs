using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Lemon
    {
        public int lemons;

        public Lemon()
        {
            lemons = 0;
        }

        public int GetLemons()
        {
            return lemons;
        }

        public void DisplayLemons()
        {
            Console.WriteLine("Lemons: {0}", GetLemons());
        }

    }
}
