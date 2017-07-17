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

        public void AddCups(int purchaseQty)
        {
            for (int i = 0; i < purchaseQty; i++)
            {
                cup.cups.Add(new Cup());
            }
        }

        public void AddLemons(int purchaseQty)
        {
            for (int i = 0; i < purchaseQty; i++)
            {
                lemon.lemons.Add(new Lemon());
            }
        }

        public void AddSugar(int purchaseQty)
        {
            for (int i = 0; i < purchaseQty; i++)
            {
                sugar.sugar.Add(new Sugar());
            }
        }

        public void AddIceCubes(int purchaseQty)
        {
            for (int i = 0; i < purchaseQty; i++)
            {
                iceCubes.iceCubes.Add(new IceCube());
            }
        }
    }
}
