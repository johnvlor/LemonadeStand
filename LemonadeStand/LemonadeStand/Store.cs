using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Store
    {
        int purchaseQty;
        decimal itemPrice;
        
        public Store()
        {

        }

        public void DisplayPriceOfCups()
        {
            Console.WriteLine("\nCups");
            Console.WriteLine("1 for $0.05 each");
            Console.WriteLine("15 or more for $0.04 each");
            Console.WriteLine("30 or more for $0.03 each");
        }

        public void BuyCups(Player playerOne, int playerInput)
        {
            Console.Write("How many would you like to buy? ");
            purchaseQty = Int32.Parse(Console.ReadLine());

            DeterminePrice(playerOne, playerInput);

            playerOne.inventory.AddCups(purchaseQty);
            playerOne.Money = playerOne.Money - (purchaseQty * itemPrice);
            playerOne.Expense = playerOne.Expense + (purchaseQty * itemPrice);
        }

        public void DisplayPriceOfLemons()
        {
            Console.WriteLine("\nLemons");
            Console.WriteLine("1 for $0.10 each");
            Console.WriteLine("15 or more for $0.07 each");
            Console.WriteLine("30 or more for $0.05 each");
        }

        public void BuyLemons(Player playerOne, int playerInput)
        {
            Console.Write("How many would you like to buy? ");
            purchaseQty = Int32.Parse(Console.ReadLine());

            DeterminePrice(playerOne, playerInput);

            playerOne.inventory.AddLemons(purchaseQty);
            playerOne.Money = playerOne.Money - (purchaseQty * itemPrice);
            playerOne.Expense = playerOne.Expense + (purchaseQty * itemPrice);
        }

        public void DisplayPriceOfSugar()
        {
            Console.WriteLine("\nSugar");
            Console.WriteLine("1 cup for $0.06 each");
            Console.WriteLine("10 cups or more for $0.05 each");
            Console.WriteLine("20 cups or more for $0.04 each");
        }

        public void BuySugar(Player playerOne, int playerInput)
        {
            Console.Write("How many would you like to buy? ");
            purchaseQty = Int32.Parse(Console.ReadLine());

            DeterminePrice(playerOne, playerInput);

            playerOne.inventory.AddSugar(purchaseQty);
            playerOne.Money = playerOne.Money - (purchaseQty * itemPrice);
            playerOne.Expense = playerOne.Expense + (purchaseQty * itemPrice);
        }

        public void DisplayPriceOfIceCubes()
        {
            Console.WriteLine("\nIce Cubes");
            Console.WriteLine("1 for $0.03 each");
            Console.WriteLine("100 or more for $0.02 each");
            Console.WriteLine("200 or more for $0.01 each");
        }

        public void BuyIceCubes(Player playerOne, int playerInput)
        {
            Console.Write("How many would you like to buy? ");
            purchaseQty = Int32.Parse(Console.ReadLine());

            DeterminePrice(playerOne, playerInput);

            playerOne.inventory.AddIceCubes(purchaseQty);
            playerOne.Money = playerOne.Money - (purchaseQty * itemPrice);
            playerOne.Expense = playerOne.Expense + (purchaseQty * itemPrice);
        }

        public decimal DeterminePrice(Player playerOne, int playerInput)
        {
            if (playerInput == 1)
            {
                if (purchaseQty < 15)
                {
                    itemPrice = playerOne.inventory.cup.Price;
                    return itemPrice;
                }
                else if ((purchaseQty >= 15) && (purchaseQty < 30))
                {
                    itemPrice = .04m;
                    return itemPrice;
                }
                else if (purchaseQty >= 30)
                {
                    itemPrice = .03m;
                    return itemPrice;
                }
            }
            else if (playerInput == 2)
            {
                if (purchaseQty < 15)
                {
                    itemPrice = playerOne.inventory.lemon.Price;
                    return itemPrice;
                }
                else if ((purchaseQty >= 15) && (purchaseQty < 30))
                {
                    itemPrice = .07m;
                    return itemPrice;
                }
                else if (purchaseQty >= 30)
                {
                    itemPrice = .05m;
                    return itemPrice;
                }
            }
            else if (playerInput == 3)
            {
                if (purchaseQty < 10)
                {
                    itemPrice = playerOne.inventory.sugar.Price;
                    return itemPrice;
                }
                else if ((purchaseQty >= 10) && (purchaseQty < 20))
                {
                    itemPrice = .05m;
                    return itemPrice;
                }
                else if (purchaseQty >= 20)
                {
                    itemPrice = .04m;
                    return itemPrice;
                }
            }
            else if (playerInput == 4)
            {
                if (purchaseQty < 100)
                {
                    itemPrice = playerOne.inventory.iceCubes.Price;
                    return itemPrice;
                }
                else if ((purchaseQty >= 100) && (purchaseQty < 200))
                {
                    itemPrice = .02m;
                    return itemPrice;
                }
                else if (purchaseQty >= 200)
                {
                    itemPrice = .01m;
                    return itemPrice;
                }
            }
            return default(decimal);
        }
    }
}
