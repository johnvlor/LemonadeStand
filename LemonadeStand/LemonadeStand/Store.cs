using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Store
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
                AddCups(playerOne);
                playerOne.money = playerOne.money - (purchaseQty * .05m);
            }
            else if ((purchaseQty >= 15) && (purchaseQty < 30))
            {
                AddCups(playerOne);
                playerOne.money = playerOne.money - (purchaseQty * .04m);
            }
            else if (purchaseQty >= 30)
            {
                AddCups(playerOne);
                playerOne.money = playerOne.money - (purchaseQty * .03m);
            }

        }

        public void AddCups(Player playerOne)
        {
            for (int i = 0; i < purchaseQty; i++)
            {
                playerOne.inventory.cup.cups.Add(new Cup());
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
                AddLemons(playerOne);
                playerOne.money = playerOne.money - (purchaseQty * .10m);
            }
            else if ((purchaseQty >= 15) && (purchaseQty < 30))
            {
                AddLemons(playerOne);
                playerOne.money = playerOne.money - (purchaseQty * .07m);
            }
            else if (purchaseQty > 30)
            {
                AddLemons(playerOne);
                playerOne.money = playerOne.money - (purchaseQty * .05m);
            }

        }

        public void AddLemons(Player playerOne)
        {
            for (int i = 0; i < purchaseQty; i++)
            {
                playerOne.inventory.lemon.lemons.Add(new Lemon());
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
                AddSugar(playerOne);
                playerOne.money = playerOne.money - (purchaseQty * .06m);
            }
            else if ((purchaseQty >= 10) && (purchaseQty < 20))
            {
                AddSugar(playerOne);
                playerOne.money = playerOne.money - (purchaseQty * .05m);
            }
            else if (purchaseQty >= 20)
            {
                AddSugar(playerOne);
                playerOne.money = playerOne.money - (purchaseQty * .04m);
            }
        }

        public void AddSugar(Player playerOne)
        {
            for (int i = 0; i < purchaseQty; i++)
            {
                playerOne.inventory.sugar.sugar.Add(new Sugar());
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
                AddIceCubes(playerOne);
                playerOne.money = playerOne.money - (purchaseQty * .03m);
            }
            else if ((purchaseQty >= 100) && (purchaseQty < 200))
            {
                AddIceCubes(playerOne);
                playerOne.money = playerOne.money - (purchaseQty * .02m);
            }
            else if (purchaseQty >= 200)
            {
                AddIceCubes(playerOne);
                playerOne.money = playerOne.money - (purchaseQty * .01m);
            }
        }

        public void AddIceCubes(Player playerOne)
        {
            for (int i = 0; i < purchaseQty; i++)
            {
                playerOne.inventory.iceCubes.iceCubes.Add(new IceCube());
            }
        }
    }
}
