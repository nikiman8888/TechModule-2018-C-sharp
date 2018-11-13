using System;
using System.Globalization;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;
using System.Numerics;

namespace _08.LettersChangeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            string[] inpuData = Console.ReadLine()
                .Split(new char[] {' '},StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            Regex valid = new Regex(@"(?<first>[A-Za-z]{1}[0-9]+[A-Za-z]{1})");

            double sum = 0;

            for (int i = 0; i < inpuData.Length; i++)
            {
                string current = inpuData[i];

                if (valid.IsMatch(current))
                {
                    var getVaalid = valid.Match(current);
                    current = getVaalid.Groups["first"].Value;
                    sum += GetSum(current);
                }                
            }

            Console.WriteLine("{0:F2}",sum);
        }

        private static double GetSum(string current)
        {
            string tempNumber = "";

            char firstLetter = current[0];

            char lastLetter = current[current.Length - 1];

            tempNumber = current.Substring(1, current.Length - 2);

            double convertNumber = double.Parse(tempNumber);

            if (char.IsUpper(firstLetter))
            {
                int position = (int)firstLetter % 32;

                convertNumber /= position;
            }
            else
            {
                int position = (int)firstLetter % 32;
                convertNumber *= position;
            }

            if (char.IsUpper(lastLetter))
            {
                int position = (int)lastLetter % 32;

                convertNumber -= position;
            }
            else
            {
                int position = (int)lastLetter % 32;

                convertNumber += position;
            }
            return convertNumber;
        }
    }
}
