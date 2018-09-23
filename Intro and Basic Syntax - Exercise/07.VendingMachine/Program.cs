using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _07.VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputCoins = Console.ReadLine();

            decimal sum = 0M;

            decimal[] validCoins = new decimal[] {0.1M, 0.2M, 0.5M, 1M, 2M };

            while (inputCoins != "Start")
            {
                decimal currentCoin = decimal.Parse(inputCoins, NumberFormatInfo.InvariantInfo);

                if (validCoins.Contains(currentCoin))
                {
                    sum += currentCoin;
                }
                else
                {
                    Console.WriteLine("Cannot accept {0}",currentCoin);
                }

                inputCoins = Console.ReadLine();
            }
            var products = new Dictionary<string, decimal>()
            {
                { "Nuts",2.0M },
                {"Water", 0.7M},
                {"Crisps",1.5M},
                {"Soda", 0.8M},
                {"Coke", 1.0M}

            };
            string enterProduct = Console.ReadLine();

            while(enterProduct != "End")
            {

                if (!products.ContainsKey(enterProduct))
                {
                    Console.WriteLine("Invalid product");

                    enterProduct = Console.ReadLine();

                    continue;
                }
                if(products[enterProduct] <= sum)
                {
                    Console.WriteLine("Purchased {0}",enterProduct.ToLower());

                    sum -= products[enterProduct];
                }
                else
                {
                    Console.WriteLine("Sorry, not enough money");
                }

                enterProduct = Console.ReadLine();
            }
            Console.WriteLine("Change: {0:F2}",sum);
            
        }
    }
}
