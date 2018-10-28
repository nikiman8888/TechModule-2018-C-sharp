using System;
using System.Globalization;
using System.Threading;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var result = new Dictionary<int, int>();

            for (int i = 0; i < list.Count; i++)
            {
                int current = list[i];

                if (!result.ContainsKey(current))
                {

                    result.Add(current, 0);
                }
                result[current] += 1; 
            }

            foreach (var item in result.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
