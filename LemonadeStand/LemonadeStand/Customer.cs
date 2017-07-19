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
        private int lemonadeTypePreference;

        public int LemonadeTypePreference
        {
            get { return lemonadeTypePreference; }
            set { lemonadeTypePreference = value; }
        }

        public Customer(int LemonadeTypePreference)
        {
            potentialCustomer = new List<Customer>();
            purchasingCustomer = new List<Customer>();
            this.LemonadeTypePreference = LemonadeTypePreference;
        }

    }
}
