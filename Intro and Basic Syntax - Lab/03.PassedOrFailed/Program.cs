using System;
using System.Globalization;

namespace _03.PassedOrFailed
{
    class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine(), NumberFormatInfo.InvariantInfo);

            string result = grade >= 3.00 ? "Passed!" : "Failed!";

            Console.WriteLine(result);
        }
    }
}
