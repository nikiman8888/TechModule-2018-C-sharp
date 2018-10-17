using System;
using System.Globalization;
using System.Threading;
using System.Collections.Generic;
using System.Linq;

namespace _10.RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int count = int.Parse(Console.ReadLine());

            PrintResult(input, count);
        }

        private static void PrintResult(string input, int count)
        {
            string temp = "";
            for (int i = 0; i < count; i++)
            {
                temp += input; 
            }
            Console.WriteLine(temp);
        }
    }
}
