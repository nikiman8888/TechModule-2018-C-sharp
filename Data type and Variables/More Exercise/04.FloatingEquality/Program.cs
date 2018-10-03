using System;
using System.Globalization;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04.FloatingEquality
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            double firstNumber = double.Parse(Console.ReadLine());

            double secondNumber = double.Parse(Console.ReadLine());

            double precision = 0.000001;

            if (Math.Abs(firstNumber - secondNumber) <= precision)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }


        }
    }
}
