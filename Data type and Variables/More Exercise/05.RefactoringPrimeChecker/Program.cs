using System;
using System.Globalization;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _05.RefactoringPrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int currentNumber = 2; currentNumber <= number; currentNumber++)
            {
                bool isPrime = true;

                for (int currentDevider = 2; currentDevider < currentNumber; currentDevider++)
                {
                    if (currentNumber % currentDevider == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                Console.WriteLine($"{currentNumber} -> {isPrime.ToString().ToLower()}");
            }

        }
    }
}
