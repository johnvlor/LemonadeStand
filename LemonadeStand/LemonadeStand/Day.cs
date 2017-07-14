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
        int probability;
        int willingToBuy;
        int count;

        public Day()
        {
            weather = new Weather();
            customer = new Customer();
            day = 1;
            customerQty = 0;
            probability = 0;
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
            GetDay();
            GetCustomers(random);
            
        }

        public void GetCustomers(Random random)
        {
            customerQty = random.Next(100);
            AddCustomers(random);
        }

        public void AddCustomers(Random random)
        {
            for (int i = 0; i < customerQty; i++)
            {
                //probability = random.Next(1, 6);
                customer.customer.Add(new Customer());
            }
        }

        public void SellLemonade(Player playerOne, Random random)
        {
            //probability = random.Next(100);

            //if (probability >= 80)
            //{
                for (int i = 0; i < customer.customer.Count; i++)
                {
                    willingToBuy = random.Next(10);

                    if (willingToBuy >= 5)
                    {
                        playerOne.lemonade.cupsOfLemonade.RemoveAt(1);
                        playerOne.Profit = playerOne.Profit + playerOne.lemonade.LemonadePrice;
                        count += 1;
                    }   
                }
            //}
            Console.WriteLine("Lemonade Sold: "+ count);
        }

        public void PricePreference()
        {
            
        }
    }
}
