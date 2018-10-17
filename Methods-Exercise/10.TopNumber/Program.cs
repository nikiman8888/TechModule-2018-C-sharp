using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Threading;
using System.Text.RegularExpressions;

namespace _10.TopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number ; i++)
            {
                bool result = GetMasterNumbers(i);

                if (result)
                {
                    Console.WriteLine(i);
                }
            }           
        }

        private static bool GetMasterNumbers(int number)
        {
            bool temp = false;

            bool haveOddDigit = false;

            var result = new List<int>();

            int sum = 0;

            while (number != 0)
            {
                int lastDigit = Math.Abs(number % 10);

                sum += lastDigit;

                number /= 10;
                if (lastDigit % 2!= 0)
                {
                    haveOddDigit = true;
                }
            }
                       
            if (sum % 8 == 0 && haveOddDigit)
            {
                temp = true;
            }
            return temp;
            
        }
    }
}
