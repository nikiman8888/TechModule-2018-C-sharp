using System;
using System.Globalization;
using System.Threading;
using System.Collections.Generic;
using System.Linq;

namespace _11.MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            double firstNum = double.Parse(Console.ReadLine());

            string operators = Console.ReadLine();

            double secondNum = double.Parse(Console.ReadLine());

            PrintResult(firstNum, operators, secondNum);
        }

        private static void PrintResult(double firstNum, string operators, double secondNum)
        {

            double res = 0;
            switch (operators)
            {
                case "*":
                    res = firstNum * secondNum;
                    break;
                case "-":
                    res = firstNum - secondNum;
                    break;
                case "/":
                    res = firstNum / secondNum;
                    break;
                case "+":
                    res = firstNum + secondNum;
                    break;
                    
            }
            Console.WriteLine(res);
        }
    }
}
