using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Cup
    {
        public int cups;

        public Cup()
        {
            cups = 0;
        }

        public int GetCups()
        {
            return cups;
        }

        public void DisplayCups()
        {
            Console.WriteLine("Cups: {0}", GetCups());
        }
    }
}
