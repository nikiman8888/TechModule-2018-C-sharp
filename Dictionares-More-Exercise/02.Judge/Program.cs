using System;
using System.Globalization;
using System.Threading;
using System.Collections.Generic;
using System.Linq;

namespace _02.Judge
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var result = new Dictionary<string, Dictionary<string, int>>();

            var individualStatisitc = new Dictionary<string, Dictionary<string,int>>();

            while (input != "no more time")
            {
                string[] tokens = input
                    .Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string currentStudent = tokens[0];

                string currentContest = tokens[1];

                int currentPoitns = int.Parse(tokens[2]);

                if (!result.ContainsKey(currentContest))
                {
                    result.Add(currentContest, new Dictionary<string, int>());
                    
                }
                if(!result[currentContest].ContainsKey(currentStudent))
                {
                    result[currentContest].Add(currentStudent, 0);
                    
                }
                if (result[currentContest][currentStudent] < currentPoitns)
                {
                    result[currentContest][currentStudent] = currentPoitns;
                }
                if (!individualStatisitc.ContainsKey(currentStudent))
                {
                    individualStatisitc.Add(currentStudent, new Dictionary<string, int>());
                }
                if (!individualStatisitc[currentStudent].ContainsKey(currentContest))
                {
                    individualStatisitc[currentStudent].Add(currentContest, 0);
                }
                if (individualStatisitc[currentStudent][currentContest] < currentPoitns)
                {
                    individualStatisitc[currentStudent][currentContest] = currentPoitns;
                }

                input = Console.ReadLine();

            }

            int position = 1;

            foreach (var current in result)
            {
                string contest = current.Key;

                var students = current.Value;

                Console.WriteLine($"{contest}: {students.Count} participants");

                foreach (var student in students.OrderByDescending(x =>x.Value).ThenBy(x=>x.Key))
                {
                    Console.WriteLine($"{position}. {student.Key} <::> {student.Value}");
                    position++;
                }
                position = 1;
            }
            position = 1;
            Console.WriteLine("Individual standings:");

            foreach (var data in individualStatisitc
                .OrderByDescending(x=>x.Value.Values.Sum())
                .ThenBy(x =>x.Key))
            {
                string name = data.Key;

                int poits = data.Value.Values.Sum();

                Console.WriteLine($"{position}. {name} -> {poits}");
                position++;
            }

        }
    }
}
