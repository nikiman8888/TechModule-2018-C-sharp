using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace _08.AnonymousThreat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inputData = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string input = Console.ReadLine();

            while (input != "3:1")
            {
                string[] tokens = input.Split(' ');

                string command = tokens[0];

                switch (command)
                {
                    case "merge":

                        int startIndex = int.Parse(tokens[1]);

                        if (startIndex < 0 || startIndex > inputData.Count -1)
                        {
                            startIndex = 0;
                        }

                        int endIndex = int.Parse(tokens[2]);

                        if (endIndex >inputData.Count -1 ||  endIndex < 0)
                        {
                            endIndex = inputData.Count - 1;
                        }
                        inputData = MergeIt(inputData, startIndex, endIndex);
                        break;
                    case "divide":

                        int index = int.Parse(tokens[1]);
                        int partitions = int.Parse(tokens[2]);

                        inputData = DivideIt(inputData, index, partitions);

                        break;
                }


                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ",inputData));
        }

        private static List<string> DivideIt(List<string> inputData, int index, int partitions)
        {
            string getPart = inputData[index];

            var temp = new List<string>();

            if (getPart.Length % partitions == 0)   // if even we just delete to same parts
            {
                int partLength = getPart.Length / partitions;

                string currentPart = ""; 
                    
                for (int i = 0; i < getPart.Length; i++)
                {                   
                    currentPart += getPart[i].ToString();
                    if (currentPart.Length == partLength)
                    {
                        temp.Add(currentPart);
                        currentPart = "";
                    }
                }
                inputData.RemoveAt(index);
                inputData.InsertRange(index, temp);
            }
            else                                                   // not even we need to leave last part bigger
            {
                int part = getPart.Length / partitions;

                string currentPart = "";

                int countLetters = 0;  // we need to count letters of the parts

                for (int i = 0; i < getPart.Length; i++)
                {
                    int lastPart = getPart.Length - ((partitions - 1) * part);  // find the length of last part

                    currentPart += getPart[i].ToString();
                    
                    if (currentPart.Length == part)    // start to fill parts in temp List
                    {
                        temp.Add(currentPart);
                        currentPart = "";
                        countLetters += part;
                    }
                    if (countLetters + lastPart == getPart.Length)  // if is same we need to get lastPart
                    {
                        currentPart = getPart.Substring(i+1); // i + 1 because we cut the last part from nextindex to the end
                        temp.Add(currentPart);
                        break;
                    }

                }
                inputData.RemoveAt(index);
                inputData.InsertRange(index, temp);
            }
            return inputData;
        }

        private static List<string> MergeIt(List<string> inputData, int startIndex, int endIndex)
        {
            string temp = "";

            for (int i = startIndex; i <=  endIndex; i++)
            {
                temp += inputData[i];
            }
            inputData.RemoveRange(startIndex, endIndex - startIndex+1);
          
            inputData.Insert(startIndex, temp);
           
            return inputData;
        }
    }
}
