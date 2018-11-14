using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Threading;
using System.Text;
using System.Text.RegularExpressions;

namespace _02.Ascii_Sumator

{
    class Program
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());

            char second = char.Parse(Console.ReadLine());

            string text = Console.ReadLine();

            int sum = 0;

            if (first > second)
            {
                for (int i = 0; i < text.Length; i++)
                {
                    char current = text[i];

                    if (current > second && current <first)
                    {
                        sum += current;
                    }
                }
            }
            else
            {
                for (int i = 0; i < text.Length; i++)
                {
                    char current = text[i];

                    if (current > first && current < second)
                    {
                        sum += current;
                    }
                }
            }
            Console.WriteLine(sum);
        }
    }
}
