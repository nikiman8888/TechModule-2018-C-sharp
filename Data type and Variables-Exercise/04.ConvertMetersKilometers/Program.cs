using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04.ConvertMetersKilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            int kilometers = int.Parse(Console.ReadLine());

            double result = kilometers / 1000.0;

            Console.WriteLine("{0:F2}",result);
        }
    }
}
