using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Customer
    {
        Random random;
        public List<Customer> potentialCustomer;
        public double buyProbability;

        public Customer(double buyProbability)
        {
            potentialCustomer = new List<Customer>();
            SetCustomerPreference();
        }

        public void DisplayPotentialCustomers()
        {
            Console.WriteLine("Customers: {0}", potentialCustomer.Count);
        }

        public void SetCustomerPreference()
        {
            buyProbability = 100;

        }
    }
}
