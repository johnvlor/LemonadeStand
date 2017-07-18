using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Wallet
    {
        private decimal money;

        public decimal Money
        {
            get { return money; }
            set { money = value; }
        }

        public Wallet()
        {
            money = 15.00m;
        }

        public bool RemoveMoney(decimal transactionAmount)
        {
            if (transactionAmount > money)
            {
                Console.WriteLine("Sorry, not enough money.");
                return false;
            }
            else
            {
                Money = Money - transactionAmount;
            }
            return true;
        }
    }
}
