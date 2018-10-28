using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace _04.MixedUpLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> firstList = Console.ReadLine().Split(' ').Select(long.Parse).ToList();

            List<long> secondList = Console.ReadLine().Split(' ').Select(long.Parse).ToList();

            List<long> putallListsNumbers = new List<long>();            

            for (int i = 0; i < Math.Min(firstList.Count,secondList.Count); i++)
            {
                putallListsNumbers.Add(firstList[i]);
                putallListsNumbers.Add(secondList[secondList.Count - 1 - i]);
            }
            if (firstList.Count > secondList.Count)
            {
                long start = Math.Min(firstList[firstList.Count - 1], firstList[firstList.Count - 2]);// get last two
                long end = Math.Max(firstList[firstList.Count - 1], firstList[firstList.Count - 2]);// get last two

                putallListsNumbers = putallListsNumbers.Where(x => x > start && x < end).ToList();
            }
            else if (secondList.Count > firstList.Count)
            {
                long start = Math.Min(secondList[0],secondList[1]);  //take first two numbers,because they left
                long end = Math.Max(secondList[0], secondList[1]);  //take first two numbers,because they left

                putallListsNumbers = putallListsNumbers.Where(x => x > start && x < end).ToList();
            }
            Console.WriteLine(string.Join(" ",putallListsNumbers.OrderBy(x =>x)));
                        
        }
    }
}
