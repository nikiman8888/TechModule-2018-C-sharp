using System;
using System.Globalization;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Numerics;

namespace _02.FromLeftToTheRight
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            int numberCount = int.Parse(Console.ReadLine());

            long sum = 0;           

            for (int i = 0; i < numberCount; i++)
            {
                string[] numbers = Console.ReadLine().Split(' ');

                string firstNumber = numbers[0];

                string secondNumber = numbers[1];

                long first = long.Parse(firstNumber);

                long second = long.Parse(secondNumber);

                if (first > second)
                {
                    sum = GetDigits(first);
                }
                else
                {
                    sum = GetDigits(second);
                }

                Console.WriteLine(sum);
            }
        }
        private static long GetDigits(long number)
        {
            long temp = 0;
                        
                while (number != 0)
                {
                                      
                    temp += Math.Abs(number % 10);

                    number /= 10;
                }
                       
            return temp;
        }                                       
    }
}
