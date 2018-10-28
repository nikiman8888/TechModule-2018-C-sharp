using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace _03.Take_SkipRope
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            List<char> digits = text.Where(x => char.IsDigit(x)).ToList();

            List<char> letters = text.Where(x => !char.IsDigit(x)).ToList();

            string getLetters = GetOnlyLetters(letters);

            var take = new List<int>();
            var skip = new List<int>();

            for (int i = 0; i < digits.Count; i++)
            {
                int currentNumber = int.Parse(digits[i].ToString());
                if (i % 2 == 0)
                {
                    take.Add(currentNumber);
                }
                else
                {
                    skip.Add(currentNumber);
                }
          
            }
            int digitListsLength = take.Count();

            string result = "";


            for (int i = 0; i < digitListsLength; i++)
            {
                int currentTake = take[i];
                int currentSkip = skip[i];

                if (currentTake >= getLetters.Length)
                {
                    result += getLetters.Substring(0);
                    break;
                }
                result += getLetters.Substring(0, currentTake);

                getLetters = getLetters.Substring(currentTake + currentSkip);
            }
            Console.WriteLine(result);
        }

        private static string GetOnlyLetters(List<char> letters)
        {
            string temp = "";

            for (int i = 0; i < letters.Count; i++)
            {
                temp += letters[i];
            }
            return temp;
        }
    }
}
