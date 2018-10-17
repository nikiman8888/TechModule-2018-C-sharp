using System;
using System.Globalization;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04.TribonacciSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            var list = new List<long>();

            var result = new List<long>();

            for (int i = 1; i <= num; i++)
            {
                if (i == 1 || i == 2)
                {                    
                    list.Add(1);
                    result.Add(1);
                }
                else if (i == 3)
                {                    
                    list.Add(2);
                    result.Add(2);
                }
                else
                {
                    long sum = list.Sum();

                    list.Add(sum);

                    result.Add(sum);

                    list.RemoveAt(0);  
                    
                }
            }
            Console.WriteLine(string.Join(" ",result));
        }
    }
}
