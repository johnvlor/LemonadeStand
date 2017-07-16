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
        private Day day;
        public Store store;
        Random random;

        public Game()
        {
            day = new Day(random);
            random = new Random();
            store = new Store();
        }

        public void PlayGame()
        {
            UserInterface.GetRules();
            GetPlayer();
            day.StartDay(random);
            day.GetTodaysWeather(random);
            day.customer.DisplayPotentialCustomers();
            playerOne.DisplayMoney();
            playerOne.inventory.CheckInventory();

            BuyInventory();

            playerOne.DetermineIfUsingRecipe();
            playerOne.inventory.CheckInventory();
            playerOne.lemonade.DisplayCupsOfLemonade();

            playerOne.lemonade.SetLemonadePrice();
            day.SellLemonade(playerOne, random);
            //day.customer.DisplayCustomers();
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
            int playerInput = 0;
            
            while (playerInput != 5)
            {
                Console.Write("\nWhat would you like to buy?" +
                    "\n1. Cups" +
                    "\n2. Lemons" +
                    "\n3. Sugar" +
                    "\n4. Ice cubes" +
                    "\n5. Done with the store" +
                    "\nPlease enter the option here: ");
                playerInput = Int32.Parse(Console.ReadLine());

                switch (playerInput)
                {
                    case 1:
                        store.DisplayPriceOfCups();
                        store.BuyCups(playerOne, playerInput);
                        playerOne.DisplayMoney();
                        playerOne.inventory.CheckInventory();
                        break;
                    case 2:
                        store.DisplayPriceOfLemons();
                        store.BuyLemons(playerOne, playerInput);
                        playerOne.DisplayMoney();
                        playerOne.inventory.CheckInventory();
                        break;
                    case 3:
                        store.DisplayPriceOfSugar();
                        store.BuySugar(playerOne, playerInput);
                        playerOne.DisplayMoney();
                        playerOne.inventory.CheckInventory();
                        break;
                    case 4:
                        store.DisplayPriceOfIceCubes();
                        store.BuyIceCubes(playerOne, playerInput);
                        playerOne.DisplayMoney();
                        playerOne.inventory.CheckInventory();
                        break;
                    case 5:
                        break;
                    default:
                        Console.WriteLine("Invalid choice.  Please enter one of the options provided.");
                        BuyInventory();
                        break;
                }
            }
        }


    }
}
