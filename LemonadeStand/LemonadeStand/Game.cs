using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Game
    {
        public Player playerOne;
        public Day day;
        public Store store;
        Random random;
        public List<Day> gameDays;
        private int noDays;

        public int NoDays
        {
            get { return noDays; }
            set { noDays = value; }
        }

        public Game()
        {
            day = new Day();
            random = new Random();
            store = new Store();
            gameDays = new List<Day>();
            noDays = 2;
        }

        public void PlayGame()
        {
            UserInterface.GetRules();
            GetPlayer();
            GetNumberOfGameDays();

            foreach (Day newGameDays in gameDays)
            {
                Console.WriteLine("\n-----------------------------");
                Console.WriteLine("Day {0}", (gameDays.IndexOf(newGameDays)+1));
                Console.WriteLine("-----------------------------");
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
                Console.WriteLine("\n-----------------------------");
                Console.WriteLine("End of Day {0} Report", (gameDays.IndexOf(newGameDays) + 1));                
                CalculateProfit();                
                UserInterface.DisplayProfit(playerOne);
                UserInterface.DisplayExpense(playerOne);
                CalculateNetProfitLoss();
                CalculateAccumulatedMoney();
                UserInterface.DisplayMoney(playerOne);
                playerOne.inventory.CheckInventory();
                CalculateTotalProfit();
                CalculateTotalExpense();
                ClearInventory(playerOne);
                ClearCustomers();
                ClearRemaningLemonade();
                ClearExpense();
            }

            Console.WriteLine("\n-----------------------------");
            Console.WriteLine("{0}, here's your {1} day game report:", playerOne.GetName(), gameDays.Count);
            UserInterface.DisplayTotalProfit(playerOne);
            UserInterface.DisplayTotalExpense(playerOne);
            CalculateTotalNetProfitLoss();

            PlayAgain();
        }

        public void GetPlayer()
        {
            playerOne = new Human("player one");
        }

        public void GetNumberOfGameDays()
        {
            for (int i = 0; i < NoDays; i++)
            {
                gameDays.Add(new Day());
            }
        }

        public void CalculateProfit()
        {
            playerOne.Profit = day.customer.purchasingCustomer.Count * playerOne.lemonade.LemonadePrice;            
        }

        public void CalculateNetProfitLoss()
        {
            playerOne.NetProfit = playerOne.Profit - playerOne.Expense;

            if (playerOne.NetProfit < 0)
            {
                UserInterface.DisplayNetLoss(playerOne);
            }
            else if (playerOne.NetProfit >= 0)
            {
                UserInterface.DisplayNetProfit(playerOne);
            }
        }

        public void CalculateTotalProfit()
        {
            playerOne.TotalProfit = playerOne.TotalProfit + playerOne.Profit;
        }

        public void CalculateTotalExpense()
        {
            playerOne.TotalExpense = playerOne.TotalExpense + playerOne.Expense;
        }

        public void CalculateAccumulatedMoney()
        {
            playerOne.Money = playerOne.Money + playerOne.Profit;
        }

        public void CalculateTotalNetProfitLoss()
        {            
            playerOne.TotalNetProfit = playerOne.TotalProfit - playerOne.TotalExpense;

            if (playerOne.TotalNetProfit < 0)
            {
                UserInterface.DisplayTotalNetLoss(playerOne);
            }
            else if (playerOne.TotalNetProfit >= 0)
            {
                UserInterface.DisplayTotalNetProfit(playerOne);
            }
        }

        public void ClearInventory(Player playerOne)
        {
            Console.WriteLine("The remaining Ice Cubes have melted");
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

        public void ClearRemaningLemonade()
        {
            playerOne.lemonade.cupsOfLemonade.Clear();
        }
        
        public void ClearDaysToReplay()
        {
            gameDays.Clear();
        }

        public void PlayAgain()
        {
            string userInput;

            Console.WriteLine("\nPlay Again? (Yes or No)");
            userInput = Console.ReadLine().ToLower();

            if (userInput == "yes")
            {
                ClearDaysToReplay();
                Console.Clear();
                PlayGame();
            }
            else
            {
                Console.WriteLine("Have a Nice Day.");
            }
        }
    }
}
