using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04.PrintAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNumber = int.Parse(Console.ReadLine());

            int endNumber = int.Parse(Console.ReadLine());

            long totalSum = 0;

            for (int i = startNumber; i <= endNumber; i++)
            {
                Console.Write(i +" ");

                totalSum += i;
            }
            Console.WriteLine();
            Console.WriteLine("Sum: {0}",totalSum);
        }
    }
}
