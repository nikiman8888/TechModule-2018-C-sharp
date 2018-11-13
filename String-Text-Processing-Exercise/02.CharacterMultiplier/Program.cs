using System;
using System.Globalization;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02.CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] data = Console.ReadLine().Split(' ').ToArray();

            string first = data[0];

            string second = data[1];
           
            int minLenght = Math.Min(first.Length, second.Length);

            long sum = 0;

            for (int i = 0; i < minLenght; i++)
            {
                int currentFirst = first[i];
                int currentSecond = second[i];

                sum += (currentFirst * currentSecond);
            }
            string getOtherSymbols = "";
            if (first.Length >second.Length)
            {
                getOtherSymbols = first.Substring(minLenght);
            }
            else if (second.Length > first.Length)
            {
                getOtherSymbols = second.Substring(minLenght);
            }
            for (int i = 0; i < getOtherSymbols.Length; i++)
            {
                sum += getOtherSymbols[i];
            }
            Console.WriteLine(sum);
        }

    }
}
