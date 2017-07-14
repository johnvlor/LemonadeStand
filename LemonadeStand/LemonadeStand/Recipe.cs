using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Recipe
    {
        //int qty;
        private int cupQty;
        private int lemonQty;
        private int sugarQty;
        private int iceCubesQty;

        public int CupQty
        {
            get { return cupQty; }
            set { cupQty = value; }
        }

        public int LemonQty
        {
            get { return lemonQty; }
            set { lemonQty = value; }
        }

        public int SugarQty
        {
            get { return sugarQty; }
            set { sugarQty = value; }
        }

        public int IceCubesQty
        {
            get { return iceCubesQty; }
            set { iceCubesQty = value; }
        }

        public Recipe(int cupQty, int lemonQty, int sugarQty, int iceCubesQty)
        {
            //qty = 0;
            this.cupQty = cupQty;
            this.lemonQty = lemonQty;
            this.sugarQty = sugarQty;
            this.iceCubesQty = iceCubesQty;
        }

        //public void MakeLemonade(Player playerOne)
        //{
        //    Console.WriteLine("\nHow many cups of lemonade do you want to make?");
        //    UseCups(playerOne);
        //    GetCupsOfLemonade(playerOne);
        //    UseLemons(playerOne);
        //    UseSugar(playerOne);
        //    UseIceCubes(playerOne);
        //}

        //public void UseCups(Player playerOne)
        //{      
        //    Console.Write("Cups of lemonade to make? ");
        //    qty = Int32.Parse(Console.ReadLine());

        //    CheckCupsInventory(playerOne);
        //    Console.WriteLine("qty " + qty);
        //    playerOne.inventory.cup.cups.RemoveRange(0, qty);

        //}

        //public void UseLemons(Player playerOne)
        //{            
        //    Console.Write("Lemons to use? ");
        //    qty = Int32.Parse(Console.ReadLine());

        //    CheckLemonsInventory(playerOne);

        //    playerOne.inventory.lemon.lemons.RemoveRange(0, qty);
        //}

        //public void UseSugar(Player playerOne)
        //{           
        //    Console.Write("Cups of Sugar to use? ");
        //    qty = Int32.Parse(Console.ReadLine());

        //    CheckSugarInventory(playerOne);

        //    playerOne.inventory.sugar.sugar.RemoveRange(0, qty);
        //}

        //public void UseIceCubes(Player playerOne)
        //{            
        //    Console.Write("Ice Cubes to use? ");
        //    qty = Int32.Parse(Console.ReadLine());

        //    CheckIceCubesInventory(playerOne);

        //    playerOne.inventory.iceCubes.iceCubes.RemoveRange(0, qty);
        //}

        //public void GetCupsOfLemonade(Player playerOne)
        //{
        //    for (int i = 0; i < qty; i++)
        //    {
        //        playerOne.lemonade.cupsOfLemonade.Add(new Lemonade());
        //    }
        //}

        //public void CheckCupsInventory(Player playerOne)
        //{
        //    if (qty > playerOne.inventory.cup.cups.Count)
        //    {
        //        Console.WriteLine("Not enough Cups available.");
        //        qty = 0;
        //        UseCups(playerOne);
        //    }
        //}

        //public void CheckLemonsInventory(Player playerOne)
        //{
        //    if (qty > playerOne.inventory.lemon.lemons.Count)
        //    {
        //        Console.WriteLine("Not enough Lemons available.");
        //        UseLemons(playerOne);
        //    }
        //}

        //public void CheckSugarInventory(Player playerOne)
        //{
        //    if (qty > playerOne.inventory.sugar.sugar.Count)
        //    {
        //        Console.WriteLine("Not enough Sugar available.");
        //        UseSugar(playerOne);
        //    }
        //}

        //public void CheckIceCubesInventory(Player playerOne)
        //{
        //    if (qty > playerOne.inventory.iceCubes.iceCubes.Count)
        //    {
        //        Console.WriteLine("Not enough Ice Cubes available.");
        //        UseIceCubes(playerOne);
        //    }
        //}
    }
}
