using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Numerics;

namespace _06.SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int sum = 0;

            int[] arr = { 7, 11, 5 };

            for (int i = 1; i <= number; i++)
            {
                int current = i;
                while(current > 0)
                {
                    int currentDigit = current % 10;

                    sum += currentDigit; 

                    current /= 10;
                }
                if (arr.Contains(sum))
                {
                    Console.WriteLine("{0} -> True",i);
                }
                else
                {
                    Console.WriteLine("{0} -> False",i);
                }
                sum = 0;
            }
        }
    }
}
