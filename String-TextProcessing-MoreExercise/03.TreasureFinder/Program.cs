using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Threading;
using System.Text;
using System.Text.RegularExpressions;

namespace _03.TreasureFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] keys = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            string input = Console.ReadLine();

            string saveData = "";

            int indexKey = 0;

            while (input != "find")
            {
                for (int i = 0; i < input.Length; i++)
                {
                    char current = input[i];

                    int currentKey = keys[indexKey];

                    char decrease = (char)(current - currentKey);

                    saveData += decrease;

                    if (indexKey == keys.Length-1) // restart the keys from beginning
                    {
                        indexKey = 0;

                        continue;
                    }
                    indexKey++;
                }

                indexKey = 0; // prepare indexKey for next input text

                Regex treasure = new Regex(@"&([^&]+)&");  // match treasure 

                Regex coordinates = new Regex(@"<([^<>]+)>"); // match coordinates

                if (treasure.IsMatch(saveData) && coordinates.IsMatch(saveData)) // if we match treasure and coordinates
                {

                    string getTreasure = treasure.Match(saveData).Value;

                    getTreasure =  getTreasure.Replace("&", string.Empty); // remove the & from treasure 

                    string getCoordinates = coordinates.Match(saveData).Value;

                    getCoordinates =  getCoordinates.Replace("<", string.Empty); // remove < from coord.

                    getCoordinates =  getCoordinates.Replace(">", string.Empty); // remove > from coord.

                    Console.WriteLine($"Found {getTreasure} at {getCoordinates}"); 
                }
                saveData = "";  // restart the temporary string who is collecting the chars after decreasing

                input = Console.ReadLine();  // recieve next input text
            }
            
        }
    }
}
