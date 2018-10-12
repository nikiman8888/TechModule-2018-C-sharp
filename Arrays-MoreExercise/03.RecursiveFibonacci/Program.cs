using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace _03.RecursiveFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {

            int searchedNumber = int.Parse(Console.ReadLine());
          
            var result = new List<long> {0 , 1};

            int index = 0;

            if (searchedNumber >=0 && searchedNumber <= 50)
            {
                while (index < searchedNumber)
                {
                    long numberToInsert = result[index] + result[index + 1];

                    result.Add(numberToInsert);

                    index++;

                }
                Console.WriteLine(result[searchedNumber]);
            }                                               
        }
    }
}
