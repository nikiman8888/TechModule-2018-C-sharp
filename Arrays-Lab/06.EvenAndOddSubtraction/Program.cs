using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace _06.EvenAndOddSubtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int evenSum = array.Where(x => x % 2 == 0).Sum();
            int oddSum = array.Where(x => x % 2 != 0).Sum();

            Console.WriteLine(evenSum -  oddSum);
        }
    }
}
