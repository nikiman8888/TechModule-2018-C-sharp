using System;
using System.Globalization;
using System.Threading;
using System.Collections.Generic;
using System.Linq;

namespace _03.WordSynonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            var result = new Dictionary<string, List<string>>();

            for (int i = 0; i < number; i++)
            {
                string word = Console.ReadLine();
                string sinonim = Console.ReadLine();

                if (!result.ContainsKey(word))
                {
                    result.Add(word, new List<string>());
                }
                result[word].Add(sinonim);               
            }

            foreach (var current in result)
            {
                string getWord = current.Key;

                var getSinonims = current.Value;

                Console.WriteLine("{0} - {1}",getWord,string.Join(", ",getSinonims));
            }
        }
    }
}
