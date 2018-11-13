using System;
using System.Globalization;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03.ExtractFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] path = Console.ReadLine().Split('\\').ToArray();

            string []fileAndExtension = path[path.Length - 1].Split('.');

            Console.WriteLine($"File name: {fileAndExtension[0]}");
            Console.WriteLine($"File extension: {fileAndExtension[1]}");

        }
    }
}
