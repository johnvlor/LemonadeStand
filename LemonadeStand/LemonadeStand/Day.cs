using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Day
    {
        public int day;

        public Day()
        {
            day = 1;
        }

        public void GetDay()
        {
            Console.WriteLine("Day {0}",
                day);
        }

        public int CheckDay()
        {
            return day += 1;
        }

    }
}
