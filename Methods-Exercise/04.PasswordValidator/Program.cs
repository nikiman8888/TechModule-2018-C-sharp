using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Threading;
using System.Text.RegularExpressions;

namespace _04.PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            bool length = true;
            bool letters = true;
            bool digits = true;

            length = GetLength(password);
            if (!length)
            {
                Console.WriteLine("Password must be between 6 and 10 characters ");
            }

            letters =  CheckLetters(password);
            if (!letters)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }

            digits = GetDigits(password);
            if (!digits)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
            if (letters && length && digits)
            {
                Console.WriteLine("Password is valid");
            }

            
        }

        private static bool CheckLetters(string password)
        {
            int countLetters = 0;
            int countDigits = 0;
            bool res = true;

            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsLetter(password[i]))
                {
                    countLetters++;
                }
                if (char.IsDigit(password[i]))
                {
                    countDigits++;
                }
            }
            if (countLetters + countDigits != password.Length)
            {
                res = false;
            }
            return res;
        }

        private static bool GetDigits(string password)
        {
            int digits = password.Where(x => char.IsDigit(x)).Count();
            bool res = true;

            if (digits < 2)
            {
                res = false;
            }
            return res;
        }

        private static bool GetLength(string password)
        {
            bool res = true;
            if (password.Length <  6 || password.Length > 10)
            {
                res = false;
            }
            return res;
        }
    }
}
