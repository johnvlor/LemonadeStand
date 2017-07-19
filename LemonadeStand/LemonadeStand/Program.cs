using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Program
    {
        static void Main(string[] args)
        {
            Game lemonadeStand = new Game();
            lemonadeStand.PlayGame();

            SqlConnection conn = new SqlConnection("Server=JLOR-ASUS;" + "database=LemonadeStand;" + "Trusted_Connection=true");

            try
            {
                conn.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            SqlCommand command = new SqlCommand("insert into dbo.Player (Name, Wallet_Money, TotalProfit, TotalExpense, TotalNetProfit) Values (@name, @money, @totalprofit, @totalexpense, @totalnetprofit)", conn);
            command.Parameters.Add(new SqlParameter("name", lemonadeStand.playerOne.GetName()));
            command.Parameters.Add(new SqlParameter("money", lemonadeStand.playerOne.wallet.Money));
            command.Parameters.Add(new SqlParameter("totalprofit", lemonadeStand.playerOne.TotalProfit));
            command.Parameters.Add(new SqlParameter("totalexpense", lemonadeStand.playerOne.TotalExpense));
            command.Parameters.Add(new SqlParameter("totalnetprofit", lemonadeStand.playerOne.TotalNetProfit));
            command.ExecuteNonQuery();

            try
            {
                SqlDataReader myReader = null;
                command.CommandText = "select * from dbo.Player";
                myReader = command.ExecuteReader();
                while (myReader.Read())
                {
                    Console.WriteLine(myReader["Name"].ToString());
                    Console.WriteLine(myReader["Wallet_Money"].ToString());
                    Console.WriteLine(myReader["TotalProfit"].ToString());
                    Console.WriteLine(myReader["TotalExpense"].ToString());
                    Console.WriteLine(myReader["TotalNetProfit"].ToString());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            try
            {
                conn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            Console.ReadKey();
        }
    }
}
