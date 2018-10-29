using System;
using System.Globalization;
using System.Threading;
using System.Collections.Generic;
using System.Linq;

namespace _01.CountCharsInString
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            var result = new Dictionary<char, int>();

            for (int i = 0; i < text.Length; i++)
            {
                char current = text[i];
                if (current == ' ')
                {
                    continue;
                }

                if (!result.ContainsKey(current))
                {
                    result.Add(current, 0);
                }
                result[current] += 1;
            }
            foreach (var symbol in result)
            {
                Console.WriteLine($"{symbol.Key} -> {symbol.Value}");
            }
        }
    }
}
