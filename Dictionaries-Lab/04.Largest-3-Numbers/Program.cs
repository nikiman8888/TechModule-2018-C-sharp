using System;
using System.Globalization;
using System.Threading;
using System.Collections.Generic;
using System.Linq;

namespace _04.Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            input = input.OrderByDescending(x => x).Take(3).ToList();

            Console.WriteLine(string.Join(" ",input));
        }
    }
}
