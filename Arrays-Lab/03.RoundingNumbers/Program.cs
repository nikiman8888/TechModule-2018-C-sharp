using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace _03.RoundingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            double []array = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("{0} => {1}",array[i], Math.Round(array[i],MidpointRounding.AwayFromZero));
            }
        }
    }
}
