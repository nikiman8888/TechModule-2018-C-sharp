using System;
using System.Globalization;
using System.Threading;
using System.Collections.Generic;
using System.Linq;

namespace _02.OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split().ToList();

            var result = new Dictionary<string, int>();

            foreach (var currentText in input)
            {

                string word = currentText.ToLower();

                if (!result.ContainsKey(word))
                {

                    result.Add(word, 0);
                }
                result[word] += 1;
            }

            foreach (var text in result)
            {
                string getKey = text.Key;

                int getValue = text.Value;

                if (getValue % 2 != 0)
                {
                    Console.Write(getKey.ToLower() + " ");
                }
            }
        }
    }
}
