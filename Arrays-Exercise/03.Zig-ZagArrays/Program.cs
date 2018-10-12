using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace _03.Zig_ZagArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var first = new List<int>();
            var second = new List<int>();

            for (int i = 0; i < n; i++)
            {
                int[] tokens = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                int currentFirst = tokens[0];
                int currentSecond = tokens[1];

                if (i %2  == 0)
                {
                    first.Add(currentFirst);
                    second.Add(currentSecond);
                }
                else
                {
                    second.Add(currentFirst);
                    first.Add(currentSecond);
                }
            }
            Console.WriteLine(string.Join(" ",first));
            Console.WriteLine(string.Join(" ",second));
        }
    }
}
