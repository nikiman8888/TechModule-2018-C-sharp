using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace _02.ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> inputData = Console.ReadLine().Split(' ').Select(long.Parse).ToList();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] tokens = input.Split(' ');

                string command = tokens[0];

                switch (command)
                {
                    case "Delete":

                        long element = long.Parse(tokens[1]);

                        inputData = inputData.Where(x => x != element).ToList();
                        

                        break;
                    case "Insert":

                        element = int.Parse(tokens[1]);

                        int index = int.Parse(tokens[2]);
                        
                        inputData.Insert(index, element);
                        
                        break;                   
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ",inputData));
        }
    }
}
