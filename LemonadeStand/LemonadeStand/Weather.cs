using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Weather
    {
        int forecast;
        int temperature;
        List<string> weatherForecast;

        public Weather()
        {
            weatherForecast = new List<string>()
            {
                "Sunny & Hot",
                "Sunny & Clear",
                "Humid & Warm",
                "Hazy & Overcast",
                "Raining & Cold",
                "Thunderstorm",
            };
            forecast = 0;
        }

        public void DisplayWeather(Random random)
        {
            GetWeatherForecast(random);
            GetTemperature(random);
        }

        public void GetWeatherForecast(Random random)
        {
            forecast = random.Next(6);
            Console.WriteLine("\nWeather Forecast: {0}", weatherForecast[forecast]);
        }

        public void GetTemperature(Random random)
        {
            switch(forecast)
            {
                case 0:
                    temperature = random.Next(80, 111);
                    break;
                case 1:
                    temperature = random.Next(70, 90);
                    break;
                case 2:
                    temperature = random.Next(60, 80);
                    break;
                case 3:
                    temperature = random.Next(50, 70);
                    break;
                case 4:
                    temperature = random.Next(40, 60);
                    break;
                case 5:
                    temperature = random.Next(40, 60);
                    break;
                default:
                    break;
            }
            Console.WriteLine("Temperature: {0} degrees", temperature);
        }
    }
}
