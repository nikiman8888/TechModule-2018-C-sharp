using System;
using System.Globalization;
using System.Threading;
using System.Collections.Generic;
using System.Linq;

namespace _07.OrderByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var persons = new List<Person>();

            while (input != "End")
            {
                string[] tokens = input.Split(' ');

                string name = tokens[0];

                string ID = tokens[1];

                int age = int.Parse(tokens[2]);


                var currentPerson = new Person(name, ID, age);

                persons.Add(currentPerson);


                input = Console.ReadLine();
            }

            foreach (var person in persons.OrderBy(x=>x.Age))
            {
                Console.WriteLine($"{person.Name} with ID: {person.Id} is {person.Age} years old.");
            }
        }
    }
    class Person
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public int Age { get; set; }

        public Person(string name, string id , int age)
        {
            Name = name;
            Id = id;
            Age = age;
        }
    }
}
