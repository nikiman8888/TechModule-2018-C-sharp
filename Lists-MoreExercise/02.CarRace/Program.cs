using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace _02.CarRace
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            List<double> input = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            int middle = input.Count / 2 ;

            List<double> left = input.Take(input.Count / 2).ToList();
            List<double> right = input.Skip(middle + 1).Take(input.Count / 2).ToList();

            double leftSum = GetSum(left,"left");
            double rightSum = GetSum(right,"right");

            if (leftSum <= rightSum)
            {
                Console.WriteLine($"The winner is left with total time: {leftSum}");
            }
            else
            {
                Console.WriteLine($"The winner is right with total time: {rightSum}");
            }

        }

        private static double GetSum(List<double> list, string type)
        {
            double temp = 0;
            
            if (type == "left")
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] == 0 )
                    {
                        temp *= 0.8;
                        
                        continue;
                    }
                    temp += list[i];
                }

            }
            else
            {
                for (int i = list.Count -1; i >= 0; i--)
                {
                    if (list[i] == 0 )
                    {
                        temp *= 0.8;
                        
                        continue;
                    }
                    temp += list[i];
                }
            }
            
            return temp;
        }     
    }
}
