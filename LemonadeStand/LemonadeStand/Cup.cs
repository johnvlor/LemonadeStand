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

        public Cup()
        {
            cups = new List<Cup>();
        }

        public void DisplayCups()
        {
            Console.WriteLine("Cups: {0}", cups.Count);
        }

    }
}
