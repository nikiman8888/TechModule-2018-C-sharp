using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _06.StrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int factorialSum = 0;

            int saveNumber = number;

            while(saveNumber > 0)
            {
                int currentDigit = saveNumber % 10;

                factorialSum += FactorilDigit(currentDigit);

                saveNumber /= 10;
            }
            if(factorialSum == number)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }

        private static int FactorilDigit(int currentDigit)
        {
            int tempFactorial = 1;

            for (int i = 1; i <= currentDigit; i++)
            {
                tempFactorial *= i;
            }
            return tempFactorial;
        }
    }
}
