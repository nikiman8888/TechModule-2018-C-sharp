using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace _02.PrintNumbersInReverseOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberCount = int.Parse(Console.ReadLine());

            int[] array = new int[numberCount];

            for (int i = 0; i < numberCount; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());

                array[i] = currentNumber;
            }
            Console.WriteLine(string.Join(" ",array.Reverse()));
        }
    }
}
