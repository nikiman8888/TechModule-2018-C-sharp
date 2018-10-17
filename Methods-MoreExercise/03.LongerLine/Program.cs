using System;
using System.Globalization;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03.LongerLine
{
    class Program
    {
        static void Main(string[] args)
        {
            double xFirstPair = double.Parse(Console.ReadLine());

            double yFirstPair = double.Parse(Console.ReadLine());

            double xSecondPair = double.Parse(Console.ReadLine());

            double ySecondPair = double.Parse(Console.ReadLine());

            double xFirst = double.Parse(Console.ReadLine());

            double yFirst = double.Parse(Console.ReadLine());

            double xSecond = double.Parse(Console.ReadLine());

            double ySecond = double.Parse(Console.ReadLine());

            double firstLiine = GetLine(xFirstPair, yFirstPair, xSecondPair, ySecondPair); 
            double secondLiine = GetLine(xFirst, yFirst, xSecond, ySecond); 

            if (firstLiine >= secondLiine)
            {
                PrintPoint(xFirstPair,yFirstPair,xSecondPair,ySecondPair);
            }
            else
            {
                PrintPoint(xFirst, yFirst, xSecond, ySecond);
            }
        }

        private static double GetLine(double xFirstPair, double yFirstPair, double xSecondPair, double ySecondPair)
        {
            double temp = Math.Pow(Math.Abs(xSecondPair - xFirstPair), 2) + Math.Pow(Math.Abs(ySecondPair - yFirstPair), 2);
            temp = Math.Pow(temp, 2);

            return temp;
        }

        private static void PrintPoint(double xFirst, double yFirst, double xSecond, double ySecond)
            {
                double first = Math.Abs(xFirst) + Math.Abs(yFirst);
                double second = Math.Abs(xSecond) + Math.Abs(ySecond);
                if (first <= second)
                {
                    Console.Write($"({xFirst}, {yFirst})");
                    Console.WriteLine($"({xSecond}, {ySecond})");

            }
                else
                {
                    Console.Write($"({xSecond}, {ySecond})");
                    Console.WriteLine($"({xFirst}, {yFirst})");
            }
            }
       
    }
}
