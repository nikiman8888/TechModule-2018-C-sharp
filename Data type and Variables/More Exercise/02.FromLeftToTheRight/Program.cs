using System;
using System.Globalization;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Numerics;

namespace _02.FromLeftToTheRight
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            int numberCount = int.Parse(Console.ReadLine());

            BigInteger sum = 0;

            

            for (int i = 0; i < numberCount; i++)
            {
                string[] numbers = Console.ReadLine().Split(' ');

                string firstNumber = numbers[0];

                string secondNumber = numbers[1];

                BigInteger first = BigInteger.Parse(firstNumber);

                BigInteger second = BigInteger.Parse(secondNumber);

                if (first >= second)
                {
                    sum = GetDigits(first);
                }
                else
                {
                    sum = GetDigits(second);
                }

                Console.WriteLine(sum);
            }

        }

        private static BigInteger GetDigits(BigInteger number)
        {
            BigInteger temp = 0;
            
            if (number < 0)
            {
                while (number != 0)
                {
                    string check = number.ToString();
                    

                    temp += BigInteger.Abs(number % 10);

                    number /= 10;

                }
            }
            else
            {
                while (number != 0)
                {
                    temp += number % 10;

                    number /= 10;
                }
            }

            return temp;
        }                                       
    }
}
