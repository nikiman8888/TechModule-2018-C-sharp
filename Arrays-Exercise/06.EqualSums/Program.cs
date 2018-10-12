using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace _06.EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int leftSum = 0;

            int rightSum = 0;

            int haveIndex = 0;
            
            for (int i = 0; i < array.Length; i++)
            {
                int current = array[i];
                
                rightSum = array.Sum() - leftSum - current;
               
                if (rightSum == leftSum)
                {
                    haveIndex = i;
                    Console.WriteLine(haveIndex);
                    
                    return;
                }

                leftSum += current;
            }

            if (leftSum != rightSum)
            {
                Console.WriteLine("no");
                return;
            }
            if(leftSum == rightSum)
            {
                Console.WriteLine(0);

                
            }
        }
    }
}
