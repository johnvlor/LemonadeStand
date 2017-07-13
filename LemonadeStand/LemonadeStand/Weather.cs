using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Weather
    {
        Random random;
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

        public void DisplayWeather()
        {
            GetWeatherForecast();
            GetTemperature();
        }

        public void GetWeatherForecast()
        {
            random = new Random();
            forecast = random.Next(6);
            Console.WriteLine("\nWeather Forecast: {0}", weatherForecast[forecast]);
        }

        public void GetTemperature()
        {
            switch(forecast)
            {
                case 0:
                    random = new Random();
                    temperature = random.Next(80, 111);
                    break;
                case 1:
                    random = new Random();
                    temperature = random.Next(70, 90);
                    break;
                case 2:
                    random = new Random();
                    temperature = random.Next(60, 80);
                    break;
                case 3:
                    random = new Random();
                    temperature = random.Next(50, 70);
                    break;
                case 4:
                    random = new Random();
                    temperature = random.Next(40, 60);
                    break;
                case 5:
                    random = new Random();
                    temperature = random.Next(40, 60);
                    break;
                default:
                    break;
            }
            Console.WriteLine("Temperature: {0} degrees", temperature);
        }
    }
}
