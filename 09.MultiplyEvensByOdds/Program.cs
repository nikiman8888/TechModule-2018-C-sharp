using System;
using System.Globalization;
using System.Threading;
using System.Collections.Generic;
using System.Linq;

namespace _09.MultiplyEvensByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
         
            int sum = GetSum(number.Replace("-", ""));

            Console.WriteLine( sum);
        }

        private static int GetSum(string number)
        {
            int evenSum = 0;
            int oddSum = 0;

            for (int i = 0; i < number.Length; i++)
            {
                int currentNumber =int.Parse( number[i].ToString());
                if (currentNumber% 2 == 0)
                {
                    evenSum += currentNumber;
                }
                else
                {
                    oddSum += currentNumber;
                }
            }

            return evenSum * oddSum;
        }
    }
}
