using System;
using System.Globalization;
using System.Threading;
using System.Collections.Generic;
using System.Linq;

namespace _02.OldestFamilyMember
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            var createFamily = new Family();

            for (int i = 0; i < count; i++)
            {
                string[] currentPerson = Console.ReadLine().Split(' ');

                string name = currentPerson[0];

                int age = int.Parse (currentPerson[1]);

                var person = new Person(name, age);

                createFamily.AddPerson(person);
            }
            createFamily.GetOlder();
        }
    }
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person (string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
    class Family
    {
        public List<Person> People { get; set; }

        public Family()
        {
            People = new List<Person>() ;
        }
        public void AddPerson (Person person)
        {
            People.Add(person);
        }
        public void GetOlder()
        {
            foreach (var person in People.OrderByDescending(x=>x.Age))
            {
                Console.WriteLine($"{person.Name} {person.Age}");
                return;
            }
            
        }
    }
}
