using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Numerics;

namespace _01.IntegerOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger firstNumber = BigInteger.Parse(Console.ReadLine());

            BigInteger secondNumber = BigInteger.Parse(Console.ReadLine());

            BigInteger thirdNumber = BigInteger.Parse(Console.ReadLine());

            BigInteger fourNumber = BigInteger.Parse(Console.ReadLine());

            BigInteger totalSum = firstNumber;

            totalSum += secondNumber;

            totalSum /= thirdNumber;

            totalSum *= fourNumber;

            Console.WriteLine(totalSum);

        }
    }
}


