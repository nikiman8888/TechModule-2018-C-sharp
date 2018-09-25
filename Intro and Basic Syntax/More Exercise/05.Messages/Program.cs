using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _05.Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            int countTyping = int.Parse(Console.ReadLine());

            List<string> saveLetters = new List<string> {
                " ",
                null,
                "abc",
                "def",
                "ghi",
                "jkl",
                "mno",
                "pqrs",
                "tuv",
                "wxyz"
            };
            List<string> result = new List<string>();
       
            for (int i = 0; i < countTyping; i++)
            {
                string currentNumber = Console.ReadLine();

                string firstChar = currentNumber.Substring(0, 1);

                int countDigits = currentNumber.Count(x =>x.ToString() == firstChar); //check all digits same or not

                if (countDigits == currentNumber.Length)     
                {
                    int mainDigit = int.Parse(firstChar);

                    int indexLetter = 0;

                    if (mainDigit != 1)
                    {
                        indexLetter = currentNumber.Length - 1;


                        string getNeededLeters = saveLetters[mainDigit];

                        string charToPrint = getNeededLeters[indexLetter].ToString();

                        result.Add(charToPrint);
                    }
                }
                               
            }
            Console.WriteLine(String.Join("",result));
            
        }
    }
}
