using System;
using System.Globalization;
using System.Threading;
using System.Collections.Generic;
using System.Linq;

namespace _09.ForceBook_fromExams
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string input = Console.ReadLine();

            string sidePatern = " | ";
            string userPatern = " -> ";

            var result = new Dictionary<string, List<string>>();

            var saveAllUsers = new List<string>();

            while (input != "Lumpawaroo")
            {
                if (input.Contains(sidePatern))
                {
                    string[] tokens = input
                        .Split(new string[] { " | " }, StringSplitOptions.RemoveEmptyEntries)
                        .ToArray();

                    string forseSide = tokens[0];

                    if (!result.ContainsKey(forseSide))
                    {
                        result.Add(forseSide, new List<string>());
                    }

                    string forseUser = tokens[1];

                    if (!saveAllUsers.Contains(forseUser))
                    {
                        result[forseSide].Add(forseUser);

                        saveAllUsers.Add(forseUser);
                    }
                                  
                }
                else if (input.Contains(userPatern))
                {
                    string[] tokens = input
                        .Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries)
                        .ToArray();
                    string forseSide = tokens[1];

                    string forseUser = tokens[0];

                    if (!result.ContainsKey(forseSide))
                    {
                        result.Add(forseSide, new List<string>());
                    }

                    if (saveAllUsers.Contains(forseUser))
                    {
                        string getKey = GetKey(result, forseUser);

                        result[getKey].Remove(forseUser);
                        
                    }
                    result[forseSide].Add(forseUser);

                    Console.WriteLine($"{forseUser} joins the {forseSide} side!");

                }

                input = Console.ReadLine();
            }

            result = result.Where(x => x.Value.Count > 0).ToDictionary(k => k.Key, v => v.Value);


            foreach (var datas in result.OrderByDescending(x =>x.Value.Count).ThenBy(x =>x.Key))
            {
                string side = datas.Key;

                var users = datas.Value;

                Console.WriteLine($" Side: {side}, Members: {users.Count}");

                foreach (var user in users.OrderBy(x=>x))
                {
                    Console.WriteLine($"! {user}");
                }
            }
        }

        private static string GetKey(Dictionary<string, List<string>> result, string forseUser)
        {
            string getKey = "";

            foreach (var item in result)
            {
                string currentSide = item.Key;

                var users = item.Value;

                if (users.Contains(forseUser))
                {
                    getKey = currentSide;
                    break;
                }
            }
            return getKey;
        }
    }
}
