using System;
using System.Globalization;
using System.Threading;
using System.Collections.Generic;
using System.Linq;

namespace _01.DayWeek
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            DateTime dt = DateTime.ParseExact(input, "d-M-yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine(dt.DayOfWeek);
        }
    }
}
