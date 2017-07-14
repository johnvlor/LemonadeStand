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
        private decimal money;
        private decimal expense;
        private decimal profit;
        public Inventory inventory = new Inventory();
        public Recipe recipe = new Recipe();
        public Lemonade lemonade = new Lemonade();

        public decimal Money
        {
            get
            {
                return money;
            }
            set
            {
                money = value;
            }
        }

        public decimal Expense
        {
            get
            {
                return expense;
            }
            set
            {
                expense = value;
            }
        }

        public decimal Profit
        {
            get
            {
                return profit;
            }
            set
            {
                profit = value;
            }
        }

        public Player()
        {
            SetMoney();
        }

        public string GetName()
        {
            return name;
        }


        public void DisplayMoney()
        {
            Console.WriteLine();
            Console.WriteLine("Money: ${0}", Money);
            Console.WriteLine("Expense: ${0}", Expense);
            Console.WriteLine("Profit: ${0}", Profit);
        }

        public void SetMoney()
        {
            money = 20.00m;
            expense = 0m;
            profit = 0m;
        }


    }
}
