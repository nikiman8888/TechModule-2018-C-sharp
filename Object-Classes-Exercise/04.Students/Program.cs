using System;
using System.Globalization;
using System.Threading;
using System.Collections.Generic;
using System.Linq;

namespace _04.Students
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            int count = int.Parse(Console.ReadLine());

            var studentsData = new List<Student>();

            for (int i = 0; i < count; i++)
            {
                string [] currentStudent = Console.ReadLine().Split(' ');

                string firstName = currentStudent[0];

                string lastName = currentStudent[1];

                double grade = double.Parse(currentStudent[2]);

                var current = new Student(firstName, lastName, grade);

                studentsData.Add(current);

            }

            foreach (var student in studentsData.OrderByDescending(x=>x.Grade))
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade:F2}");
            }
        }
    }
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }

        public Student (string firstName,string lastName, double grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }
    }
}
