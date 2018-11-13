using System;
using System.Globalization;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;
using System.Numerics;

namespace _10.WinningTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tickets = Console.ReadLine()
                .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();


            for (int i = 0; i < tickets.Length; i++)
            {

                string currentTicket = tickets[i];

                if (currentTicket.Length == 20)   // if is 20 length is valid ticket
                {
                    Regex dollar = new Regex(@"[$]{6,10}");   //create Regex paterns for the winning signs
                    Regex monkey = new Regex(@"[@]{6,10}");
                    Regex sharp = new Regex(@"[#]{6,10}");
                    Regex arrow = new Regex(@"[\^]{6,10}");

                    string firstPart = currentTicket.Substring(0, 10);  // separate ticket of two parts of 10
                    string secondPart = currentTicket.Substring(10);

                    if (dollar.IsMatch(firstPart) && dollar.IsMatch(secondPart)) // if match dollar patern
                    {
                        int counDollars = currentTicket.Where(x => x == '$').Count();  // get count of dollars

                        if (counDollars == 20)
                        {
                            Console.WriteLine($"ticket \"{currentTicket}\" - 10$ Jackpot!"); // count 20 jackpot
                        }

                        else           // count is not 20 so ..
                        {
                            string getFirst = dollar.Match(firstPart).Value;  // get only the signs wich are together
                            string getSecond = dollar.Match(secondPart).Value;
                            

                            Console.WriteLine($"ticket \"{currentTicket}\" - {Math.Min(getFirst.Count(),getSecond.Count())}$");
                    // we print the minimum  signs length from both tickets ,because can be 6 and 7, but the matching pieces is 6 <- sample
                        }
                    }
                    else if (monkey.IsMatch(firstPart) && monkey.IsMatch(secondPart))  // if match  monkey patern
                    {
                        int counMonkey = currentTicket.Where(x => x == '@').Count(); //get count monkey 

                        if (counMonkey == 20)
                        {
                            Console.WriteLine($"ticket \"{currentTicket}\" - 10@ Jackpot!"); // if count 20 Jackpot
                        }
                        else    //count is not 20 ..
                        {
                            string firstMatch = monkey.Match(firstPart).Value;   // get only sighn which are together
                            string secondMatch = monkey.Match(secondPart).Value;


                            Console.WriteLine($"ticket \"{currentTicket}\" - {Math.Min(firstMatch.Count(), secondMatch.Count())}@");  
                        }
                    }
                    else if (sharp.IsMatch(firstPart) && sharp.IsMatch(secondPart))  // if match  sharp patern
                    {
                        int countSharps = currentTicket.Where(x => x == '#').Count();  //get count of sharps 

                        if (countSharps == 20)
                        {
                            Console.WriteLine($"ticket \"{currentTicket}\" - 10# Jackpot!"); // if count 20 jackpot
                        }

                        else    //count is not 20 ...
                        {
                            string firstMatch = sharp.Match(firstPart).Value;  // get only signs wich are together
                            string secondMatch = sharp.Match(secondPart).Value;


                            Console.WriteLine($"ticket \"{currentTicket}\" - {Math.Min(firstMatch.Count(), secondMatch.Count())}#");
                        }
                    }
                    else if (arrow.IsMatch(firstPart) && arrow.IsMatch(secondPart))  // if match arrow patern
                    {
                        int countArrows = currentTicket.Where(x => x == '^').Count(); // get count of arrows

                        if (countArrows == 20)
                        {
                            Console.WriteLine($"ticket \"{currentTicket}\" - 10^ Jackpot!"); // if count 20 Jackpot
                        }

                        else       // count is not 20 ... 
                        {
                            string firstMatch = arrow.Match(firstPart).Value;  // get only signs which are together
                            string secondMatch = arrow.Match(secondPart).Value;


                            Console.WriteLine($"ticket \"{currentTicket}\" - {Math.Min(firstMatch.Count(), secondMatch.Count())}^");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"ticket \"{currentTicket}\" - no match");  // not match any winnig patern
                    }
                }
                else
                {
                    Console.WriteLine("invalid ticket");  // the length of ticket is not 20 - invalid ticket
                }
            }
        }
    }
}
