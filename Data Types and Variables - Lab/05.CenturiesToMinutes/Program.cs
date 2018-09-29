using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Numerics;

namespace _05.CenturiesToMinutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());

            int years = centuries * 100;

            int days = (int)(years * 365.2422);

            int hours = days * 24;

            int minutes = hours * 60;

            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");
        }
    }
}
