using System;
using System.Globalization;
using System.Threading;
using System.Collections.Generic;
using System.Linq;

namespace _04.Snowwhite
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<Dwarfs> saveDawarfs = new List<Dwarfs>();

            while (input != "Once upon a time")
            {
                string[] tokens = input
                    .Split(new char[] { ' ', '<', ':', '>' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string currentName = tokens[0];

                string currentHatColor = tokens[1];

                long currentPower = long.Parse(tokens[2]);

                int countColors = saveDawarfs.Where(x => x.Color == currentHatColor).Count();

                Dwarfs createDwarf = new Dwarfs(currentName, currentHatColor, currentPower, countColors);

                bool matchDwarf = false;
                bool nameAndColorMatch = false;

                foreach (Dwarfs currentDwarf in saveDawarfs)
                {
                    if (createDwarf.Name == currentDwarf.Name)
                    {
                        if (createDwarf.Color == currentDwarf.Color)
                        {
                            nameAndColorMatch = true;

                            if (createDwarf.Power > currentDwarf.Power)
                            {
                                currentDwarf.Power = Math.Max(createDwarf.Power, currentDwarf.Power);

                                matchDwarf = true;
                                break;
                            }
                        }
                    }
                }
                if (matchDwarf == false && !nameAndColorMatch)
                {
                    saveDawarfs.Add(createDwarf);

                    for (int i = 0; i < saveDawarfs.Count; i++)
                    {
                        if (saveDawarfs[i].Color == createDwarf.Color)
                        {
                            saveDawarfs[i].Counter++;
                        }
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var dwarf in saveDawarfs.OrderByDescending(x => x.Power).ThenByDescending(x => x.Counter))
            {
                Console.WriteLine($"({dwarf.Color}) {dwarf.Name} <-> {dwarf.Power}");
            }
        }
    }
    class Dwarfs
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public long Power { get; set; }
        public int Counter { get; set; }

        public Dwarfs(string name, string color, long power, int counter)
        {
            this.Name = name;
            this.Color = color;
            this.Power = power;
            this.Counter = counter;
        }
    }
}


