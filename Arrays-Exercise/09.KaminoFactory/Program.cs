using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace _09.KaminoFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenghtSequence = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();

            int bestLength = 0;

            string result = "";

            int countSequence = 0;

            int bestCountSequence = 0;

            int bestIndex = int.MaxValue;

            int bestSum = 0;

            while (input != "Clone them!")
            {
                string current = input.Replace("!", "");

                countSequence++;

                int currentLength = GetLength(current);

                int currentIndex = GetIndex(current, currentLength);

                int currentSum = GetSum(current);

                if (currentLength > bestLength)
                {
                    bestLength = currentLength;

                    bestCountSequence = countSequence;

                    bestIndex = GetIndex(current, currentLength);

                    result = current;

                    bestSum = currentSum;
                }
                else if (currentLength == bestLength)
                {

                    if (currentIndex < bestIndex)
                    {
                        bestLength = currentLength;

                        bestCountSequence = countSequence;

                        bestIndex = GetIndex(current, currentLength);

                        result = current;

                        bestSum = currentSum;
                    }
                    else if (currentIndex == bestIndex)
                    {                       

                        if (currentSum > bestSum)
                        {
                            bestLength = currentLength;

                            bestCountSequence = countSequence;

                            bestIndex = GetIndex(current, currentLength);

                            result = current;

                            bestSum = currentSum;
                        }
                    }
                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"Best DNA sample {bestCountSequence} with sum: {bestSum}.");
            Console.WriteLine(string.Join(" ", result.ToCharArray()));
        }
        private static int GetSum(string current)
        {
            int temp = 0;
            for (int i = 0; i < current.Length; i++)
            {
                int currentNumber = int.Parse(current[i].ToString());

                temp += currentNumber;
            }
            return temp;
        }

        private static int GetIndex(string current, int length)
        {
            string temp = "";
            for (int i = 0; i < length; i++)
            {
                temp += "1";
            }

            int index = current.IndexOf(temp);

            return index;
        }

        private static int GetLength(string current)
        {
            int counter = 0;
            int bestLength = 0;
            bool haveOne = false;

            for (int i = 0; i < current.Length; i++)
            {
                string currentSymbol = current[i].ToString();


                if (currentSymbol == "1")
                {
                    counter++;
                    if (i == current.Length - 1)
                    {
                        if (bestLength < counter)
                        {
                            bestLength = counter;
                            break;
                        }
                    }
                }
                else
                {
                    if (counter > bestLength)
                    {
                        bestLength = counter;
                    }
                    counter = 0;
                }
            }
            return bestLength;
        }
    }
}
