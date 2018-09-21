using System;
using System.Globalization;

namespace _01.StudentInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            int age = int.Parse(Console.ReadLine());

            double grade = double.Parse(Console.ReadLine(), NumberFormatInfo.InvariantInfo);

            Console.WriteLine("Name: {0}, Age: {1}, Grade: {2:F2}",name, age, grade);
        }
    }
}
