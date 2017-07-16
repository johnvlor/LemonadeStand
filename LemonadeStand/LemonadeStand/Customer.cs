using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Customer
    {
        public List<Customer> potentialCustomer;
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
            potentialCustomer = new List<Customer>();
            buyProbability = 100;
        }

        public void DisplayPotentialCustomers()
        {
            Console.WriteLine("Customers: {0}", potentialCustomer.Count);
        }

        public void SetCustomerPreference(Player playerOne)
        {
            
        }
    }
}
