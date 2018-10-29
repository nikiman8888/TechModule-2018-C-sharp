using System;
using System.Globalization;
using System.Threading;
using System.Collections.Generic;
using System.Linq;

namespace _04.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            var productQuanity = new Dictionary<string, int>();
            var productPrice = new Dictionary<string, double>();

            string input = Console.ReadLine();

            while (input != "buy")
            {
                string[] tokens = input.Split(' ').ToArray();

                string currentProduct = tokens[0];
                double currentPrice = double.Parse(tokens[1]);
                int currentQuanity = int.Parse(tokens[2]);

                if (!productQuanity.ContainsKey(currentProduct))
                {
                    productQuanity.Add(currentProduct, 0);
                    productPrice.Add(currentProduct, 0);
                }
                productQuanity[currentProduct] += currentQuanity;
                productPrice[currentProduct] = currentPrice;


                input = Console.ReadLine();
            }
            foreach (var product in productQuanity)
            {
                string name = product.Key;
                double finalSum = product.Value * productPrice[name];
                Console.WriteLine("{0} -> {1:F2}",name,finalSum);
            }
        }
    }
}
