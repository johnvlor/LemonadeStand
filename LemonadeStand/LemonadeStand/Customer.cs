using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Customer
    {
        public List<Customer> customer;
        private double buyProbability;

        public double BuyProbability
        {
            get
            {
                return buyProbability;
            }
            set
            {
                buyProbability = value;
            }
        }

        public Customer()
        {
            customer = new List<Customer>();
            buyProbability = 100;
        }

        public void DisplayCustomers()
        {
            Console.WriteLine("Customers: {0}", customer.Count);
        }
    }
}
