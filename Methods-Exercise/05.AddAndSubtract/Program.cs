using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Threading;
using System.Text.RegularExpressions;

namespace _05.AddAndSubtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());

            int secondNumber = int.Parse(Console.ReadLine());

            int thirdNumber = int.Parse(Console.ReadLine());

            int sum = GetSum(firstNumber ,secondNumber);

            int result = GetSubstract(sum, thirdNumber);

            Console.WriteLine(result);
        }

        private static int GetSubstract(int sum, int thirdNumber)
        {
            return sum - thirdNumber;
        }

        private static int GetSum(int first,int second)
        {
            return first + second;
        }
    }
}
