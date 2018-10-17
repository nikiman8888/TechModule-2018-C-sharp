using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Threading;
using System.Text.RegularExpressions;

namespace _09.PalindromeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "END")
            {
                bool resullt = isPalindrome(input);
                Console.WriteLine(resullt.ToString().ToLower());

                input = Console.ReadLine();
            }
        }

        private static bool isPalindrome(string input)
        {            
            for (int i = 0; i < input.Length/2; i++)
            {
                if (input[i] != input[input.Length -1 -i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
