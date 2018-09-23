using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int group = int.Parse(Console.ReadLine());

            string groupType = Console.ReadLine();

            string day = Console.ReadLine();

            double totalSum = 0;

            if (day == "Friday")
            {
                if (groupType == "Students")
                {
                    totalSum = group * 8.45;

                    if (group >= 30)
                    {
                        totalSum -= totalSum * 0.15;
                    }
                }
                else if (groupType == "Business")
                {
                    if (group >= 100)
                    {
                        group -= 10;
                    }
                    totalSum = group * 10.90;
                }
                else if (groupType == "Regular")
                {
                    totalSum = group * 15;

                    if (group >= 10 && group <= 20)
                    {
                        totalSum -= totalSum * 0.05;
                    }
                }
            }
            else if (day == "Saturday")
            {

                if (groupType == "Students")
                {
                    totalSum = group * 9.80;

                    if (group >= 30)
                    {
                        totalSum -= totalSum * 0.15;
                    }
                }
                else if (groupType == "Business")
                {
                    if (group >= 100)
                    {
                        group -= 10;
                    }
                    totalSum = group * 15.60;
                }
                else if (groupType == "Regular")
                {
                    totalSum = group * 20;

                    if (group >= 10 && group <= 20)
                    {
                        totalSum -= totalSum * 0.05;
                    }
                }
            }
            else if (day == "Sunday")
            {

                if (groupType == "Students")
                {
                    totalSum = group * 10.46;

                    if (group >= 30)
                    {
                        totalSum -= totalSum * 0.15;
                    }
                }
                else if (groupType == "Business")
                {
                    if (group >= 100)
                    {
                        group -= 10;
                    }
                    totalSum = group * 16;
                }
                else if (groupType == "Regular")
                {
                    totalSum = group * 22.50;

                    if (group >= 10 && group <= 20)
                    {
                        totalSum -= totalSum * 0.05;
                    }
                }
            }

            Console.WriteLine("Total price: {0:F2}",totalSum);

        }
    }
}
