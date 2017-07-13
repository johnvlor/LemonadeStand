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
        Rule rules;
        Day day;
        public Store store = new Store();

        public Game()
        {
            rules = new Rule();
            day = new Day();

        }

        public void PlayGame()
        {
            rules.GetRules();
            GetPlayer();
            day.StartDay();
            playerOne.DisplayMoney();
            playerOne.inventory.CheckInventory();
            BuyInventory(playerOne);
            AdditionalPurchase();
            playerOne.DisplayMoney();
            playerOne.inventory.CheckInventory();

        }

        public void GetPlayer()
        {
            playerOne = new Human("player one");
        }

        public void BuyInventory(Player playerOne)
        {
            string playerInput;
            Console.WriteLine("\nWhat would you like to buy?");
            playerInput = Console.ReadLine();

                switch (playerInput)
                {
                    case "cups":
                        store.DisplayPriceOfCups();
                        store.BuyCups(playerOne);
                        break;
                    case "lemons":
                        store.DisplayPriceOfLemons();
                        store.BuyLemons(playerOne);
                    break;
                    case "sugar":
                        break;
                    case "ice cubes":
                        break;
                    case "done":
                        break;
                    default:
                        BuyInventory(playerOne);
                        break;
                }
        }

        public void AdditionalPurchase()
        {
            string answer;
            Console.WriteLine("Are you done?");
            answer = Console.ReadLine();
            if (answer == "no")
            {
                BuyInventory(playerOne);
            }
            else
            {
                Console.WriteLine("Thank you");
            }
        }


    }
}
