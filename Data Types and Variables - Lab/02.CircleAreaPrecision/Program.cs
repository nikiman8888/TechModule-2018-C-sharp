using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Numerics;

namespace _02.CircleAreaPrecision
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius = double.Parse(Console.ReadLine(), NumberFormatInfo.InvariantInfo);

            double formula = Math.PI * (Math.Pow(radius,2));

            Console.WriteLine("{0:F12}",formula);
        }
    }
}
