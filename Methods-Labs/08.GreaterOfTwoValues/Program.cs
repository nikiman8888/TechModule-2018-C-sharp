using System;
using System.Globalization;
using System.Threading;
using System.Collections.Generic;
using System.Linq;

namespace _08.GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine().ToLower();

            string first = Console.ReadLine();

            string second = Console.ReadLine();

            string result = GetMax(type, first, second);

            Console.WriteLine(result);

        }

        private static string GetMax(string type, string first, string second)
        {
            string result = "";
           if (type == "int")
           {
                int getFirst = int.Parse(first);
                int getSecond = int.Parse(second);

                if (getFirst >= getSecond)
                {
                    result = first;
                }
                else
                {
                    result = second;
                }
            }
           else if (type == "char")
            {
                if (char.Parse(first) >= char.Parse(second))
                {
                    result = first;
                }
                else
                {
                    result = second;
                }
            }
           else if (type == "string")
            {
               

                if (first.CompareTo(second) >= 0)
                {
                    result = first;
                }
                else
                {
                    result = second;
                }
            }
            return result;
        }

        private static int GetSum(string first)
        {
            int temp = 0;
            for (int i = 0; i < first.Length; i++)
            {
                temp += first[i];
            }
            return temp;
        }
    }
}
