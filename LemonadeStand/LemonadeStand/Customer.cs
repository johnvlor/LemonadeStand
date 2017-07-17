﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Customer
    {
        Random random;
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
            Console.WriteLine("Customers: {0}", potentialCustomer.Count);
        }

    }
}
