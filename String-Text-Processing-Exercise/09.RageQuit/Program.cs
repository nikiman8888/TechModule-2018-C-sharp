using System;
using System.Globalization;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;
using System.Numerics;

namespace _09.RageQuit
{
    class Program
    {
        static void Main(string[] args)
        {
            string inpuData = Console.ReadLine().ToUpper();

            var sb = new StringBuilder();
            
            string temp = "";  

            for (int i = 0; i < inpuData.Length; i++)
            {
                char current = inpuData[i];

                if (!char.IsDigit(current))
                {
                    temp += current;
                }
                else if (char.IsDigit(current))
                {
                    if (i < inpuData.Length-1) // not the end of the text
                    {
                        if (char.IsDigit(inpuData[i+1])) //if we have one more diggit after the current
                        {
                            string number = current.ToString() + inpuData[i + 1].ToString();// concat 2 digits

                            int repead = int.Parse(number);

                            for (int j = 0; j < repead; j++) //loop and append text  repead times
                            {
                                
                                sb.Append(temp);
                            }
                            temp = ""; //clean the temporary text container
                        }
                        else
                        {
                            int repead = int.Parse(current.ToString());  // if the digit is single (0-9)

                            for (int k = 0; k < repead; k++) //loop and append text  repead times
                            {
                                
                                sb.Append(temp);
                            }
                            temp = "";    //clean the temporary text container
                        }


                    }
                    else   // if index is last of the input text
                    {
                        int repead = int.Parse(current.ToString());   

                        for (int k = 0; k < repead; k++)   //loop and append text  repead times
                        {
                            sb.Append(temp);
                            
                        }
                        temp = ""; // clean the temporary text container
                    }
                }
            }           

            Console.WriteLine("Unique symbols used: {0}",sb.ToString().Distinct().Count()); // get unique simbols by Linq

            Console.WriteLine(sb.ToString()); // print all appended text
           
        }
    }
}
