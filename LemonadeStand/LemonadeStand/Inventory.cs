using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Inventory
    {
        public Cup cup;
        public Lemon lemon;
        public Sugar sugar;
        public IceCube iceCubes;
        public Player playerOne;

        public Inventory()
        {
            cup = new Cup();
            lemon = new Lemon();
            sugar = new Sugar();
            iceCubes = new IceCube();
        }

        public void CheckInventory()
        {
            Console.WriteLine("\nCurrent Inventory");
            cup.DisplayCups();
            lemon.DisplayLemons();
            sugar.DisplaySugar();
            iceCubes.DisplayIceCubes();           
        }

        public void AddItems(int playerInput, int purchaseQty)
        {
            if (playerInput == 1)
            {
                for (int i = 0; i < purchaseQty; i++)
                {
                    cup.cups.Add(new Cup());
                }
            }
            else if (playerInput == 2)
            {
                for (int i = 0; i < purchaseQty; i++)
                {
                    lemon.lemons.Add(new Lemon());
                }
            }
            else if (playerInput == 3)
            {
                for (int i = 0; i < purchaseQty; i++)
                {
                    sugar.sugar.Add(new Sugar());
                }
            }
            else if (playerInput == 4)
            {
                for (int i = 0; i < purchaseQty; i++)
                {
                    iceCubes.iceCubes.Add(new IceCube());
                }
            }
        }

        public void RemoveCups(Recipe recipe)
        {
            try
            {
                cup.cups.RemoveRange(0, recipe.CupQty);
            }
            catch (Exception)
            {
                Console.WriteLine("Not enough Cups available.");
                playerOne.UseCups();
            }
        }

        public void RemoveLemons(Recipe recipe)
        {
            try
            {
                lemon.lemons.RemoveRange(0, recipe.LemonQty);
            }
            catch (Exception)
            {
                Console.WriteLine("Not enough Lemons available.");
                playerOne.UseLemons();
            }
        }

        public void RemoveSugar(Recipe recipe)
        {
            try
            {
                sugar.sugar.RemoveRange(0, recipe.SugarQty);
            }
            catch (Exception)
            {
                Console.WriteLine("Not enough Sugar available.");
                playerOne.UseSugar();
            }
        }

        public void RemoveIceCubes(Recipe recipe)
        {
            try
            {
                iceCubes.iceCubes.RemoveRange(0, recipe.IceCubesQty);
            }
            catch (Exception)
            {
                Console.WriteLine("Not enough Ice Cubes available.");
                playerOne.UseIceCubes();
            }
        }
    }
}
