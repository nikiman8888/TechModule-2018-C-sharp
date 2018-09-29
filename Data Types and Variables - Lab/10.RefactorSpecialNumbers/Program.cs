using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Numerics;

namespace _10.RefactorSpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int sumDigit = 0;                  

            for (int i = 1; i <= num; i++)
            {
                int currentNumber = i;

                while (currentNumber > 0)
                {
                    sumDigit += currentNumber % 10;
                    currentNumber /=  10;
                }
                bool valid = (sumDigit == 5) || (sumDigit == 7) || (sumDigit == 11);

                Console.WriteLine($"{i} -> {valid}");

                sumDigit = 0;
                
            }
        }
    }
}
