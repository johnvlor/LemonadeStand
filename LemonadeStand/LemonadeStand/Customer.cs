using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Customer
    {
        public List<Customer> potentialCustomer;
        public List<Customer> purchasingCustomer;
        public int lemonadeTypePreference;

        public Customer(int lemonadeTypePreference)
        {
            potentialCustomer = new List<Customer>();
            purchasingCustomer = new List<Customer>();
            this.lemonadeTypePreference = lemonadeTypePreference;
        }

        public void DisplayPotentialCustomers()
        {
            Console.WriteLine("\nPotential Customers coming through: {0}", potentialCustomer.Count);
        }

    }
}
