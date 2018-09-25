using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03.GamingStore
{
    class Program
    {
        static void Main(string[] args)
        {

            decimal moneyCash = decimal.Parse(Console.ReadLine(), NumberFormatInfo.InvariantInfo);


            Dictionary<string, decimal> existingGames = new Dictionary<string, decimal>
            {
                { "OutFall 4",39.99M },
                { "CS: OG",15.99M },
                { "Zplinter Zell",19.99M },
                { "Honored 2",59.99M },
                { "RoverWatch",29.99M },
                { "RoverWatch Origins Edition",39.99M }
            };

            decimal totalSpend = 0M;

            string inputProduct = Console.ReadLine();

            while (inputProduct != "Game Time")
            {
                if (existingGames.ContainsKey(inputProduct))
                {
                    decimal currentGamePrice = existingGames[inputProduct];

                    if (currentGamePrice > moneyCash)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        moneyCash -= currentGamePrice;
                        totalSpend += currentGamePrice;

                        Console.WriteLine("Bought {0}",inputProduct);
                    }

                }
                else
                {
                    Console.WriteLine("Not Found");
                }

                if (moneyCash <= 0)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }

                inputProduct = Console.ReadLine();
            }
            Console.WriteLine($"Total spent: ${totalSpend:F2}. Remaining: ${moneyCash:F2}");


        }
    }
}
