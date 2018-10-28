using System;
using System.Globalization;
using System.Threading;
using System.Collections.Generic;
using System.Linq;

namespace _05.WordFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(' ').ToList();

            input = input.Where(x => x.Length % 2 == 0).ToList();

            Console.WriteLine(string.Join(Environment.NewLine,input));
        }
    }
}
