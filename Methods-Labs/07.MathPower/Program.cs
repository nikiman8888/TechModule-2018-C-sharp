using System;
using System.Globalization;
using System.Threading;
using System.Collections.Generic;
using System.Linq;

namespace _07.MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            double number = double.Parse(Console.ReadLine());

            int power = int.Parse(Console.ReadLine());

            double result = GetResult(number, power);

            Console.WriteLine(result);
        }

        private static double GetResult(double number, int power)
        {
            double result = Math.Pow(number, power);

            return result;
        }
    }
}
