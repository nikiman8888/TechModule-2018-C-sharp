using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace _01.Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var result = new List<int>();

            for (int i = 0; i < n; i++)
            {
                int currentPeopleCount = int.Parse(Console.ReadLine());
                result.Add(currentPeopleCount);
            }
            Console.WriteLine(string.Join(" ",result));
            Console.WriteLine(result.Sum());
        }
    }
}
