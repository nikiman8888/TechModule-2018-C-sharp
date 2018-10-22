using System;
using System.Globalization;
using System.Threading;
using System.Collections.Generic;
using System.Linq;

namespace _05.ListManipulationBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputData = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] tokens = input.Split();

                string command = tokens[0];

                switch (command)
                {
                    case "Add":

                        int addNumber = int.Parse(tokens[1]);

                        inputData.Add(addNumber);

                        break;
                    case "Remove":

                        int numberToRemove = int.Parse(tokens[1]);

                        inputData.Remove(numberToRemove);

                        break;
                    case "RemoveAt":

                        int indexToRemove = int.Parse(tokens[1]);

                        inputData.RemoveAt(indexToRemove);

                        break;
                    case "Insert":

                        int numberToInsert = int.Parse(tokens[1]);

                        int index = int.Parse(tokens[2]);

                        inputData.Insert(index, numberToInsert);

                        break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ",inputData));
        }
    }
}
