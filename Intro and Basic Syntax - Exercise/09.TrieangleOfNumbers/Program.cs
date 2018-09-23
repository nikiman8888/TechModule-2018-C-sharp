using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _09.TrieangleOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            int current = 1;

            for (int i = 0; i < n; i++)
            {
                for (int j = 1; j <= i + 1; j++)
                {
                    Console.Write(current +" ");
                    
                }
                current++;

                Console.WriteLine();
            }
        }
    }
}
