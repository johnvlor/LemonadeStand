using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Player
    {
        protected string name;
        private decimal money;
        private decimal expense;
        private decimal profit;
        public Inventory inventory;
        public Recipe recipe;
        public Lemonade lemonade;
        public int qty;

        public decimal Money
        {
            get { return money; }
            set { money = value; }
        }

        public decimal Expense
        {
            get { return expense; }
            set { expense = value; }
        }

        public decimal Profit
        {
            get { return profit; }            
            set { profit = value; }
        }

        public Player()
        {
            inventory = new Inventory();
            recipe = new Recipe(4, 4, 4, 4);
            lemonade = new Lemonade();
            SetMoney();
        }

        public string GetName()
        {
            return name;
        }

        public void DisplayMoney()
        {
            Console.WriteLine();
            Console.WriteLine("Money: ${0}", Money);
            Console.WriteLine("Expense: ${0}", Expense);
        }

        public void SetMoney()
        {
            money = 20.00m;
            expense = 0m;
            profit = 0m;
        }

        public void MakeLemonade()
        {
            Console.WriteLine("\nHow many cups of lemonade do you want to make?");
            UseCups();
            GetCupsOfLemonade();
            UseLemons();
            UseSugar();
            UseIceCubes();
        }

        public void UseCups()
        {
            Console.Write("Cups of lemonade to make? ");
            qty = Int32.Parse(Console.ReadLine());

            CheckCupsInventory();

            inventory.cup.cups.RemoveRange(0, qty);

        }

        public void UseLemons()
        {
            Console.Write("Lemons to use? ");
            qty = Int32.Parse(Console.ReadLine());

            CheckLemonsInventory();

            inventory.lemon.lemons.RemoveRange(0, qty);
        }

        public void UseSugar()
        {
            Console.Write("Cups of Sugar to use? ");
            qty = Int32.Parse(Console.ReadLine());

            CheckSugarInventory();

            inventory.sugar.sugar.RemoveRange(0, qty);
        }

        public void UseIceCubes()
        {
            Console.Write("Ice Cubes to use? ");
            qty = Int32.Parse(Console.ReadLine());

            CheckIceCubesInventory();

            inventory.iceCubes.iceCubes.RemoveRange(0, qty);
        }

        public void GetCupsOfLemonade()
        {
            for (int i = 0; i < qty; i++)
            {
                lemonade.cupsOfLemonade.Add(new Lemonade());
            }
        }

        public void CheckCupsInventory()
        {
            if (qty > inventory.cup.cups.Count)
            {
                Console.WriteLine("Not enough Cups available.");
                qty = 0;
                UseCups();
            }
        }

        public void CheckLemonsInventory()
        {
            if (qty > inventory.lemon.lemons.Count)
            {
                Console.WriteLine("Not enough Lemons available.");
                UseLemons();
            }
        }

        public void CheckSugarInventory()
        {
            if (qty > inventory.sugar.sugar.Count)
            {
                Console.WriteLine("Not enough Sugar available.");
                UseSugar();
            }
        }

        public void CheckIceCubesInventory()
        {
            if (qty > inventory.iceCubes.iceCubes.Count)
            {
                Console.WriteLine("Not enough Ice Cubes available.");
                UseIceCubes();
            }
        }
    }
}
