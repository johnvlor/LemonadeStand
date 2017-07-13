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
            
            Console.WriteLine("Cups of lemonade to make?");
            qty = Int32.Parse(Console.ReadLine());

            int remove = Math.Min(playerOne.inventory.cup.cups.Count, qty);
            playerOne.inventory.cup.cups.RemoveRange(0, remove);

        }

        public void UseLemons(Player playerOne)
        {
            
            Console.WriteLine("Lemons to use?");
            qty = Int32.Parse(Console.ReadLine());

            int remove = Math.Min(playerOne.inventory.lemon.lemons.Count, qty);
            playerOne.inventory.lemon.lemons.RemoveRange(0, remove);

        }

        public void UseSugar(Player playerOne)
        {
            
            Console.WriteLine("Cups of Sugar to use?");
            qty = Int32.Parse(Console.ReadLine());

            int remove = Math.Min(playerOne.inventory.sugar.sugar.Count, qty);
            playerOne.inventory.sugar.sugar.RemoveRange(0, remove);

        }

        public void UseIceCubes(Player playerOne)
        {
            
            Console.WriteLine("Ice Cubes to use?");
            qty = Int32.Parse(Console.ReadLine());

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
    }
}
