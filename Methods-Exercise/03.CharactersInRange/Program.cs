using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Threading;

namespace _03.CharactersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            
            char start = char.Parse(Console.ReadLine());

            char end = char.Parse(Console.ReadLine());

            if (start > end )
            {
                char temp = end;
                end = start;
                start = temp;
            }

            string result = GetResult(start, end);

            Console.WriteLine(result.Trim());
        }

        private static string GetResult(char start, char end)
        {
            string temp = "";

            for ( int i = start + 1; i < end; i++)
            {
                char current = (char)i;
                temp += current + " ";
            }
            return temp;
        }
    }
}
