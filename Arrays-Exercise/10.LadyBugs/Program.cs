using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace _10.LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[] ladybugsPosition = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int [] field = new int[size];

            for (int i = 0; i < ladybugsPosition.Length; i++)
            {
                int currentBugs = ladybugsPosition[i];

                if (currentBugs >=0 && currentBugs < field.Length)
                {
                    field[currentBugs] = 1;
                }
            }

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] tokens = input.Split(' ');

                int start =int.Parse( tokens[0]);

                string direction = tokens[1];

                int steps = int.Parse(tokens[2]);

                if (start >= 0 && start < field.Length)
                {
                    if (field[start] == 1)
                    {
                        switch (direction)
                        {
                            case "right":
                                if (steps < 0)
                                {
                                    steps = Math.Abs(steps);

                                    field = GetLeft(start, steps, field);

                                    input = Console.ReadLine();
                                    continue;
                                }

                                field = GetRight(start, steps, field);
                                break;
                            case "left":
                                if (steps < 0)
                                {
                                    steps = Math.Abs(steps);

                                    field = GetRight(start, steps, field);

                                    input = Console.ReadLine();
                                    continue;
                                }

                                field = GetLeft(start, steps, field);
                                break;                            
                        }
                    }
                }

                input = Console.ReadLine();
            }

            for (int i = 0; i < field.Length; i++)
            {
                if (field[i] != 1)
                {
                    Console.Write(0 + " ");
                    continue;
                }

                Console.Write(field[i]+ " ");
            }
            Console.WriteLine();
        }

        private static int[] GetLeft(int start, int steps, int[] field)
        {
            field[start] = 0;

            while (true)
            {
                if (start - steps >= 0)
                {
                    if (field[start - steps] == 0)
                    {
                        field[start - steps] = 1;

                        break;
                    }
                    else
                    {
                        start -= steps;
                    }
                }
                else
                {
                    break;
                }
            }
            return field;
        }

        private static int[] GetRight(int start, int steps, int[] field)
        {
            field[start] = 0;

            while (true)
            {
                if (start + steps < field.Length)
                {

                    if (field[start+steps] == 0)
                    {
                        field[start + steps] = 1;

                        break;
                    }
                    else
                    {
                        start += steps; 
                    }

                }
                else
                {
                    break;
                }
            }
            return field;
        }
    }
}
