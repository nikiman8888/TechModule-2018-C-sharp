using System;
using System.Globalization;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02.CenterPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            double xFirst = double.Parse(Console.ReadLine());

            double yFirst = double.Parse(Console.ReadLine());

            double xSecond = double.Parse(Console.ReadLine());

            double ySecond = double.Parse(Console.ReadLine());

            PrintPoint(xFirst, yFirst, xSecond, ySecond);
        }

        private static void PrintPoint(double xFirst, double yFirst, double xSecond, double ySecond)
        {
            double first = Math.Abs(xFirst) + Math.Abs(yFirst);
            double second = Math.Abs(xSecond) + Math.Abs(ySecond);
            if (first <= second)
            {
                Console.WriteLine($"({xFirst}, {yFirst})");
            }
            else
            {
                Console.WriteLine($"({xSecond}, {ySecond})");
            }
        }
    }
}
