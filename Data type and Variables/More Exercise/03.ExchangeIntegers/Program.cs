using System;
using System.Globalization;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03.ExchangeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());

            int secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Before:");
            Console.WriteLine($"a = {firstNumber}");
            Console.WriteLine($"b = {secondNumber}");

            int saveFirst = firstNumber;

            firstNumber = secondNumber;

            secondNumber = saveFirst;

            Console.WriteLine("After:");
            Console.WriteLine($"a = {firstNumber}");
            Console.WriteLine($"b = {secondNumber}");
        }
    }
}
