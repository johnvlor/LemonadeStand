﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Player
    {
        protected string name;
        public decimal money;
        public Inventory inventory = new Inventory();

        public Player()
        {
            SetMoney();
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

        public void SetMoney()
        {
            money = 20.00m;
        }


    }
}
