using System;
using System.Globalization;

namespace _04.Back_In_30_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            string hours = Console.ReadLine();

            string minutes = Console.ReadLine();           
        
            string concat = hours + ":" + minutes;

            string patern = hours.Length == 1 ? "H:mm" : "HH:mm";

            var time = DateTime.ParseExact(concat, patern, null);

            time =  time.AddMinutes(30);

            Console.WriteLine($"{time.Hour}:{time.Minute:D2}");

           
        }
    }
}
