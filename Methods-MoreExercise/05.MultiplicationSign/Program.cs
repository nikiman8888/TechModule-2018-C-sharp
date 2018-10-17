using System;
using System.Globalization;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _05.MultiplicationSign
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            double num3 = double.Parse(Console.ReadLine());

            var list = new List<double> {num1,num2,num3};

            if(list.Contains(0))
            {
                Console.WriteLine("zero");
                return;
            }
            else
            {
                PrintResult(list);   
            }
        }

        private static void PrintResult(List<double> list)
        {
            int countnegative = list.Where(x => x < 0).Count();

            if (countnegative == 0 || countnegative == 2)
            {
                Console.WriteLine("positive");
            }
            else
            {
                Console.WriteLine("negative");
            }
        }
    }
}
