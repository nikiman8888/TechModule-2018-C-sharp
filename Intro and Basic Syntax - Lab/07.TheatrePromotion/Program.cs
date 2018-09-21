using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace _07.TheatrePromotion
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeDay = Console.ReadLine();

            double age = double.Parse(Console.ReadLine(), NumberFormatInfo.InvariantInfo);
          
            if (age < 0 || age > 122)
            {
                Console.WriteLine("Error!");
                return;
            }
            else
            {
                int price = 0;
                switch (typeDay)
                {
                    case "Weekday":
                        if (age >= 0 && age <= 18 || age > 64 && age <=122)
                        {
                            price = 12;
                        }
                        else
                        {
                            price = 18;
                        }
                        break;
                    case "Weekend":
                        if (age >= 0 && age <= 18 || age > 64 && age <= 122)
                        {
                            price = 15;
                        }
                        else
                        {
                            price = 20;
                        }
                        break;
                    case "Holiday":
                        if (age >= 0 && age <= 18 )
                        {
                            price = 5;
                        }
                        else if (age > 18 &&  age <= 64)
                        {
                            price = 12;
                        }
                        else
                        {
                            price = 10; 
                        }
                        break;
                        
                }
                Console.WriteLine("{0}$",price);
                              
            }
        }
    }
}
