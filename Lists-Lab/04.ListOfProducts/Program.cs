using System;
using System.Globalization;
using System.Threading;
using System.Collections.Generic;
using System.Linq;

namespace _04.ListOfProducts
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = new List<string>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string currentProduct = Console.ReadLine();

                result.Add(currentProduct);
            }
            int position = 1;

            foreach (var product in result.OrderBy(x =>x))
            {
                Console.WriteLine("{0}.{1}",position,product);

                position++;
            }                       
        }
    }
}
