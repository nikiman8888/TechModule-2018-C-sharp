using System;
using System.Globalization;
using System.Threading;
using System.Collections.Generic;
using System.Linq;

namespace _04.PrintingTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                PrintLine(1, i);
            }
            for (int i = n-1; i > 0; i--)
            {
                PrintLine(1, i);
            }
        }

        private static void PrintLine(int v, int i)
        {
            for (int start = v; start <= i; start++)
            {
                Console.Write(start + " ");
            }
            Console.WriteLine();
        }
    }
}
