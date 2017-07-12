using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {
        Player playerOne;
        Rule rules;
        Day day;
        Weather weather;

        public Game()
        {
            rules = new Rule();
            day = new Day();
            weather = new Weather();
        }

        public void PlayGame()
        {
            rules.GetRules();
            GetPlayer();
            playerOne.DisplayMoney();
            day.GetDay();
            weather.GetWeather();
            weather.GetTemperature();
            
        }

        public void GetPlayer()
        {
            playerOne = new Human("player one");
        }
    }
}
