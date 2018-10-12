using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace _05.TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int coutLeftElements = 1;
            var result = new List<int>();

            for (int i = 0; i < array.Length; i++)
            {
                
                int current = array[i];
                if (i == array.Length - 1)
                {
                    result.Add(current);
                    break;
                }

                List<int> temp = array.Skip(coutLeftElements).Take(array.Length - coutLeftElements).ToList();

                if (temp.All( x =>x < current))
                {
                    result.Add(current);
                }
                coutLeftElements++;
            }
            Console.WriteLine(string.Join(" ",result));
        }
    }
}
