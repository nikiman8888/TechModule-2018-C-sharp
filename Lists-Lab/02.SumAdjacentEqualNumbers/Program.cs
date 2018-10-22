using System;
using System.Globalization;
using System.Threading;
using System.Collections.Generic;
using System.Linq;

namespace _02.SumAdjacentEqualNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            List<double> input = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            

            if (input.Count > 1)
            {
                for (int i = 0; i < input.Count; i++)
                {
                    if (i == input.Count - 1)
                    {
                        break;
                    }
                    double currentNumber = input[i];
                    double nextNumber = input[i + 1];

                    if (currentNumber == nextNumber)
                    {
                        input[i] += nextNumber;

                        input.RemoveAt(i + 1);

                        i = -1;
                    }
                }
                Console.WriteLine(string.Join(" ", input));
            }
            else
            {
                Console.WriteLine(string.Join(" ", input));
            }
            
            
        }
    }
}
