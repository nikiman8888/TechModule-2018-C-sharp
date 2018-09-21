using System;
using System.Globalization;

namespace _02.Passed
{
    class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine(), NumberFormatInfo.InvariantInfo);

            string result = grade >= 3.00 ? "Passed!" : null;

            Console.WriteLine(result);
        }
    }
}
