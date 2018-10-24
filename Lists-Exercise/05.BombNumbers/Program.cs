using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace _05.BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inpuData = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int[] specialNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int special = specialNumbers[0];

            int specialPower = specialNumbers[1];

            if (inpuData.Contains(special))
            {
                while (true)
                {
                    int indexOfSpecial = inpuData.IndexOf(special);

                    int startExplode = indexOfSpecial - specialPower;

                    if (startExplode < 0)
                    {
                        startExplode = 0;
                    }
                    int elementsToRemove = specialPower * 2 + 1; // get both side and the bomb

                    if ( startExplode + elementsToRemove > inpuData.Count) //if outside the array 
                    {
                        elementsToRemove = inpuData.Count - startExplode; // set elements to remove to the end of list
                    }
                    inpuData.RemoveRange(startExplode,elementsToRemove);

                    if (!inpuData.Contains(special))
                    {
                        break;
                    }
                }
            }
            int sum = inpuData.Sum();
            Console.WriteLine(sum);
            

        }
    }
}
