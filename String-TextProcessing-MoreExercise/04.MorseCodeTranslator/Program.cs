using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Threading;
using System.Text;
using System.Text.RegularExpressions;

namespace _04.MorseCodeTranslator
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] inputData = Console.ReadLine().Split('|');

            string result = "";

            var alphabet = new List<string> { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
            var morse = new List<string> { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.." };

            for (int i = 0; i < inputData.Length; i++)
            {
                string currentWord = inputData[i].Trim();

                string[] word = currentWord.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                for (int j = 0; j < word.Length; j++)
                {
                    string letter = word[j];

                    int indexMorse = morse.IndexOf(letter);

                    result += alphabet[indexMorse];
                }
                if (i == inputData.Length-1)
                {
                    continue;
                }
                result += " ";
            }
            Console.WriteLine(result);

        }
    }
}
