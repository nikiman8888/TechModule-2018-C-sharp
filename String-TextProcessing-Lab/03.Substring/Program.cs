using System;
using System.Globalization;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string first = Console.ReadLine().ToLower();

            string second = Console.ReadLine().ToLower();

            while(true)
            {
                int index = second.IndexOf(first);

                if (index == -1)
                {
                    break;
                }
                second = second.Remove(index,first.Length);

            }
            
            Console.WriteLine(second);
        }
    }
}
