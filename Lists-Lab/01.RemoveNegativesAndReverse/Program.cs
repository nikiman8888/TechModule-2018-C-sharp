using System;
using System.Globalization;
using System.Threading;
using System.Collections.Generic;
using System.Linq;

namespace _01.RemoveNegativesAndReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            input = input.Where(x => x >= 0).Reverse().ToList();

            if (input.Count == 0)
            {
                Console.WriteLine("empty");
                return;
            }
            Console.WriteLine(string.Join(" ",input));
        }
    }
}
