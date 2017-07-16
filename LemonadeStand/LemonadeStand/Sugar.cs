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
        private decimal price;

        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        public Sugar()
        {
            sugar = new List<Sugar>();
            price = .06m;
        }

        public void DisplaySugar()
        {
            Console.WriteLine("Sugar: {0}", sugar.Count);
        }
    }
}
