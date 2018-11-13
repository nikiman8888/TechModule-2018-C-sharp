using System;
using System.Globalization;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

namespace _04.CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {
                int current = text[i] + 3;

                char convert = (char)current;

                sb.Append(convert);
                
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
