using System;
using System.Globalization;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.RepeatStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');

            StringBuilder bd = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                int count = input[i].Length;

                for (int j = 0; j < count; j++)
                {
                    bd.Append(input[i]);
                }
            }
            Console.WriteLine(bd.ToString());
        }        
    }
}
