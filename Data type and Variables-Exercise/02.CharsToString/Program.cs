using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02.CharsToString
{
    class Program
    {
        static void Main(string[] args)
        {
            string charFirst = Console.ReadLine();
            string charSecond = Console.ReadLine();
            string charThird = Console.ReadLine();

            string result = charFirst + charSecond + charThird;

            Console.WriteLine(result);
        }
    }
}
