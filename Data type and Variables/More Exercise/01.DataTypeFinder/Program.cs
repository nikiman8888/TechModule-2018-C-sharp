using System;
using System.Globalization;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _01.DataTypeFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            string input = Console.ReadLine();

            bool isBolean;

            int res;

            double result;

            char isChar;

            while (input != "END")
            {
                
                if (int.TryParse(input, out res))
                {
                    Console.WriteLine($"{input} is integer type");
                }
                
                else if (Double.TryParse(input, out result))
                {
                    Console.WriteLine($"{input} is floating point type");
                }
                else if (Boolean.TryParse(input,out isBolean))
                {
                    Console.WriteLine($"{input} is boolean type");
                }
                else if (Char.TryParse(input, out isChar))
                {
                    Console.WriteLine($"{isChar} is character type");
                }
                else
                {
                    Console.WriteLine($"{input} is string type");
                }
                
                input = Console.ReadLine();
            }
        }
    }
}
