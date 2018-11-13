using System;
using System.Globalization;
using System.Threading;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _01.ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputData = Console.ReadLine()
                .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string paternValid = @"[A-Za-z0-9_-]+";

            Regex reg = new Regex(paternValid);

            for (int i = 0; i < inputData.Count; i++)
            {
                string current = inputData[i];

                var match = reg.Match(current);

                if (match.Length == current.Length && (current.Length >=3 && current.Length <= 16))
                {
                    Console.WriteLine(current);
                }
            }

        }
    }
}
