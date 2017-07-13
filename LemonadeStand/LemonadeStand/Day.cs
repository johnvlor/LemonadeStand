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
        public int day;

        public Day()
        {
            weather = new Weather();
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

        public void StartDay()
        {
            GetDay();
            weather.DisplayWeather();



        }

    }
}
