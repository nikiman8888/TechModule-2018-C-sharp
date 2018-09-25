using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02.EnglishNameLastDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());

            int lastDigit = inputNumber % 10;

            string result = GetText(lastDigit);

            Console.WriteLine(result);
        }

        private static string GetText(int lastDigit)
        {
            List<string> textDigits = new List<string>{
                "zero",
                "one",
                "two",
                "three",
                "four",
                "five",
                "six",
                "seven",
                "eight",
                "nine"

            };
            return textDigits[lastDigit];
        }
    }
}
