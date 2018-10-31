using System;
using System.Globalization;
using System.Threading;
using System.Collections.Generic;
using System.Linq;

namespace _01.Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var saveDataContests = new Dictionary<string, string>();

            var studentsData = new Dictionary<string, Dictionary<string, int>>();

            while (input != "end of contests")
            {
                string[] tokens = input.Split(':').ToArray();

                string currentLesson = tokens[0];
                string currentPass = tokens[1];

                saveDataContests.Add(currentLesson, currentPass);

                input = Console.ReadLine();
            }

            string secondInput = Console.ReadLine();

            while (secondInput != "end of submissions")
            {
                string[] tokens = secondInput
                    .Split(new string[] { "=>" }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string currentContest = tokens[0];

                string currentPass = tokens[1];

                string userName = tokens[2];

                int poits = int.Parse(tokens[3]);

                if (saveDataContests.ContainsKey(currentContest))
                {
                    if (saveDataContests[currentContest] == currentPass)
                    {
                        if (!studentsData.ContainsKey(userName))
                        {
                            studentsData.Add(userName, new Dictionary<string, int>());
                        }
                        if (!studentsData[userName].ContainsKey(currentContest))
                        {
                            studentsData[userName].Add(currentContest, 0);
                        }
                        if (studentsData[userName][currentContest] < poits)
                        {
                            studentsData[userName][currentContest] = poits;
                        }
                    }
                }
                secondInput = Console.ReadLine();
            }
            string bestStudent = GetBestName(studentsData);

            int bestPoints = studentsData[bestStudent].Values.Sum();

            Console.WriteLine($"Best candidate is {bestStudent} with total {bestPoints} points.");

            Console.WriteLine("Ranking:");

            foreach (var datas in studentsData.OrderBy(x =>x.Key))
            {
                string student = datas.Key;

                var data = datas.Value;

                Console.WriteLine(student);
                foreach (var lessons in data.OrderByDescending(x =>x.Value))
                {
                    Console.WriteLine($"#  {lessons.Key} -> {lessons.Value}");
                }
            }
            
        }
        private static string GetBestName(Dictionary<string, Dictionary<string, int>> studentsData)
        {
            string tempName = "";

            foreach (var data in studentsData.OrderByDescending(x=>x.Value.Values.Sum()))
            {
                string best = data.Key;
                tempName = best;
                break;
            }
            return tempName;
        }
    }
}
