using System;
using System.Globalization;
using System.Threading;
using System.Collections.Generic;
using System.Linq;

namespace _05.DragonArmy
{    
    class Program
    {
        static void Main(string[] args)
        {
            int dragonCount = int.Parse(Console.ReadLine());

            int defaultHealth = 250;
            int defaultDamage = 45;
            int defaultArmor = 10;

            var result = new Dictionary<string, List<Dragon>>();

            for (int i = 0; i < dragonCount; i++)
            {
                string[] currentDragon = Console.ReadLine().Split(' ').ToArray();

                string curentColor = currentDragon[0];

                string currentName = currentDragon[1];

                string currentDamage = currentDragon[2];

                string currentHealth = currentDragon[3];
                
                string currentArmor = currentDragon[4];

                int convertHealth, convertDamage, convertArmor;

                int resultDamage = Int32.TryParse(currentDamage, out convertDamage) ? convertDamage : defaultDamage;
                int resultHealth = Int32.TryParse(currentHealth, out convertHealth) ? convertHealth : defaultHealth;
                int resultArmor = Int32.TryParse(currentArmor, out convertArmor) ? convertArmor : defaultArmor;
                               
                Dragon createDragon = new Dragon(currentName, resultHealth, resultDamage,resultArmor);

                bool replacement = false;

                if (!result.ContainsKey(curentColor))
                {
                    result.Add(curentColor, new List<Dragon>());
                }
                foreach (var dragon in result[curentColor])
                {
                    if (dragon.Name == createDragon.Name)
                    {
                        dragon.Health = createDragon.Health;
                        dragon.Damage = createDragon.Damage;
                        dragon.Armor = createDragon.Armor;

                        replacement = true;
                        break;
                    }
                }
                if (!replacement)
                {
                    result[curentColor].Add(createDragon);
                }
            }
            foreach (var dragonsData in result)
            {
                string type = dragonsData.Key;

                var dragons = dragonsData.Value;

                double damageAverage = dragons.Average(x => x.Damage);
                double healthAverage = dragons.Average(x => x.Health);
                double armorAverage = dragons.Average(x => x.Armor);

                Console.WriteLine($"{type}::({damageAverage:F2}/{healthAverage:F2}/{armorAverage:F2})");

                foreach (var dragon in dragons.OrderBy(x=>x.Name))
                {
                    Console.WriteLine($"-{dragon.Name} -> damage: {dragon.Damage}, health: {dragon.Health}, armor: {dragon.Armor}");
                }
            }
        }
    }
    class Dragon
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Damage { get; set; }
        public int Armor { get; set; }

        public Dragon(string name, int health, int damage, int armor)
        {
            this.Name = name;
            this.Health = health;
            this.Damage = damage;
            this.Armor = armor;
        }
    }
}


