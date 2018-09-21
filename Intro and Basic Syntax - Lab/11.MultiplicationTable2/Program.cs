using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace _11.MultiplicationTable2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());

            int num2 = int.Parse(Console.ReadLine());

            if (num2 > 10)
            {
                Console.WriteLine("{0} X {1} = {2}", num1, num2, num1 * num2);
                return;
            }
            for (int i = num2; i <= 10; i++)
            {
                Console.WriteLine("{0} X {1} = {2}", num1, i , num1 * i);
            }
        }
    }
}
