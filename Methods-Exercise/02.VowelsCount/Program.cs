using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Threading;

namespace _02.VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int result = GetVowlessCount(input);

            Console.WriteLine(result);
        }

        private static int GetVowlessCount(string input)
        {
            string vowless = "aAoOuUeEiI";

            int counter = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (vowless.Contains(input[i].ToString()))
                {
                    counter++;
                }
            }

            return counter;
        }
    }
}
