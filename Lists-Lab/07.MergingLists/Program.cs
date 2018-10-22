using System;
using System.Globalization;
using System.Threading;
using System.Collections.Generic;
using System.Linq;

namespace _07.MergingLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> firstList = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToList();

            List<double> secondList = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToList();

            var result = new List<double>();


            int minLength = Math.Min(firstList.Count, secondList.Count);

            if (firstList.Count == secondList.Count)
            {
                for (int i = 0; i < minLength; i++)
                {
                    result.Add(firstList[i]);
                    result.Add(secondList[i]);
                }                                
            }
            
            else if (firstList.Count < secondList.Count)
            {
                var temp = secondList.Skip(minLength).ToList();

                for (int i = 0; i < minLength; i++)
                {
                    result.Add(firstList[i]);
                    result.Add(secondList[i]);
                }
                result.AddRange(temp);
            }
            else
            {
                var temp = firstList.Skip(minLength).ToList();

                for (int i = 0; i < minLength; i++)
                {
                    result.Add(firstList[i]);
                    result.Add(secondList[i]);
                }
                result.AddRange(temp);
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
