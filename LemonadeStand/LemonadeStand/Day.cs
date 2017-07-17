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
        int day;
        int noCustomer;
        int willingToBuy;
        int count;

        public Day()
        {
            weather = new Weather();
            customer = new Customer(0);
            day = 1;
            noCustomer = 0;
            willingToBuy = 0;
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
            
            GetTodaysWeather(random);
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

            //foreach (Customer x in customer.potentialCustomer)
            //{
            //    Console.WriteLine(x.lemonadeTypePreference);
            //}
        }

        public void SellLemonade(Player playerOne, Random random)
        {

            for (int i = 0; i < customer.potentialCustomer.Count; i++)
            {
                willingToBuy = random.Next(10);

                if (willingToBuy >= 5)
                {
                    //Console.WriteLine(playerOne.lemonade.cupsOfLemonade.Count);
                    playerOne.lemonade.cupsOfLemonade.RemoveAt(0);
                    playerOne.Profit = playerOne.Profit + playerOne.lemonade.LemonadePrice;
                    count += 1;
                } 
                else if (playerOne.lemonade.cupsOfLemonade.Count == 0)
                {
                    Console.WriteLine("Out of Stock");
                    break;
                }
            }
            Console.WriteLine("Cups of Lemonade Sold: "+ count);
        }

        
    }
}
