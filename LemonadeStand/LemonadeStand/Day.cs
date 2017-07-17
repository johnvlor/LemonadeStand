using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Day
    {
        public Weather weather;
        public Customer customer;
        private int noCustomer;

        public Day()
        {
            weather = new Weather();
            customer = new Customer(0);
            noCustomer = 0;
        }

        public void StartDay(Random random)
        {
            weather.DisplayWeather(random);
            GetCustomers(random);            
        }

        public void GetCustomers(Random random)
        {
            DetermineNumberCustomers(random);
            AddCustomers(noCustomer, random);
        }

        public int DetermineNumberCustomers(Random random)
        {
            if (weather.weatherForecast[weather.forecast] == weather.weatherForecast[0])
            {
                noCustomer = random.Next(60, 120);
                return noCustomer;
            }
            else if (weather.weatherForecast[weather.forecast] == weather.weatherForecast[1])
            {
                noCustomer = random.Next(50, 90);
                return noCustomer;
            }
            else if (weather.weatherForecast[weather.forecast] == weather.weatherForecast[2])
            {
                noCustomer = random.Next(40, 80);
                return noCustomer;
            }
            else if (weather.weatherForecast[weather.forecast] == weather.weatherForecast[3])
            {
                noCustomer = random.Next(20, 60);
                return noCustomer;
            }
            else if (weather.weatherForecast[weather.forecast] == weather.weatherForecast[4])
            {
                noCustomer = random.Next(1, 40);
                return noCustomer;
            }
            else if (weather.weatherForecast[weather.forecast] == weather.weatherForecast[5])
            {
                noCustomer = random.Next(1, 30);
                return noCustomer;
            }
            else
            {
                return default(int);
            }
        }

        public void AddCustomers(int noCustomers, Random random)
        {
            for (int i = 0; i < noCustomers; i++)
            {
                customer.potentialCustomer.Add(new Customer(random.Next(0,4)));
            }
        }
        
    }
}
