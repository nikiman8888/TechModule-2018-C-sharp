using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace _10.MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} X {1} = {2}",num,i,num*i);
            }
        }
    }
}
