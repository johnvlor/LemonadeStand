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

        public void BuyCups(Player playerOne)
        {
            Console.WriteLine("How many would you like to buy?");
            purchaseQty = Int32.Parse(Console.ReadLine());

            if (purchaseQty < 15)
            {
                playerOne.inventory.AddCups(purchaseQty);
                playerOne.Money = playerOne.Money - (purchaseQty * .05m);
                playerOne.Expense = playerOne.Expense + (purchaseQty * .05m);
            }
            else if ((purchaseQty >= 15) && (purchaseQty < 30))
            {
                playerOne.inventory.AddCups(purchaseQty);
                playerOne.Money = playerOne.Money - (purchaseQty * .04m);
                playerOne.Expense = playerOne.Expense + (purchaseQty * .04m);
            }
            else if (purchaseQty >= 30)
            {
                playerOne.inventory.AddCups(purchaseQty);
                playerOne.Money = playerOne.Money - (purchaseQty * .03m);
                playerOne.Expense = playerOne.Expense + (purchaseQty * .03m);
            }
        }

        public void DisplayPriceOfLemons()
        {
            Console.WriteLine("\nLemons");
            Console.WriteLine("1 for $0.10 each");
            Console.WriteLine("15 or more for $0.07 each");
            Console.WriteLine("30 or more for $0.05 each");
        }

        public void BuyLemons(Player playerOne)
        {
            Console.WriteLine("How many would you like to buy?");
            purchaseQty = Int32.Parse(Console.ReadLine());

            if (purchaseQty < 15)
            {
                playerOne.inventory.AddLemons(purchaseQty);
                playerOne.Money = playerOne.Money - (purchaseQty * .10m);
                playerOne.Expense = playerOne.Expense + (purchaseQty * .10m);
            }
            else if ((purchaseQty >= 15) && (purchaseQty < 30))
            {
                playerOne.inventory.AddLemons(purchaseQty);
                playerOne.Money = playerOne.Money - (purchaseQty * .07m);
                playerOne.Expense = playerOne.Expense + (purchaseQty * .07m);
            }
            else if (purchaseQty > 30)
            {
                playerOne.inventory.AddLemons(purchaseQty);
                playerOne.Money = playerOne.Money - (purchaseQty * .05m);
                playerOne.Expense = playerOne.Expense + (purchaseQty * .05m);
            }

        }

        public void DisplayPriceOfSugar()
        {
            Console.WriteLine("\nSugar");
            Console.WriteLine("1 cup for $0.06 each");
            Console.WriteLine("10 cups or more for $0.05 each");
            Console.WriteLine("20 cups or more for $0.04 each");
        }

        public void BuySugar(Player playerOne)
        {
            Console.WriteLine("How many would you like to buy?");
            purchaseQty = Int32.Parse(Console.ReadLine());

            if (purchaseQty < 10)
            {
                playerOne.inventory.AddSugar(purchaseQty);
                playerOne.Money = playerOne.Money - (purchaseQty * .06m);
                playerOne.Expense = playerOne.Expense + (purchaseQty * .06m);
            }
            else if ((purchaseQty >= 10) && (purchaseQty < 20))
            {
                playerOne.inventory.AddSugar(purchaseQty);
                playerOne.Money = playerOne.Money - (purchaseQty * .05m);
                playerOne.Expense = playerOne.Expense + (purchaseQty * .05m);
            }
            else if (purchaseQty >= 20)
            {
                playerOne.inventory.AddSugar(purchaseQty);
                playerOne.Money = playerOne.Money - (purchaseQty * .04m);
                playerOne.Expense = playerOne.Expense + (purchaseQty * .04m);
            }
        }

        public void DisplayPriceOfIceCubes()
        {
            Console.WriteLine("\nIce Cubes");
            Console.WriteLine("1 for $0.03 each");
            Console.WriteLine("100 or more for $0.02 each");
            Console.WriteLine("200 or more for $0.01 each");
        }

        public void BuyIceCubes(Player playerOne)
        {
            Console.WriteLine("How many would you like to buy?");
            purchaseQty = Int32.Parse(Console.ReadLine());

            if (purchaseQty < 100)
            {
                playerOne.inventory.AddIceCubes(purchaseQty);
                playerOne.Money = playerOne.Money - (purchaseQty * .03m);
                playerOne.Expense = playerOne.Expense + (purchaseQty * .03m);
            }
            else if ((purchaseQty >= 100) && (purchaseQty < 200))
            {
                playerOne.inventory.AddIceCubes(purchaseQty);
                playerOne.Money = playerOne.Money - (purchaseQty * .02m);
                playerOne.Expense = playerOne.Expense + (purchaseQty * .02m);
            }
            else if (purchaseQty >= 200)
            {
                playerOne.inventory.AddIceCubes(purchaseQty);
                playerOne.Money = playerOne.Money - (purchaseQty * .01m);
                playerOne.Expense = playerOne.Expense + (purchaseQty * .01m);
            }
        }

    }
}
