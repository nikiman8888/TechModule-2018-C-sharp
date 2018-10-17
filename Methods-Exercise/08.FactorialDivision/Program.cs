using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Threading;
using System.Text.RegularExpressions;

namespace _08.FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());

            int secondNumber = int.Parse(Console.ReadLine());

            double firstFact = GetFactorial(firstNumber);
            double secondFact = GetFactorial(secondNumber);

            double result = firstFact / secondFact;

            Console.WriteLine($"{result:F2}");
        }

        private static double GetFactorial(int firstNumber)
        {
            double temp = 1;
            for (int i = 1; i <= firstNumber; i++)
            {
                temp *= i;
            }
            return temp;
        }
    }
}
