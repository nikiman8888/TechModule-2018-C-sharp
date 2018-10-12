using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace _04.LongestIncreasing_Subsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputData = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            List<int> lis = new List<int>();

            int bestLength =  0;

            if (inputData.Count == 1)
            {
                Console.WriteLine(inputData[0]);
                return;
            }
            else
            {
                for (int i = 0; i < inputData.Count; i++)
                {
                    if (i == inputData.Count - 1)
                    {
                        break;
                    }
                    int compareNumber = inputData[i];

                    List<int> temp = new List<int> {compareNumber};

                    for (int j = i + 1; j < inputData.Count; j++)
                    {
                        int currentNum = inputData[j];

                        if (temp.Contains(currentNum))
                        {
                            continue;
                        }

                        if (compareNumber < currentNum)
                        {
                            temp.Add(currentNum);

                            compareNumber = currentNum;
                        }
                        else if (compareNumber > currentNum)
                        {
                            if (currentNum < temp[0])
                            {
                                continue;
                            }
                            else
                            {
                                int numbersForDelete = GetNumbersForDelete(temp, currentNum);

                                int numberOfIncreacingElementsLeft = GetIncreasingElementsLeft(inputData, j);

                                if (numbersForDelete >= numberOfIncreacingElementsLeft)
                                {
                                    continue;
                                }
                                else
                                {
                                    for (int k = 0; k < numbersForDelete; k++)
                                    {
                                        temp.RemoveAt(temp.Count - 1);
                                    }
                                    temp.Add(currentNum);
                                    //Console.WriteLine(string.Join(" ",temp));
                                    compareNumber = currentNum;
                                }
                            }
                        }

                        
                    }
                    if (temp.Count > bestLength)
                    {
                        bestLength = temp.Count;

                        lis = temp;
                    }

                }
                Console.WriteLine(string.Join(" ",lis));
            }
           
        }

        private static int GetIncreasingElementsLeft(List<int> inputData, int j)
        {
            int counter = 1;
            int startNumber = inputData[j];

            for (int i = j; i < inputData.Count; i++)
            {
                if (inputData[i] > startNumber)
                {
                    counter++;
                    
                }
            }
            return counter;
        }

        private static int GetNumbersForDelete(List<int> temp, int currentNum)
        {
            int counter = 0;
            for (int i = temp.Count -1; i > 0; i--)
            {
                int currentNumInArray = temp[i];

                if ( currentNumInArray <= currentNum)
                {
                    break;
                }
                counter++;
            }
            return counter;
        }
    }
}
