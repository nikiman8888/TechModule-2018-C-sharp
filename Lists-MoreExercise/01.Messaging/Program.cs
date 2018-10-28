using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace _01.Messaging
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            string text = Console.ReadLine();

            string result = "";

            for (int i = 0; i < numbers.Count; i++)
            {
                int current = numbers[i];

                int currentSum = GetSum(current);

                int index = currentSum % text.Length;

                result += text[index];

                string temporary = "";

                for (int j = 0; j < text.Length; j++)
                {
                    if (j == index)
                    {
                        continue;
                    }
                    temporary += text[j];
                }
                text = temporary;
            }

            Console.WriteLine(result);
        }

        private static int GetSum(int current)
        {
            int temp = 0;
            while (current != 0)
            {
                temp += current % 10;
                current /= 10;
            }
            return temp;
                
        }
    }
}
