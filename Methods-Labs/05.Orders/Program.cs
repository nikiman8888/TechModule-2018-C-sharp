using System;
using System.Globalization;
using System.Threading;
using System.Collections.Generic;
using System.Linq;

namespace _05.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            string product = Console.ReadLine();

            double quanity = double.Parse(Console.ReadLine());

            PrintResult(product, quanity);
        }

        private static void PrintResult(string product, double quanity)
        {
            double coffeePrice = 1.50;
            double waterPrice = 1.00;
            double cokePrice = 1.40;
            double snacksPrice = 2.00;

            switch (product)
            {
                case "coffee":
                    Console.WriteLine("{0:F2}",coffeePrice * quanity);
                    break;
                case "water":
                    Console.WriteLine("{0:F2}",waterPrice * quanity);
                    break;
                case "coke":
                    Console.WriteLine("{0:F2}",cokePrice * quanity);
                    break;
                case "snacks":
                    Console.WriteLine("{0:F2}",snacksPrice * quanity);
                    break;
                    
            }
        }
    }
}
