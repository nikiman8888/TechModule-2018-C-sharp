using System;
using System.Globalization;

namespace _06.ForeignLanguages
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
        
            if (input =="USA" || input == "England")
            {
                Console.WriteLine("English");
            }
            else if (input =="Spain" || input =="Argentina" || input == "Mexico")
            {
                Console.WriteLine("Spanish");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
