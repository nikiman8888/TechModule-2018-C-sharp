using System;
using System.Globalization;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace _03.BigFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            BigInteger bg = 1;

            for (int i = 2; i <= num; i++)
            {
                bg *= i;
            }
            Console.WriteLine(bg);
        }
    }
}
