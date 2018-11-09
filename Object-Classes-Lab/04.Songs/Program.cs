using System;
using System.Globalization;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace _04.Songs
{
    class Program
    {
        static void Main(string[] args)
        {
            int songCount = int.Parse(Console.ReadLine());

            var result = new List<Song>();

            for (int i = 0; i < songCount; i++)
            {
                string[] tokens = Console.ReadLine().Split('_').ToArray();

                string type = tokens[0];
                string name = tokens[1];
                string time = tokens[2];

                var currentSong = new Song(type, name, time);

                result.Add(currentSong);
            }

            string query = Console.ReadLine();
            
            if (query == "all")
            {
                foreach (var song in result)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach (var song in result)
                {
                    if (song.TypeList == query)
                    {
                        Console.WriteLine(song.Name);
                    }
                }
            }
        }
    }
    class Song
    {
        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }

        public Song(string type, string name, string time)
        {
            this.TypeList = type;
            this.Name = name;
            this.Time = time;
        }

        
    }
}
