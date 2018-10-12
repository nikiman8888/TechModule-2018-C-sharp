using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace _02.PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            var list = new List<int> { 1, 1 };

            Console.WriteLine(1);

            if (count > 1)
            {
                Console.WriteLine(string.Join(" ", list));

                for (int i = 0; i < count - 2; i++)
                {
                    var temp = new List<int>();

                    int numberToInsert = 0;

                    for (int k = 0; k < list.Count; k++)
                    {
                        if (k == list.Count - 1)
                        {
                            break;
                        }
                        numberToInsert = list[k] + list[k + 1];
                        temp.Add(numberToInsert);
                    }
                    list.RemoveRange(1, list.Count - 2);
                    list.InsertRange(1, temp);
                    Console.WriteLine(string.Join(" ", list));
                }
            }
            
        }
    }
}
