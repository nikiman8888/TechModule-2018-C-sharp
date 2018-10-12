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

            List<int> lis = new List<int>();// list for the result

            int bestLength =  0; // best length of the current Lists

            if (inputData.Count == 1)
            {
                Console.WriteLine(inputData[0]);// if is one element in the input print it
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

                    List<int> temp = new List<int> {compareNumber};// create temp List to iterate in the second loop

                    for (int j = i + 1; j < inputData.Count; j++)
                    {
                        int currentNum = inputData[j];

                        if (temp.Contains(currentNum))// if contains we dont need it because is not increasing collection
                        {
                            continue;
                        }

                        if (compareNumber < currentNum)
                        {
                            temp.Add(currentNum); //just put in the current List

                            compareNumber = currentNum; // end the lasT add element become the start elem. for comparing
                        }
                        else if (compareNumber > currentNum)
                        {
                            if (currentNum < temp[0]) //if current is smaller than start element we dont need it 
                            {
                                continue;
                            }
                            else
                            {
                                int numbersForDelete = GetNumbersForDelete(temp, currentNum); // found the coun t of element we need to remove

                                int numberOfIncreacingElementsLeft = GetIncreasingElementsLeft(inputData, j);// here we found the number of encreasings element left to the end of inputCollection

                                if (numbersForDelete >= numberOfIncreacingElementsLeft)
                                {
                                    continue; // if this condition our index of number to remove is better so we dont delete
                                }
                                else // we need to change element,becouse we found better length of increasment
                                {
                                    for (int k = 0; k < numbersForDelete; k++)
                                    {
                                        temp.RemoveAt(temp.Count - 1); // remove one by one last elements
                                    }
                                    temp.Add(currentNum); //add just the current number and we continue to other elements checking
                                    
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
            int counter = 1; //count is one because we already start from the first element wich is bigger from the start of our temp collection
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
