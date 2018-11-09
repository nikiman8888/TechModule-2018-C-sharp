using System;
using System.Globalization;
using System.Threading;
using System.Collections.Generic;
using System.Linq;

namespace _02.RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(' ').ToList();

            var result = new List<string>();

            Random rd = new Random();
            int index = 0;
            while (result.Count != input.Count)
            {
                index = rd.Next(0, input.Count );

                if (!result.Contains(input[index]))
                {
                    result.Add(input[index]);
                }
            }

            Console.WriteLine(string.Join(Environment.NewLine,result));

               
            

            
        }
    }
}
