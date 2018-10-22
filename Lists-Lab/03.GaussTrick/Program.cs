using System;
using System.Globalization;
using System.Threading;
using System.Collections.Generic;
using System.Linq;

namespace _03.GaussTrick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> input = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            for (int i = 0; i < input.Count; i++)
            {
                if (i == input.Count -1)
                {
                    break;
                }
                input[i] += input.Last();
                input.RemoveAt(input.Count - 1);
            }
            Console.WriteLine(string.Join(" ",input));
        }
    }
}
