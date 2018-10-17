using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Threading;


namespace _01.SmallestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());

            int secondNumber = int.Parse(Console.ReadLine());

            int thirdNumber = int.Parse(Console.ReadLine());

            int firstPairSmallest = GetSmallest(firstNumber, secondNumber);

            int result = GetSmallest(firstPairSmallest, thirdNumber);

            Console.WriteLine(result);
        }

        private static int GetSmallest(int firstNumber, int secondNumber)
        {
            return Math.Min(firstNumber, secondNumber);
        }
    }
}
