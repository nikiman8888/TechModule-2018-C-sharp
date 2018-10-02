using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _05.PoundsToDollars
{
    class Program
    {
        static void Main(string[] args)
        {
            double inputPounds = double.Parse(Console.ReadLine(), NumberFormatInfo.InvariantInfo);

            double result = inputPounds * 1.31;

            Console.WriteLine("{0:F3}",result);
        }
    }
}
