using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _05.Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = Console.ReadLine();

            string password = ReversePass(userName);

            int counter = 0;

            while(true)
            {
                string inputPassword = Console.ReadLine();

                counter++;

                if (inputPassword == password)
                {
                    Console.WriteLine("User {0} logged in.",userName);
                    return;
                }
                if (counter == 4)
                {
                    Console.WriteLine("User {0} blocked!",userName);
                    return;
                }
                else
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }
                
            }
        }

        private static string ReversePass(string userName)
        {
            string temp = "";

            for (int i = userName.Length -1; i >= 0; i--)
            {
                temp += userName[i];
            }
            return temp;
        }
    }
}
