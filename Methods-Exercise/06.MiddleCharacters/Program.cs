using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Threading;
using System.Text.RegularExpressions;

namespace _06.MiddleCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var result = GetMiddle(input);

            Console.WriteLine(string.Join("",result));
        }

        private static  List<char> GetMiddle(string input)
        {
            var temp = new List<char>();
            if (input.Length %2 != 0)
            {
                int letterToSkip = input.Length / 2;

                temp = input.Skip(letterToSkip).Take(1).ToList();
            }
            else
            {
                int letterToSkip = input.Length / 2 - 1;

                temp = input.Skip(letterToSkip).Take(2).ToList();
            }
            return temp;
        }
    }
}
