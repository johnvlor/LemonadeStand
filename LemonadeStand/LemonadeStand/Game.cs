using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {
        public Player playerOne;
        public Day day;
        public Store store;
        Random random;

        public Game()
        {
            day = new Day();
            random = new Random();
            store = new Store();
        }

        public void PlayGame()
        {
            UserInterface.GetRules();
            GetPlayer();
            day.StartDay(random);
           //day.GetTodaysWeather(random);
            day.customer.DisplayPotentialCustomers();
            playerOne.DisplayMoney();
            playerOne.inventory.CheckInventory();

            store.BuyInventory(playerOne);

            playerOne.MakeLemonade();
            //playerOne.inventory.CheckInventory();
            playerOne.lemonade.DisplayCupsOfLemonade();

            playerOne.SetLemonadePrice();
            playerOne.GetLemonadeType();
            playerOne.BuyLemonade(day, random);
            //day.customer.DisplayCustomers();
            //playerOne.lemonade.DisplayCupsOfLemonade();
            day.GetDay();
            GetProfit();
            CalculateTotalRevenue();
            playerOne.DisplayMoney();            
            UserInterface.DisplayProfit(playerOne);
            playerOne.inventory.CheckInventory();
        }

        public void GetPlayer()
        {
            playerOne = new Human("player one");
        }

        public void GetProfit()
        {
            playerOne.Profit = day.customer.purchasingCustomer.Count * playerOne.lemonade.LemonadePrice;
        }

        public void CalculateTotalRevenue()
        {
            playerOne.TotalRevenue = playerOne.TotalRevenue + (playerOne.Profit - playerOne.Expense);
        }

    }
}
