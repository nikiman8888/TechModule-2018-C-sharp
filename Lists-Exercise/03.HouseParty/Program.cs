using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace _03.HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            List<string> guest = new List<string>();

            for (int i = 0; i < count; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string guestName = input[0];

                string comeOrNot = input[2];

                if (comeOrNot == "going!")
                {
                    if (guest.Contains(guestName))
                    {
                        Console.WriteLine($"{guestName} is already in the list!");
                    }
                    else
                    {
                        guest.Add(guestName);
                    }
                }
                else if (comeOrNot == "not")
                {
                    if (guest.Contains(guestName))
                    {
                        guest.Remove(guestName);
                    }
                    else
                    {
                        Console.WriteLine($"{guestName} is not in the list!");
                    }
                }
            }
            Console.WriteLine(string.Join(Environment.NewLine,guest));
        }
    }
}
