using System;
using System.Globalization;
using System.Threading;
using System.Collections.Generic;
using System.Linq;

namespace _02.AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = new Dictionary<string, int>();

            while (true)
            {
                string material = Console.ReadLine();
                

                if (material == "stop" )
                {
                    break;
                }

                int quanity = int.Parse(Console.ReadLine());

                if (!result.ContainsKey(material))
                {
                    result.Add(material,0);
                }
                result[material] += quanity;

            }
            foreach (var current in result)
            {
                Console.WriteLine($"{current.Key} -> {current.Value}");
            }
        }
    }
}
