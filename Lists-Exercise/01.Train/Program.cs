using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace _01.Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> train = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int capacity = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] tokens = input.Split(' ');

                if (tokens[0] == "Add")
                {
                    int wagonToAdd = int.Parse(tokens[1]);

                    train.Add(wagonToAdd);
                }
                else
                {
                    int passegersToAdd = int.Parse(tokens[0]);

                    for (int i = 0; i < train.Count; i++)
                    {
                        int currentWagonPassenger = train[i];

                        if (currentWagonPassenger + passegersToAdd <= capacity)
                        {
                            train[i] += passegersToAdd;
                            break;

                        }                       
                    }
                }               
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ",train));
        }
    }
}
