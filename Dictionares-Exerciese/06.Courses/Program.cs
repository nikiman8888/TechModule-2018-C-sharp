using System;
using System.Globalization;
using System.Threading;
using System.Collections.Generic;
using System.Linq;

namespace _06.Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var result = new Dictionary<string, List<string>>();

            while(input != "end")
            {
                string[] tokens = input.Split(new string[] { " : " }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                string currentCourse = tokens[0];
                string currentStudent = tokens[1];

                if (!result.ContainsKey(currentCourse))
                {
                    result.Add(currentCourse, new List<string>());
                }
                result[currentCourse].Add(currentStudent);

                input = Console.ReadLine();
            }

            foreach (var course in result.OrderByDescending(x=>x.Value.Count()))
            {
                string courseName = course.Key;

                var students = course.Value;

                Console.WriteLine($"{courseName}: {students.Count}");

                foreach (var student in students.OrderBy(x=>x))
                {
                    Console.WriteLine("-- {0}",student);
                }
            }
        }
    }
}
