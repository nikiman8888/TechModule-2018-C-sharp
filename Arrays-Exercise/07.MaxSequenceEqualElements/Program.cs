using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace _07.MaxSequenceEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int currentSecuence = 1;

            int longestSequence = 1;

            int currentStartIndex = 0;

            int indexBestSequence = 0;
            
            

            if (array.Length > 1)
            {
                for (int i = 1; i < array.Length; i++)
                {
                    int previous = array[i - 1];

                    int current = array[i];

                    currentStartIndex = i - currentSecuence;

                    if (previous == current)
                    {
                        currentSecuence++;

                        if (currentSecuence > longestSequence)
                        {
                            longestSequence = currentSecuence;
                            indexBestSequence = currentStartIndex;

                        }
                        
                    }
                    else
                    {
                        currentSecuence = 1;
                        
                    }
                    
                }
                for (int i = indexBestSequence; i < indexBestSequence + longestSequence; i++)
                {
                    Console.Write(array[i] + " ");
                }
                return;
            }
            Console.WriteLine(array[0]);
            
            
        }
    }
}
