using System;
using System.Globalization;
using System.Threading;
using System.Collections.Generic;
using System.Linq;

namespace _10.SoftUni_Exam_Results_FromExams
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var studentsData = new Dictionary<string, int>();
            var language = new Dictionary<string, int>();

            while (input != "exam finished")
            {
                string[] tokens = input.Split('-').ToArray();

                string currentName = tokens[0];

                string currentLanguage = tokens[1];
               
                if (currentLanguage == "banned")
                {
                    if (studentsData.ContainsKey(currentName))
                    {
                        studentsData = studentsData.Where(x => x.Key != currentName).ToDictionary(k => k.Key, v => v.Value);
                    }
                }
                else
                {
                    int points = int.Parse(tokens[2]);

                    if (!studentsData.ContainsKey(currentName))
                    {
                        studentsData.Add(currentName, 0);
                        

                    }
                    if (studentsData[currentName] < points)
                    {
                        studentsData[currentName] = points;
                    }

                    if (!language.ContainsKey(currentLanguage))
                    {
                        language.Add(currentLanguage, 0);
                    }
                    language[currentLanguage] += 1;
                }

                input = Console.ReadLine();
            }
            Console.WriteLine("Results:");
            foreach (var datas in studentsData.OrderByDescending(x=>x.Value).ThenBy(x =>x.Key))
            {
                Console.WriteLine("{0} | {1}",datas.Key,datas.Value);
            }
            Console.WriteLine("Submissions:");

            foreach (var item in language.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key))
            {
                Console.WriteLine("{0} - {1}",item.Key,item.Value);
            }
        }
    }
}
