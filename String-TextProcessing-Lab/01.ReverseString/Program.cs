using System;
using System.Globalization;
using System.Threading;
using System.Collections.Generic;
using System.Linq;

namespace _01.ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "end")
            {
                string reversed = GetReversed(input);

                Console.WriteLine($"{input} = {reversed}");

                input = Console.ReadLine();
            }
        }

        private static string GetReversed(string input)
        {
            string temp = "";

            for (int i = input.Length - 1; i >= 0; i--)
            {
                temp += input[i];
            }
            return temp;
        }
    }
}
