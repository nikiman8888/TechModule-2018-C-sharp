using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _09.PadawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double cash = double.Parse(Console.ReadLine(), NumberFormatInfo.InvariantInfo);

            int studentsCount = int.Parse(Console.ReadLine());

            double lightSber = double.Parse(Console.ReadLine(), NumberFormatInfo.InvariantInfo);

            double robe = double.Parse(Console.ReadLine(), NumberFormatInfo.InvariantInfo);

            double belt = double.Parse(Console.ReadLine(), NumberFormatInfo.InvariantInfo);

            double studentsWithPercent = Math.Ceiling(studentsCount*1.10);

            int freeBelts = studentsCount / 6;

            double result = (lightSber * studentsWithPercent) + (robe * studentsCount) + (belt * (studentsCount - freeBelts));

            if (cash >= result)
            {
                Console.WriteLine("The money is enough - it would cost {0:F2}lv",result);
            }
            else
            {
                Console.WriteLine("Ivan Cho will need {0:F2}lv more.",result - cash);
            }
        }
    }
}
