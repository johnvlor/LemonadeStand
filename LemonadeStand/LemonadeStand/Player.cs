using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Player
    {
        protected string name;
        protected decimal money;

        public Player()
        {
            money = 20.00m;
        }

        public string GetName()
        {
            return name;
        }

        public decimal GetMoney()
        {
            return money;
        }

        public void DisplayMoney()
        {
            Console.WriteLine("Money: ${0}", GetMoney());
        }

    }
}
