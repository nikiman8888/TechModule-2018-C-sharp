using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _01.SortNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber =int.Parse(Console.ReadLine());

            int secondNumber =int.Parse(Console.ReadLine());

            int thirdumber =int.Parse(Console.ReadLine());

            var result = new List<int>();

            result.Add(firstNumber);
            result.Add(secondNumber);
            result.Add(thirdumber);

            Console.WriteLine(string.Join("\n",result.OrderByDescending(x=>x)));
        }
    }
}
