using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace _08.MagicSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(new char[] {' '},StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int magicNumber = int.Parse(Console.ReadLine());

            var result = new List<string>();

            for (int i = 0; i < array.Length; i++)
            {
                int current = array[i];
                if (i == array.Length-1 )
                {
                    break;
                }
                for (int j = i+1; j < array.Length; j++)
                {
                    int next = array[j];

                    if (current + next ==  magicNumber)
                    {
                        result.Add(current + " " + next);
                    }
                }
            }
            Console.WriteLine(string.Join("\n",result));
        }
    }
}
