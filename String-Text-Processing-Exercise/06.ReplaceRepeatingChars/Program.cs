using System;
using System.Globalization;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;
using System.Numerics;

namespace _06.ReplaceRepeatingChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine();

            var sb = new StringBuilder();            

            for (int i = 0; i < inputText.Length; i++)
            {
                if (i == inputText.Length- 1)
                {
                    sb.Append(inputText[i]);
                    break;
                }
                char currentChar = inputText[i];
               
                char nextChar = inputText[i + 1];

                if (currentChar != nextChar)
                {
                    sb.Append(currentChar);
                }                
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
