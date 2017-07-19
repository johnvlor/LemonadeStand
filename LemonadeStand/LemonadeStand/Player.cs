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
        private decimal expense;
        private decimal profit;
        private decimal netProfit;
        private decimal totalProfit;
        private decimal totalExpense;
        private decimal totalNetProfit;
        public Wallet wallet;
        public Inventory inventory;
        public Recipe recipe;
        public Lemonade lemonade;

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

        public decimal TotalProfit
        {
            get { return totalProfit; }
            set { totalProfit = value; }
        }

        public decimal TotalExpense
        {
            get { return totalExpense; }
            set { totalExpense = value; }
        }

        public decimal NetProfit
        {
            get { return netProfit; }
            set { netProfit = value; }
        }

        public decimal TotalNetProfit
        {
            get { return totalNetProfit; }
            set { totalNetProfit = value; }
        }

        public Player()
        {
            wallet = new Wallet();
            inventory = new Inventory();
            recipe = new Recipe(4, 4, 4, 4);
            lemonade = new Lemonade();
            expense = 0m;
            profit = 0m;
        }

        public string GetName()
        {
            return name;
        }

        public void MakeLemonade()
        {
            string choice;
            Console.WriteLine("\nLet's make some Lemonade.");
            Console.WriteLine("Do you want to use Grandma's Recipe?  (Yes or No)" +
                "\nYes - use the recipe" +
                "\nNo - make your own");
            choice = Console.ReadLine().ToLower();

            if (choice == "yes")
            {
                MakeLemonadeWithRecipe(recipe);
            }
            else if (choice == "no")
            {
                MakeLemonadeWithoutRecipe();
            }
            else
            {
                Console.WriteLine("Please try again.  Please enter only 'yes' or 'no'.");
                MakeLemonade();
            }           
        }

        public void MakeLemonadeWithoutRecipe()
        {
            Console.WriteLine("\nHow many cups of lemonade do you want to make?");
            UseCups();           
            UseLemons();
            UseSugar();
            UseIceCubes();
            lemonade.AddCupsOfLemonade(recipe);
            lemonade.GetLemonadeType(recipe);
        }

        public void MakeLemonadeWithRecipe(Recipe recipe)
        {
            UseCups();
            VerifyLemonsQty();
            VerifySugarQty();
            VerifyIceCubesQty();
            lemonade.AddCupsOfLemonade(recipe);
            lemonade.GetLemonadeType(recipe);
        }

        public void UseCups()
        {
            Console.Write("Cups of lemonade to make? ");
            try
            {
                recipe.CupQty = Int32.Parse(Console.ReadLine());
            }
            catch(FormatException)
            {
                Console.WriteLine("Invalid input.  Please enter a number.");
                UseCups();
                return;
            }
            VerifyCupsQty();
        }

        public void VerifyCupsQty()
        {
            if (recipe.CupQty > inventory.cup.cups.Count)
            {
                Console.WriteLine("Not enough Lemons available.");
                UseCups();
            }
            else
            {
                inventory.RemoveCups(recipe);
            }
        }

        public void UseLemons()
        {
            Console.Write("Lemons to use? ");
            try
            {
                recipe.LemonQty = Int32.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input.  Please enter a number.");
                UseLemons();
                return;
            }
            VerifyLemonsQty();
        }

        public void VerifyLemonsQty()
        {
            if (recipe.LemonQty > inventory.lemon.lemons.Count)
            {
                Console.WriteLine("Not enough Lemons available.");
                UseLemons();
            }
            else
            {
                inventory.RemoveLemons(recipe);
            }
        }

        public void UseSugar()
        {
            Console.Write("Cups of Sugar to use? ");
            try
            {
                recipe.SugarQty = Int32.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input.  Please enter a number.");
                UseSugar();
                return;
            }
            VerifySugarQty();
        }

        public void VerifySugarQty()
        {
            if (recipe.SugarQty > inventory.sugar.sugar.Count)
            {
                Console.WriteLine("Not enough Lemons available.");
                UseSugar();
            }
            else
            {
                inventory.RemoveSugar(recipe);
            }
        }

        public void UseIceCubes()
        {
            Console.Write("Ice Cubes to use? ");
            try
            {
                recipe.IceCubesQty = Int32.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input.  Please enter a number.");
                UseIceCubes();
                return;
            }
            VerifyIceCubesQty();
        }

        public void VerifyIceCubesQty()
        {
            if (recipe.IceCubesQty > inventory.iceCubes.iceCubes.Count)
            {
                Console.WriteLine("Not enough Lemons available.");
                UseIceCubes();
            }
            else
            {
                inventory.RemoveIceCubes(recipe);
            }
        }

        public void SetLemonadePrice()
        {
            Console.Write("\nSet your price per cup of lemonade: $");
            try
            {
                lemonade.LemonadePrice = Convert.ToDecimal(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Not a valid input.  Please enter a price (ie. 1.00, .50, .25)");
                SetLemonadePrice();
                return;
            }
        }

        public void BuyLemonade(Day day, Random random)
        {
            int willBuy = 0;

            foreach (Customer buyingCustomer in day.customer.potentialCustomer)
            {
                willBuy = random.Next(1, 11);

                if (lemonade.cupsOfLemonade.Count != 0)
                {
                    if ((day.weather.temperature >= 70) && (lemonade.LemonadePrice < .50m) && (lemonade.LemonadeType == buyingCustomer.lemonadeTypePreference))
                    {
                        day.customer.purchasingCustomer.Add(buyingCustomer);
                        lemonade.cupsOfLemonade.RemoveAt(0);
                    }
                    else if ((day.weather.temperature >= 70) && (lemonade.LemonadePrice >= .50m) && (lemonade.LemonadeType == buyingCustomer.lemonadeTypePreference))
                    {
                        if (willBuy > 3)
                        {
                            day.customer.purchasingCustomer.Add(buyingCustomer);
                            lemonade.cupsOfLemonade.RemoveAt(0);
                        }
                    }
                    else if ((day.weather.temperature < 70) && (day.weather.temperature >= 40) && (lemonade.LemonadePrice < .50m) && (lemonade.LemonadeType == buyingCustomer.lemonadeTypePreference))
                    {
                        if (willBuy > 2)
                        {
                            day.customer.purchasingCustomer.Add(buyingCustomer);
                            lemonade.cupsOfLemonade.RemoveAt(0);
                        }
                    }
                    else if ((day.weather.temperature < 70) && (day.weather.temperature >= 40) && (lemonade.LemonadePrice >= .50m) && (lemonade.LemonadeType == buyingCustomer.lemonadeTypePreference))
                    {
                        if (willBuy > 3)
                        {
                            day.customer.purchasingCustomer.Add(buyingCustomer);
                            lemonade.cupsOfLemonade.RemoveAt(0);
                        }
                    }
                    else if ((day.weather.temperature < 40) && (lemonade.LemonadePrice < .50m) && (lemonade.LemonadeType == buyingCustomer.lemonadeTypePreference))
                    {
                        if (willBuy > 4)
                        {
                            day.customer.purchasingCustomer.Add(buyingCustomer);
                            lemonade.cupsOfLemonade.RemoveAt(0);
                        }
                    }
                    else if ((day.weather.temperature < 40) && (lemonade.LemonadePrice >= .50m) && (lemonade.LemonadeType == buyingCustomer.lemonadeTypePreference))
                    {
                        if (willBuy > 6)
                        {
                            day.customer.purchasingCustomer.Add(buyingCustomer);
                            lemonade.cupsOfLemonade.RemoveAt(0);
                        }
                    }
                    else if ((day.weather.temperature >= 70) && (lemonade.LemonadePrice < .50m) && (recipe.IceCubesQty >= 6))
                    {
                        if (willBuy > 5)
                        {
                            day.customer.purchasingCustomer.Add(buyingCustomer);
                            lemonade.cupsOfLemonade.RemoveAt(0);
                        }
                    }
                    else if ((day.weather.temperature >= 70) && (lemonade.LemonadePrice < .40m))
                    {
                        if (willBuy > 5)
                        {
                            day.customer.purchasingCustomer.Add(buyingCustomer);
                            lemonade.cupsOfLemonade.RemoveAt(0);
                        }
                    }
                }
                else if (lemonade.cupsOfLemonade.Count == 0)
                {
                    Console.WriteLine("\nSold Out for today");
                    break;
                }
            }
            DisplayLemonadeSold(day);
        }

        public void DisplayLemonadeSold(Day day)
        {
            Console.WriteLine("Cups of Lemonade Sold: " + day.customer.purchasingCustomer.Count);
        }
    }
}
