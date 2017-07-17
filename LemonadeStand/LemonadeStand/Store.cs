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
        private decimal transactionAmount;

        public decimal TransactionAmount
        {
            get { return transactionAmount; }
            set { transactionAmount = value; }
        }

        public Store()
        {

        }

        public void BuyInventory(Player playerOne)
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
                try
                {
                    playerInput = Int32.Parse(Console.ReadLine());
                }
                catch(FormatException)
                { }

                switch (playerInput)
                {
                    case 1:
                        DisplayPriceOfCups();
                        BuyCups(playerOne, playerInput);
                        UserInterface.DisplayMoney(playerOne);
                        UserInterface.DisplayExpense(playerOne);
                        playerOne.inventory.CheckInventory();
                        break;
                    case 2:
                        DisplayPriceOfLemons();
                        BuyLemons(playerOne, playerInput);
                        UserInterface.DisplayMoney(playerOne);
                        UserInterface.DisplayExpense(playerOne);
                        playerOne.inventory.CheckInventory();
                        break;
                    case 3:
                        DisplayPriceOfSugar();
                        BuySugar(playerOne, playerInput);
                        UserInterface.DisplayMoney(playerOne);
                        UserInterface.DisplayExpense(playerOne);
                        playerOne.inventory.CheckInventory();
                        break;
                    case 4:
                        DisplayPriceOfIceCubes();
                        BuyIceCubes(playerOne, playerInput);
                        UserInterface.DisplayMoney(playerOne);
                        UserInterface.DisplayExpense(playerOne);
                        playerOne.inventory.CheckInventory();
                        break;
                    case 5:
                        Console.WriteLine("Thank you for shopping with us.  Come back again.");
                        break;
                    default:
                        Console.WriteLine("Invalid choice.  Please enter one of the options provided.");
                        BuyInventory(playerOne);
                        return;
                }
            }
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
            try
            {
                purchaseQty = Int32.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input.  Please enter a number.");
                BuyCups(playerOne, playerInput);
                return;
            }

            DeterminePrice(playerOne, playerInput);
            VerifyEnoughMoney(playerOne);
            CalculateBuyingExpense(playerOne);

            playerOne.inventory.AddCups(purchaseQty);

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
            try
            {
                purchaseQty = Int32.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input.  Please enter a number.");
                BuyLemons(playerOne, playerInput);
                return;
            }

            DeterminePrice(playerOne, playerInput);
            VerifyEnoughMoney(playerOne);
            CalculateBuyingExpense(playerOne);

            playerOne.inventory.AddLemons(purchaseQty);

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
            try
            {
                purchaseQty = Int32.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input.  Please enter a number.");
                BuySugar(playerOne, playerInput);
                return;
            }

            DeterminePrice(playerOne, playerInput);
            VerifyEnoughMoney(playerOne);
            CalculateBuyingExpense(playerOne);

            playerOne.inventory.AddSugar(purchaseQty);

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
            try
            {
                purchaseQty = Int32.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input.  Please enter a number.");
                BuyIceCubes(playerOne, playerInput);
                return;
            }

            DeterminePrice(playerOne, playerInput);
            VerifyEnoughMoney(playerOne);
            CalculateBuyingExpense(playerOne);

            playerOne.inventory.AddIceCubes(purchaseQty);
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

        public void VerifyEnoughMoney(Player playerOne)
        {
            TransactionAmount = 0m;

            TransactionAmount = purchaseQty * itemPrice;
            if (TransactionAmount > playerOne.Money)
            {
                Console.WriteLine("Sorry, not enough money.");
                BuyInventory(playerOne);
            }

        }

        private void CalculateBuyingExpense(Player playerOne)
        {
            Console.WriteLine("transaction amount "+TransactionAmount);
            playerOne.Expense = playerOne.Expense + TransactionAmount;
            playerOne.Money = playerOne.Money - TransactionAmount;
        }
    }
}
