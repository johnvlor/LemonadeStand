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
            cup.cups.RemoveRange(0, recipe.CupQty);
        }

        public void RemoveLemons(Recipe recipe)
        {
            lemon.lemons.RemoveRange(0, recipe.LemonQty);
        }

        public void RemoveSugar(Recipe recipe)
        {
            sugar.sugar.RemoveRange(0, recipe.SugarQty);
        }

        public void RemoveIceCubes(Recipe recipe)
        {
            iceCubes.iceCubes.RemoveRange(0, recipe.IceCubesQty);
        }
    }
}
