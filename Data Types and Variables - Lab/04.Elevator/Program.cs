using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Numerics;

namespace _04.Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            double peopleCount = double.Parse(Console.ReadLine(),NumberFormatInfo.InvariantInfo);

            double elevatorQapacity = double.Parse(Console.ReadLine(),NumberFormatInfo.InvariantInfo);

            double coureses = Math.Ceiling(peopleCount / elevatorQapacity);

            Console.WriteLine(coureses);
        }
    }
}
