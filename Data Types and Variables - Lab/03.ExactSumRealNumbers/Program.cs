using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Numerics;

namespace _03.ExactSumRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersCount = int.Parse(Console.ReadLine());

            decimal totalSum = 0M;

            for (int i = 0; i < numbersCount; i++)
            {
                decimal currentNumber = decimal.Parse(Console.ReadLine(), NumberFormatInfo.InvariantInfo);

                totalSum += currentNumber;
            }
            Console.WriteLine(totalSum);
        }
    }
}
