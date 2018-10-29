using System;
using System.Globalization;
using System.Threading;
using System.Collections.Generic;
using System.Linq;

namespace _08.CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var result = new Dictionary<string, List<string>>();

            while (input != "End")
            {
                string[] tokens = input
                    .Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string currentCompany = tokens[0];

                string currentEmployId = tokens[1];
                
                if (!result.ContainsKey(currentCompany))
                {
                    result.Add(currentCompany,new List<string>());
                }
                if (!result[currentCompany].Contains(currentEmployId))
                {
                    result[currentCompany].Add(currentEmployId);
                }

                input = Console.ReadLine();
            }
            foreach (var company in result.OrderBy(x =>x.Key))
            {
                string nameCompany = company.Key;

                var employes = company.Value;

                Console.WriteLine(nameCompany);

                foreach (var employ in employes)
                {
                    Console.WriteLine("-- {0}",employ);
                }
            }
        }
    }
}
