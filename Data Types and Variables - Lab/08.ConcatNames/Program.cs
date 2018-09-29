using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Numerics;

namespace _08.ConcatNames
{
    class Program
    {
        static void Main(string[] args)
        {           

            string firstName = Console.ReadLine();           

            string secondName = Console.ReadLine();

            string delimeter = Console.ReadLine();

            string result = firstName + delimeter + secondName;

            Console.WriteLine(result);
        }
    }
}
