using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace _09.PokemonDontGo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> pokemons = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            long sum = 0;

            while (true)
            {
                int currentIndex = int.Parse(Console.ReadLine());

                if (currentIndex >= 0 && currentIndex < pokemons.Count)
                {
                    int temp = pokemons[currentIndex];
                    pokemons.RemoveAt(currentIndex);

                    pokemons = IncreaseDecrease(pokemons, temp);

                    sum += temp;
                }
                else if (currentIndex < 0)
                {
                    int temp = pokemons[0];
                    pokemons[0] = pokemons[pokemons.Count - 1];

                    pokemons = IncreaseDecrease(pokemons, temp);

                    sum += temp;
                }
                else if (currentIndex > pokemons.Count -1)
                {
                    int temp = pokemons[pokemons.Count - 1];
                    pokemons[pokemons.Count - 1] = pokemons[0];

                    pokemons = IncreaseDecrease(pokemons, temp);

                    sum += temp;
                }
                if (pokemons.Count == 0)
                {
                    break;
                }
            }
            Console.WriteLine(sum);
        }

        private static List<int> IncreaseDecrease(List<int> pokemons, int temp)
        {
            for (int i = 0; i < pokemons.Count; i++)
            {
                if (pokemons[i] <= temp)
                {
                    pokemons[i] += temp;
                }
                else
                {
                    pokemons[i] -= temp;
                }
            }
            return pokemons;
        }
    }
}
