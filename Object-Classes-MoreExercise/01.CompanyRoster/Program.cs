using System;
using System.Globalization;
using System.Threading;
using System.Collections.Generic;
using System.Linq;

namespace _01.CompanyRoster
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            int count = int.Parse(Console.ReadLine());

            var savaData = new Dictionary<string, List<Employee>>();

            for (int i = 0; i < count; i++)
            {
                string[] current = Console.ReadLine().Split(' ');

                string name = current[0];

                decimal salary = decimal.Parse(current[1]);

                string department = current[2];

                var currentEmploy = new Employee(name, salary, department);

                if (!savaData.ContainsKey(department))
                {
                    savaData.Add(department, new List<Employee>());
                }
                savaData[department].Add(currentEmploy);
            }

            foreach (var data in savaData.OrderByDescending(x=>x.Value.Sum(s=>s.Salary)))
            {              
                Console.WriteLine($"Highest Average Salary: {data.Key}");

                foreach (var salary in data.Value.OrderByDescending(s=>s.Salary))
                {
                    Console.WriteLine($"{salary.Name} {salary.Salary:F2}");
                }
                return;
            }
        }
    }
    class Employee
    {
        public string  Name { get; set; }
        public decimal  Salary { get; set; }
        public string Department { get; set; }

        public Employee(string name, decimal salary, string department)
        {
            Name = name;
            Salary = salary;
            Department = department;
        }
    }
}
