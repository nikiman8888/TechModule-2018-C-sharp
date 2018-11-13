using System;
using System.Globalization;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05.Digits_Letters_Other
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string digits = "";

            string letters = "";

            string others = "";

            foreach (var currentSymbol in text)
            {
                if (char.IsDigit(currentSymbol))
                {
                    digits += currentSymbol;
                }
                else if (char.IsLetter(currentSymbol))
                {
                    letters += currentSymbol;
                }
                else
                {
                    others += currentSymbol;
                }
            }
            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(others);

            
        }
    }
}
