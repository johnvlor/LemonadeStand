using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Human : Player
    {
        public Human(string name)
        {
            this.name = name;
            ChangeName();
        }

        public void ChangeName()
        {
            Console.WriteLine("Enter {0}'s name: ", name);
            name = Console.ReadLine();
        }

    }
}
