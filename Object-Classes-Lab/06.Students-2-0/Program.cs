using System;
using System.Globalization;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace _06.Students_2_0
{
    class Program
    {
        static void Main(string[] args)
        {

            var studentsData = new List<Student>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }

                string[] tokens = input.Split(' ');

                string firstName = tokens[0];

                string lastName = tokens[1];

                int age = int.Parse(tokens[2]);

                string town = tokens[3];

                var current = new Student(firstName, lastName, age, town);

                bool exist = false;
                foreach (var student in studentsData)
                {
                    if (student.FirstName == current.FirstName && student.LastName == current.LastName)
                    {
                        exist = true;

                        student.FirstName = current.FirstName;
                        student.LastName = current.LastName;
                        student.Age = current.Age;
                        student.Town = current.Town;
                        break;

                    }
                    
                }
                if (!exist)
                {
                    studentsData.Add(current);
                }
                exist = false;
                               
            }            

            string city = Console.ReadLine();

            foreach (var student in studentsData)
            {
                if (student.Town == city)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
        }
    }
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Town { get; set; }

        public Student(string firstName, string lastName, int age, string town)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Town = town;
        }
    }
}
