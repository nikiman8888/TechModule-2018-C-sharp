using System;
using System.Globalization;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _01.DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            string data = Console.ReadLine();

            PrintResult(type, data);

            
        }

        private static void PrintResult(string type, string data)
        {
            
            if(type == "int")
            {
                int temp = int.Parse(data) * 2;

                Console.WriteLine(temp);
            }
            else if (type == "real")
            {
                decimal temp =Math.Round( decimal.Parse(data) * 1.5M,2);
                Console.WriteLine("{0:F2}",temp);
            }
            else
            {

                Console.WriteLine($"${data}$");                
            }
           
        }
    }
}
