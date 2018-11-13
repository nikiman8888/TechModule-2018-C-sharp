using System;
using System.Globalization;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;
using System.Numerics;

namespace _05.MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string bigNumber = Console.ReadLine();

            int secondNumber = int.Parse(Console.ReadLine());

            string result = "";
            int firstDigit = 0;
           
            for (int i = bigNumber.Length - 1; i >= 0; i--)
            {
                int currentDigit = int.Parse(bigNumber[i].ToString());

                int multiplyBySecondNumber = currentDigit * secondNumber;

                multiplyBySecondNumber += firstDigit;

                if (multiplyBySecondNumber < 10)
                {
                    result = multiplyBySecondNumber + result;
                }
                else if (multiplyBySecondNumber >= 10)
                {
                    int secondDigit = multiplyBySecondNumber % 10;

                    result = secondDigit + result;

                    
                }
                firstDigit = multiplyBySecondNumber / 10;
            }
            if (firstDigit != 0)
            {
                result = firstDigit + result; // if is not zero we concat because number cant start with 0111 sample
            }
                           
            if (result.All(x=>x == '0')) //if all string is 000000.... result = 0 
                
            {
                result = "0";
                Console.WriteLine(result);
                return;
            }
            
            else
            {                
                if (result[0] == '0')
                {
                    for (int i = 0; i < result.Length; i++) // clean all leading zeroes
                    {
                        if (result[i] == '0')
                        {
                            result = result.Substring(1);
                            i = -1;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                Console.WriteLine("{0:D1}",result);
            }
            
        }
    }
}
