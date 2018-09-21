using System;
using System.Globalization;

namespace _05.MonthPrinter
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            string[] months = {
                "January",
                "February",
                "March",
                "April",
                "May",
                "June",
                "July",
                "August",
                "September",
                "October",
                "November",
                "December" };
            bool result = number < 1 || number > 12;

            if (result)
            {
                Console.WriteLine("Error!");
            }
            else
            {
                Console.WriteLine(months[number-1]);
            }
        }
    }
}
