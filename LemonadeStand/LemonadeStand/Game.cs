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
        public List<Day> gameDays;
        int noDays;

        public Game()
        {
            day = new Day();
            random = new Random();
            store = new Store();
            gameDays = new List<Day>();
            noDays = 7;
        }

        public void PlayGame()
        {
            UserInterface.GetRules();
            GetPlayer();
            GetNumberOfGameDays();

            foreach (Day newGameDays in gameDays)
            {
                Console.WriteLine("\nDay {0}", (gameDays.IndexOf(newGameDays)+1));
                day.StartDay(random);

                UserInterface.DisplayMoney(playerOne);
                playerOne.inventory.CheckInventory();

                store.BuyInventory(playerOne);

                playerOne.MakeLemonade();
                playerOne.lemonade.DisplayCupsOfLemonade();

                playerOne.SetLemonadePrice();
                playerOne.GetLemonadeType();
                day.customer.DisplayPotentialCustomers();
                playerOne.BuyLemonade(day, random);

                Console.WriteLine("\nEnd of Day {0} Report", (gameDays.IndexOf(newGameDays) + 1));
                GetProfit();
                
                //UserInterface.DisplayMoney(playerOne);
                UserInterface.DisplayProfit(playerOne);
                CalculateAccumulatedMoney();
                UserInterface.DisplayMoney(playerOne);
                playerOne.inventory.CheckInventory();
                CalculateTotalRevenue();
                ClearInventory(playerOne);
                ClearCustomers();
                ClearExpense();
            }

            UserInterface.DisplayRevenue(playerOne);
        }

        public void GetPlayer()
        {
            playerOne = new Human("player one");
        }

        public void GetNumberOfGameDays()
        {
            for (int i = 0; i < noDays; i++)
            {
                gameDays.Add(new Day());
            }
        }

        public void GetProfit()
        {
            playerOne.Profit = day.customer.purchasingCustomer.Count * playerOne.lemonade.LemonadePrice;
        }

        public void CalculateTotalRevenue()
        {
            playerOne.TotalRevenue = playerOne.TotalRevenue + playerOne.Profit;
        }

        public void CalculateAccumulatedMoney()
        {
            playerOne.Money = playerOne.Money + playerOne.Profit;
        }

        public void ClearInventory(Player playerOne)
        {
            Console.WriteLine("Ice Cubes have melted");
            playerOne.inventory.iceCubes.iceCubes.Clear();
        }

        public void ClearExpense()
        {
            playerOne.Expense = 0m;
        }

        public void ClearCustomers()
        {
            day.customer.potentialCustomer.Clear();
            day.customer.purchasingCustomer.Clear();
        }

    }
}
