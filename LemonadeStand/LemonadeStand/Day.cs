using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Day
    {
        public Weather weather;
        public Customer customer;
        int day;
        int customerQty;

        public Day()
        {
            weather = new Weather();
            customer = new Customer();
            day = 1;
        }

        public void GetDay()
        {
            Console.WriteLine("Day {0}", day);
        }

        public int CheckDay()
        {
            return day += 1;
        }

        public void GetTodaysWeather(Random random)
        {
            weather.DisplayWeather(random);
        }

        public void StartDay(Random random)
        {
            GetDay();
            GetCustomers(random);
            customer.DisplayCustomers();

        }

        public void GetCustomers(Random random)
        {
            random = new Random();
            customerQty = random.Next(100);
            AddCustomers();
        }

        public void AddCustomers()
        {
            for (int i = 0; i < customerQty; i++)
            {
                customer.customer.Add(new Customer());
            }
        }

    }
}
