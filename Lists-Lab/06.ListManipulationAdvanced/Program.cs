using System;
using System.Globalization;
using System.Threading;
using System.Collections.Generic;
using System.Linq;

namespace _06.ListManipulationAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            List<double> inputData = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToList();

            string input = Console.ReadLine();

            bool change = false;

            while (input != "end")
            {
                string[] tokens = input.Split(' ');

                string command = tokens[0];

                switch (command)
                {
                    case "Add":

                        int addNumber = int.Parse(tokens[1]);

                        inputData.Add(addNumber);

                        change = true;

                        break;
                    case "Remove":

                        int numberToRemove = int.Parse(tokens[1]);

                        inputData.Remove(numberToRemove);

                        change = true;

                        break;
                    case "RemoveAt":

                        int indexToRemove = int.Parse(tokens[1]);

                        inputData.RemoveAt(indexToRemove);

                        change = true;

                        break;
                    case "Insert":

                        int numberToInsert = int.Parse(tokens[1]);

                        int index = int.Parse(tokens[2]);

                        inputData.Insert(index, numberToInsert);

                        change = true;

                        break;
                    case "Contains":

                        double containNumber = double.Parse(tokens[1]);
                        if (inputData.Contains(containNumber))
                        {
                            Console.WriteLine("Yes");
                        }
                        else
                        {
                            Console.WriteLine("No such number");
                        }
                        break;
                    case "PrintEven":

                        var tempEven = inputData.Where(x => x % 2 == 0).ToList();
                        Console.WriteLine(string.Join(" ",tempEven));

                        break;
                    case "PrintOdd":

                        var tempOdd = inputData.Where(x => x % 2 != 0).ToList();
                        Console.WriteLine(string.Join(" ", tempOdd));

                        break;
                    case "GetSum":

                        double allSum = inputData.Sum();
                        Console.WriteLine(allSum);

                        break;
                    case "Filter":

                        string sign = tokens[1];

                        double numberLevel = double.Parse(tokens[2]);

                        List<double> temp = new List<double>();
                        switch (sign)
                        {                          
                            case ">":
                                temp = inputData.Where(x => x > numberLevel).ToList();

                                break;
                            case "<":
                                temp = inputData.Where(x => x < numberLevel).ToList();

                                break;
                            case ">=":

                                temp = inputData.Where(x => x >= numberLevel).ToList();

                                break;
                            case "<=":

                                temp = inputData.Where(x => x <= numberLevel).ToList();

                                break;

                        }
                        Console.WriteLine(string.Join(" ",temp));

                        break;
                        
                }
                input = Console.ReadLine();
            }
            if (change)
            {
                Console.WriteLine(string.Join(" ",inputData));
            }
        }
    }
}
