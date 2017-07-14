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
        private Rule rules;
        private Day day;
        public Store store;
        Random random;

        public Game()
        {
            rules = new Rule();
            day = new Day();
            random = new Random();
            store = new Store();
        }

        public void PlayGame()
        {
            rules.GetRules();
            GetPlayer();
            day.GetTodaysWeather(random);
            day.StartDay(random);
            playerOne.DisplayMoney();
            playerOne.inventory.CheckInventory();

            BuyInventory();

            playerOne.MakeLemonade();
            playerOne.inventory.CheckInventory();
            playerOne.lemonade.DisplayCupsOfLemonade();

            playerOne.lemonade.SetLemonadePrice();
            day.SellLemonade(playerOne, random);
            day.customer.DisplayCustomers();
            playerOne.lemonade.DisplayCupsOfLemonade();
            playerOne.DisplayMoney();
            UserInterface.DisplayProfit(playerOne);
            playerOne.inventory.CheckInventory();
        }

        public void GetPlayer()
        {
            playerOne = new Human("player one");
        }

        public void BuyInventory()
        {
            string playerInput = "";
            
            while (playerInput != "done")
            {
                Console.WriteLine("\nWhat would you like to buy? Input 'done' when finished.");
                playerInput = Console.ReadLine();

                switch (playerInput)
                {
                    case "cups":
                        store.DisplayPriceOfCups();
                        store.BuyCups(playerOne);
                        playerOne.DisplayMoney();
                        playerOne.inventory.CheckInventory();
                        break;
                    case "lemons":
                        store.DisplayPriceOfLemons();
                        store.BuyLemons(playerOne);
                        playerOne.DisplayMoney();
                        playerOne.inventory.CheckInventory();
                        break;
                    case "sugar":
                        store.DisplayPriceOfSugar();
                        store.BuySugar(playerOne);
                        playerOne.DisplayMoney();
                        playerOne.inventory.CheckInventory();
                        break;
                    case "ice cubes":
                        store.DisplayPriceOfIceCubes();
                        store.BuyIceCubes(playerOne);
                        playerOne.DisplayMoney();
                        playerOne.inventory.CheckInventory();
                        break;
                    case "done":
                        break;
                    default:
                        Console.WriteLine("Invalid choice.  Please try again.");
                        BuyInventory();
                        break;
                }
            }
        }


    }
}
