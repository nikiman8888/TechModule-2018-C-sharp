using System;
using System.Globalization;
using System.Threading;
using System.Collections.Generic;
using System.Linq;

namespace _07.StudentAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            int count = int.Parse(Console.ReadLine());

            var dataStudents = new Dictionary<string, List<double>>();

            for (int i = 0; i < count; i++)
            {
                string student = Console.ReadLine();

                double grade = double.Parse(Console.ReadLine());

                if (!dataStudents.ContainsKey(student))
                {
                    dataStudents.Add(student,new List<double>());
                }
                dataStudents[student].Add(grade);
            }

            dataStudents = dataStudents.Where(x => x.Value.Average() >= 4.50).ToDictionary(k => k.Key, v => v.Value);

            foreach (var student in dataStudents.OrderByDescending(x=>x.Value.Average()))
            {
                string name = student.Key;

                double averageGrade = student.Value.Average();

                Console.WriteLine("{0} -> {1:F2}",name , averageGrade);
            }
        }    
    }
}
