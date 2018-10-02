using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _09.Pokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int m = int.Parse(Console.ReadLine());

            int y = int.Parse(Console.ReadLine());

            int countTarget = 0;

            double originalValue = n;

            while (n >= m)
            {
                n -= m;

                countTarget++;

                if (n  == 0.5 *  originalValue && y != 0)
                {
                    n /= y;
                }
            }
            Console.WriteLine(n);
            Console.WriteLine(countTarget);
        }
    }
}
