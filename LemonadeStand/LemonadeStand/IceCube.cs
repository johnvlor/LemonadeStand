using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class IceCube
    {
        public List<IceCube> iceCubes;
        private decimal price;

        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        public IceCube()
        {
            iceCubes = new List<IceCube>();
            price = .03m;
        }

        public void DisplayIceCubes()
        {
            Console.WriteLine("Ice cubes: {0}", iceCubes.Count);
        }
    }
}
