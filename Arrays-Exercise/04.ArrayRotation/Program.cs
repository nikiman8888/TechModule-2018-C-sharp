using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace _04.ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int rotation = int.Parse(Console.ReadLine());

            for (int i = 0; i < rotation% input.Count; i++)
            {
                int saveFirst = input[0];
                input.RemoveAt(0);
                input.Add(saveFirst);
               
            }
            Console.WriteLine(string.Join(" ",input));
        }
    }
}
