using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace _12.EvenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());

            while (num%2 != 0)
            {
                Console.WriteLine("Please write an even number.");

                num = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("The number is: {0}",Math.Abs(num));

        }
    }
}
