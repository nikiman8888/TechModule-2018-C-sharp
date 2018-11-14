using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Threading;
using System.Text;
using System.Text.RegularExpressions;

namespace _01.ExtractPersonInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string currentText = Console.ReadLine();

                int indexMonkey = currentText.IndexOf('@');
                int indexOfEndLine = currentText.IndexOf('|');

                string currentName = currentText.Substring(indexMonkey + 1,indexOfEndLine - (indexMonkey+1));

                int indexSharp = currentText.IndexOf('#');
                int indexStar = currentText.IndexOf('*');

                string currentAge = currentText.Substring(indexSharp + 1, indexStar - (indexSharp + 1));
                
                Console.WriteLine($"{currentName} is {currentAge} years old.");
            }
        }
    }
}
