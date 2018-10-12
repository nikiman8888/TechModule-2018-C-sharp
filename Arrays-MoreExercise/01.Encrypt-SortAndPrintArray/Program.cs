using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace _01.Encrypt_SortAndPrintArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int arrayCount = int.Parse(Console.ReadLine());

            string vowels = "aAuUoOiIeE";

            var result = new List<int>();

            for (int i = 0; i < arrayCount; i++)
            {
                int currentSum = 0;

                string currentString = Console.ReadLine();

                for (int k = 0; k < currentString.Length; k++)
                {
                    char currentChar = currentString[k];

                    if (vowels.Contains(currentChar))
                    {
                        currentSum += currentChar * currentString.Length;
                    }
                    else
                    {
                        currentSum += currentChar / currentString.Length; 
                    }
                }
                result.Add(currentSum);                               
            }
            foreach (var currentNumber in result.OrderBy(x =>x))
            {
                Console.WriteLine(currentNumber);
            }
        }
    }
}
