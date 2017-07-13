using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class IceCube
    {
        public List<IceCube> iceCubes;

        public IceCube()
        {
            iceCubes = new List<IceCube>();
        }

        public void DisplayIceCubes()
        {
            Console.WriteLine("Ice cubes: {0}", iceCubes.Count);
        }
    }
}
