﻿using System;
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
        private decimal netProfit;
        private decimal totalProfit;
        private decimal totalExpense;
        private decimal totalNetProfit;
        public Inventory inventory;
        public Recipe recipe;
        public Lemonade lemonade;

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
            inventory = new Inventory();
            recipe = new Recipe(4, 4, 4, 4);
            lemonade = new Lemonade();
            SetMoney();
        }

        public string GetName()
        {
            return name;
        }

        public void SetMoney()
        {
            money = 15.00m;
            expense = 0m;
            profit = 0m;
        }

        public void MakeLemonadeWithoutRecipe()
        {
            Console.WriteLine("\nHow many cups of lemonade do you want to make?");
            UseCups();
            GetCupsOfLemonade();
            UseLemons();
            UseSugar();
            UseIceCubes();
        }

        public void MakeLemonade()
        {
            string choice;
            Console.WriteLine("\nDo you want to use Grandma's Recipe?  (Yes or No)" +
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

        public void MakeLemonadeWithRecipe(Recipe recipe)
        {
            UseCups();
            GetCupsOfLemonade();
            try
            {
                inventory.lemon.lemons.RemoveRange(0, recipe.LemonQty);
            }
            catch (Exception)
            {
                Console.WriteLine("Not enough Lemons available.");
                UseLemons();
            }
            try
            {
                inventory.sugar.sugar.RemoveRange(0, recipe.SugarQty);
            }
            catch (Exception)
            {
                Console.WriteLine("Not enough Sugar available.");
                UseSugar();
            }
            try
            {
                inventory.iceCubes.iceCubes.RemoveRange(0, recipe.IceCubesQty);
            }
            catch (Exception)
            {
                Console.WriteLine("Not enough Ice Cubes available.");
                UseIceCubes();
            }

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

            try
            {
                inventory.cup.cups.RemoveRange(0, recipe.CupQty);
            }
            catch(Exception)
            {
                Console.WriteLine("Not enough Cups available.");
                UseCups();
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

            try
            {
                inventory.lemon.lemons.RemoveRange(0, recipe.LemonQty);
            }
            catch(Exception)
            {
                Console.WriteLine("Not enough Lemons available.");
                UseLemons();
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

            try
            {
                inventory.sugar.sugar.RemoveRange(0, recipe.SugarQty);
            }
            catch (Exception)
            {
                Console.WriteLine("Not enough Sugar available.");
                UseSugar();
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
            
            try
            {
                inventory.iceCubes.iceCubes.RemoveRange(0, recipe.IceCubesQty);
            }
            catch (Exception)
            {
                Console.WriteLine("Not enough Ice Cubes available.");
                UseIceCubes();
            }
        }

        public void GetCupsOfLemonade()
        {
            for (int i = 0; i < recipe.CupQty; i++)
            {
                lemonade.cupsOfLemonade.Add(new Lemonade());
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

        public int GetLemonadeType()
        {
            if (recipe.LemonQty == recipe.SugarQty)
            {
                lemonade.LemonadeType = 1;
            }
            else if (recipe.LemonQty > recipe.SugarQty)
            {
                lemonade.LemonadeType = 2;
            }
            else if (recipe.LemonQty < recipe.SugarQty)
            {
                lemonade.LemonadeType = 3;
            }
            return lemonade.LemonadeType;
        }

        public void BuyLemonade(Day day, Random random)
        {
            int willBuy = 0;

            foreach (Customer buyingCustomer in day.customer.potentialCustomer)
            {
                if (lemonade.cupsOfLemonade.Count != 0)
                {
                    if ((day.weather.temperature >= 70) && (lemonade.LemonadePrice < .50m) && (buyingCustomer.lemonadeTypePreference == 1))
                    {
                        willBuy = random.Next(0, 11);
                        if (willBuy > 2)
                        {
                            day.customer.purchasingCustomer.Add(buyingCustomer);
                            lemonade.cupsOfLemonade.RemoveAt(0);
                        }
                    }
                    else if ((day.weather.temperature >= 70) && (lemonade.LemonadePrice >= .50m) && (buyingCustomer.lemonadeTypePreference == 1))
                    {
                        willBuy = random.Next(0, 11);
                        if (willBuy > 4)
                        {
                            day.customer.purchasingCustomer.Add(buyingCustomer);
                            lemonade.cupsOfLemonade.RemoveAt(0);
                        }
                    }
                    else if ((day.weather.temperature < 70) && (day.weather.temperature >= 40) && (lemonade.LemonadePrice < .50m) && (buyingCustomer.lemonadeTypePreference == 1))
                    {
                        willBuy = random.Next(0, 11);
                        if (willBuy > 2)
                        {
                            day.customer.purchasingCustomer.Add(buyingCustomer);
                            lemonade.cupsOfLemonade.RemoveAt(0);
                        }
                    }
                    else if ((day.weather.temperature < 70) && (day.weather.temperature >= 40) && (lemonade.LemonadePrice >= .50m) && (buyingCustomer.lemonadeTypePreference == 1))
                    {
                        willBuy = random.Next(0, 11);
                        if (willBuy > 4)
                        {
                            day.customer.purchasingCustomer.Add(buyingCustomer);
                            lemonade.cupsOfLemonade.RemoveAt(0);
                        }
                    }
                    else if ((day.weather.temperature < 40) && (lemonade.LemonadePrice < .50m) && (buyingCustomer.lemonadeTypePreference == 1))
                    {
                        willBuy = random.Next(0, 11);
                        if (willBuy > 4)
                        {
                            day.customer.purchasingCustomer.Add(buyingCustomer);
                            lemonade.cupsOfLemonade.RemoveAt(0);
                        }
                    }
                    else if ((day.weather.temperature < 40) && (lemonade.LemonadePrice >= .50m) && (buyingCustomer.lemonadeTypePreference == 1))
                    {
                        willBuy = random.Next(0, 11);
                        if (willBuy > 6)
                        {
                            day.customer.purchasingCustomer.Add(buyingCustomer);
                            lemonade.cupsOfLemonade.RemoveAt(0);
                        }
                    }
                    else if ((day.weather.temperature >= 70) && (lemonade.LemonadePrice < .50m) && (buyingCustomer.lemonadeTypePreference == 2))
                    {
                        willBuy = random.Next(0, 11);
                        if (willBuy > 2)
                        {
                            day.customer.purchasingCustomer.Add(buyingCustomer);
                            lemonade.cupsOfLemonade.RemoveAt(0);
                        }
                    }
                    else if ((day.weather.temperature >= 70) && (lemonade.LemonadePrice >= .50m) && (buyingCustomer.lemonadeTypePreference == 2))
                    {
                        willBuy = random.Next(0, 11);
                        if (willBuy > 4)
                        {
                            day.customer.purchasingCustomer.Add(buyingCustomer);
                            lemonade.cupsOfLemonade.RemoveAt(0);
                        }
                    }
                    else if ((day.weather.temperature < 70) && (day.weather.temperature >= 40) && (lemonade.LemonadePrice < .50m) && (buyingCustomer.lemonadeTypePreference == 2))
                    {
                        willBuy = random.Next(0, 11);
                        if (willBuy > 3)
                        {
                            day.customer.purchasingCustomer.Add(buyingCustomer);
                            lemonade.cupsOfLemonade.RemoveAt(0);
                        }
                    }
                    else if ((day.weather.temperature < 70) && (day.weather.temperature >= 40) && (lemonade.LemonadePrice >= .50m) && (buyingCustomer.lemonadeTypePreference == 2))
                    {
                        willBuy = random.Next(0, 11);
                        if (willBuy > 5)
                        {
                            day.customer.purchasingCustomer.Add(buyingCustomer);
                            lemonade.cupsOfLemonade.RemoveAt(0);
                        }
                    }
                    else if ((day.weather.temperature < 40) && (lemonade.LemonadePrice < .50m) && (buyingCustomer.lemonadeTypePreference == 2))
                    {
                        willBuy = random.Next(0, 11);
                        if (willBuy > 6)
                        {
                            day.customer.purchasingCustomer.Add(buyingCustomer);
                            lemonade.cupsOfLemonade.RemoveAt(0);
                        }
                    }
                    else if ((day.weather.temperature < 40) && (lemonade.LemonadePrice >= .50m) && (buyingCustomer.lemonadeTypePreference == 2))
                    {
                        willBuy = random.Next(0, 11);
                        if (willBuy > 8)
                        {
                            day.customer.purchasingCustomer.Add(buyingCustomer);
                            lemonade.cupsOfLemonade.RemoveAt(0);
                        }
                    }
                    else if ((day.weather.temperature >= 70) && (lemonade.LemonadePrice < .50m) && (buyingCustomer.lemonadeTypePreference == 3))
                    {
                        willBuy = random.Next(0, 11);
                        if (willBuy > 2)
                        {
                            day.customer.purchasingCustomer.Add(buyingCustomer);
                            lemonade.cupsOfLemonade.RemoveAt(0);
                        }
                    }
                    else if ((day.weather.temperature >= 70) && (lemonade.LemonadePrice >= .50m) && (buyingCustomer.lemonadeTypePreference == 3))
                    {
                        willBuy = random.Next(0, 11);
                        if (willBuy > 4)
                        {
                            day.customer.purchasingCustomer.Add(buyingCustomer);
                            lemonade.cupsOfLemonade.RemoveAt(0);
                        }
                    }
                    else if ((day.weather.temperature < 70) && (day.weather.temperature >= 40) && (lemonade.LemonadePrice < .50m) && (buyingCustomer.lemonadeTypePreference == 3))
                    {
                        willBuy = random.Next(0, 11);
                        if (willBuy > 3)
                        {
                            day.customer.purchasingCustomer.Add(buyingCustomer);
                            lemonade.cupsOfLemonade.RemoveAt(0);
                        }
                    }
                    else if ((day.weather.temperature < 70) && (day.weather.temperature >= 40) && (lemonade.LemonadePrice >= .50m) && (buyingCustomer.lemonadeTypePreference == 3))
                    {
                        willBuy = random.Next(0, 11);
                        if (willBuy > 5)
                        {
                            day.customer.purchasingCustomer.Add(buyingCustomer);
                            lemonade.cupsOfLemonade.RemoveAt(0);
                        }
                    }
                    else if ((day.weather.temperature < 40) && (lemonade.LemonadePrice < .50m) && (buyingCustomer.lemonadeTypePreference == 3))
                    {
                        willBuy = random.Next(0, 11);
                        if (willBuy > 5)
                        {
                            day.customer.purchasingCustomer.Add(buyingCustomer);
                            lemonade.cupsOfLemonade.RemoveAt(0);
                        }
                    }
                    else if ((day.weather.temperature < 40) && (lemonade.LemonadePrice >= .50m) && (buyingCustomer.lemonadeTypePreference == 3))
                    {
                        willBuy = random.Next(0, 11);
                        if (willBuy > 7)
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
            Console.WriteLine("\nCups of Lemonade Sold: " + day.customer.purchasingCustomer.Count);
        }
    }
}
