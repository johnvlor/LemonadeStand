using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Sugar
    {
        public List<Sugar> sugar;

        public Sugar()
        {
            sugar = new List<Sugar>();
        }

        public void DisplaySugar()
        {
            Console.WriteLine("Sugar: {0}", sugar.Count);
        }
    }
}
