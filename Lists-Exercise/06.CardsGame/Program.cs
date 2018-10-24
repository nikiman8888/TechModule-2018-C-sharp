using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace _06.CardsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstPlayer = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            List<int> secondPlayer = Console.ReadLine().Split(new char[] {' '},StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            int index = 0;

            while (true)
            {
                int first = firstPlayer[index];
                int second = secondPlayer[index];

                if (first == second)
                {
                    firstPlayer.RemoveAt(index);
                    secondPlayer.RemoveAt(index);
                    index--;
                }
                else if(first > second)
                {
                    firstPlayer.Add(first);
                    firstPlayer.Add(second);

                    firstPlayer.RemoveAt(index);
                    secondPlayer.RemoveAt(index);
                    index--;
                }
                else if (second >first)
                {
                    secondPlayer.Add(second);
                    secondPlayer.Add(first);

                    secondPlayer.RemoveAt(index);
                    firstPlayer.RemoveAt(index);
                    index--;
                }

                index++;
                if (firstPlayer.Count == 0 || secondPlayer.Count == 0)
                {
                    break;
                }
            }
            if(firstPlayer.Count == 0)
            {
                Console.WriteLine("Second player wins! Sum: {0}",secondPlayer.Sum());
            }
            else
            {
                Console.WriteLine("First player wins! Sum: {0}",firstPlayer.Sum());
            }
        }
    }
}
