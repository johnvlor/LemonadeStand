using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Recipe
    {
        int qty;
        
        public Recipe()
        {
            qty = 0;
        }

        public void MakeLemonade(Player playerOne)
        {
            Console.WriteLine("\nHow many cups of lemonade do you want to make?");
            UseCups(playerOne);
            GetCupsOfLemonade(playerOne);
            UseLemons(playerOne);
            UseSugar(playerOne);
            UseIceCubes(playerOne);
        }

        public void UseCups(Player playerOne)
        {            
            Console.Write("Cups of lemonade to make? ");
            qty = Int32.Parse(Console.ReadLine());

            CheckCupsInventory(playerOne);

            int remove = Math.Min(playerOne.inventory.cup.cups.Count, qty);
            playerOne.inventory.cup.cups.RemoveRange(0, remove);
        }

        public void UseLemons(Player playerOne)
        {            
            Console.Write("Lemons to use? ");
            qty = Int32.Parse(Console.ReadLine());

            CheckLemonsInventory(playerOne);

            int remove = Math.Min(playerOne.inventory.lemon.lemons.Count, qty);
            playerOne.inventory.lemon.lemons.RemoveRange(0, remove);
        }

        public void UseSugar(Player playerOne)
        {           
            Console.Write("Cups of Sugar to use? ");
            qty = Int32.Parse(Console.ReadLine());

            CheckSugarInventory(playerOne);

            int remove = Math.Min(playerOne.inventory.sugar.sugar.Count, qty);
            playerOne.inventory.sugar.sugar.RemoveRange(0, remove);
        }

        public void UseIceCubes(Player playerOne)
        {            
            Console.Write("Ice Cubes to use? ");
            qty = Int32.Parse(Console.ReadLine());

            CheckIceCubesInventory(playerOne);

            int remove = Math.Min(playerOne.inventory.iceCubes.iceCubes.Count, qty);
            playerOne.inventory.iceCubes.iceCubes.RemoveRange(0, remove);
        }

        public void GetCupsOfLemonade(Player playerOne)
        {
            for (int i = 0; i < qty; i++)
            {
                playerOne.lemonade.cupsOfLemonade.Add(new Lemonade());
            }
        }

        public void CheckCupsInventory(Player playerOne)
        {
            if (qty > playerOne.inventory.cup.cups.Count)
            {
                Console.WriteLine("Not enough Cups available.");
                UseCups(playerOne);
            }
        }

        public void CheckLemonsInventory(Player playerOne)
        {
            if (qty > playerOne.inventory.lemon.lemons.Count)
            {
                Console.WriteLine("Not enough Lemons available.");
                UseLemons(playerOne);
            }
        }

        public void CheckSugarInventory(Player playerOne)
        {
            if (qty > playerOne.inventory.sugar.sugar.Count)
            {
                Console.WriteLine("Not enough Sugar available.");
                UseSugar(playerOne);
            }
        }

        public void CheckIceCubesInventory(Player playerOne)
        {
            if (qty > playerOne.inventory.iceCubes.iceCubes.Count)
            {
                Console.WriteLine("Not enough Ice Cubes available.");
                UseIceCubes(playerOne);
            }
        }
    }
}
