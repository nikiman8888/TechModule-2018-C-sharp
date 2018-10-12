using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace _02.CommonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstArray = Console.ReadLine().Split(' ').ToArray();

            string[] secondArray = Console.ReadLine().Split(' ').ToArray();

            var result = new List<string>();

            if (firstArray.Length < secondArray.Length)
            {
                for (int i = 0; i < firstArray.Length; i++)
                {
                    string current = firstArray[i];
                    if (secondArray.Contains(current))
                    {
                        result.Add(current);
                    }
                }
            }
            else
            {
                for (int i = 0; i < secondArray.Length; i++)
                {
                    string current = secondArray[i];
                    if (firstArray.Contains(current))
                    {
                        result.Add(current);
                    }
                }
            }
            Console.WriteLine(string.Join(" ",result));
        }
    }
}
