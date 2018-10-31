using System;
using System.Globalization;
using System.Threading;
using System.Collections.Generic;
using System.Linq;

namespace _03.MOBA_Challenger
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string batlePatern = " vs ";

            var result = new Dictionary<string, Dictionary<string, int>>();

            while (input != "Season end")
            {
                if (input.Contains(batlePatern))
                {
                    string[] tokens = input.Split(batlePatern);

                    string firstPlayer = tokens[0];

                    string secondPlayer = tokens[1];

                    if (result.ContainsKey(firstPlayer) && result.ContainsKey(secondPlayer))
                    {
                        bool containsPosition = GetPosition(result[firstPlayer], result[secondPlayer]);

                        if (containsPosition)
                        {
                            int powerFirstPLayer = result[firstPlayer].Values.Sum();
                            int powerSecondPLayer = result[secondPlayer].Values.Sum();

                            if (powerFirstPLayer >powerSecondPLayer)
                            {
                                result = result.Where(x => x.Key != secondPlayer).ToDictionary(k => k.Key, v => v.Value);
                            }
                            else if (powerSecondPLayer > powerFirstPLayer)
                            {
                                result = result.Where(x => x.Key != firstPlayer).ToDictionary(k => k.Key, v => v.Value);
                            }
                        }
                    }
                }
                else
                {
                    string[] tokens = input
                        .Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries)
                        .ToArray();

                    string currentPlayer = tokens[0];

                    string currentPosition = tokens[1];

                    int currentSkills = int.Parse(tokens[2]);

                    if (!result.ContainsKey(currentPlayer))
                    {
                        result.Add(currentPlayer, new Dictionary<string, int>());
                    }
                    if (!result[currentPlayer].ContainsKey(currentPosition))
                    {
                        result[currentPlayer].Add(currentPosition, 0);
                    }
                    if (result[currentPlayer][currentPosition] < currentSkills)
                    {
                        result[currentPlayer][currentPosition] = currentSkills;
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var item in result
                .OrderByDescending(x =>x.Value.Values.Sum())
                .ThenBy(x =>x.Key))
            {
                string name = item.Key;

                var players = item.Value;

                Console.WriteLine($"{name}: {players.Values.Sum()} skill");

                foreach (var player in players
                    .OrderByDescending(x=>x.Value)
                    .ThenBy(x =>x.Key))
                {
                    string position = player.Key;

                    int skills = player.Value;

                    Console.WriteLine($"- {position} <::> {skills}");
                }
            }
        }

        private static bool GetPosition(Dictionary<string, int> dictionary1, Dictionary<string, int> dictionary2)
        {
            List<string> tempFirstPLayerKeys = dictionary1.Keys.ToList();

            foreach (var data in dictionary2)
            {
                string position = data.Key;

                if (tempFirstPLayerKeys.Contains(position))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
