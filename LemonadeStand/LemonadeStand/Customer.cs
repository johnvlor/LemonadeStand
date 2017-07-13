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

        public Customer()
        {
            customer = new List<Customer>();
        }

        public void DisplayCustomers()
        {
            Console.WriteLine("Customers: {0}", customer.Count);
        }
    }
}
