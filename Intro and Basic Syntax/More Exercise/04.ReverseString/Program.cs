using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Globalization;

namespace _04.ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine();

            var arr = inputText.ToCharArray().Reverse();

            Console.WriteLine(string.Join("",arr));
        }
    }
}
