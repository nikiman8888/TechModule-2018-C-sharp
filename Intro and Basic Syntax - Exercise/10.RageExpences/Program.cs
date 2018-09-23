using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _10.RageExpences
{
    class Program
    {
        static void Main(string[] args)
        {
            int gamesCount = int.Parse(Console.ReadLine());

            double headSetPrice = double.Parse(Console.ReadLine(), NumberFormatInfo.InvariantInfo);

            double mousePrice = double.Parse(Console.ReadLine(), NumberFormatInfo.InvariantInfo);

            double keyboardPrice = double.Parse(Console.ReadLine(), NumberFormatInfo.InvariantInfo);

            double displayPrice = double.Parse(Console.ReadLine(), NumberFormatInfo.InvariantInfo);

            double damage = 0;

            bool trashHeadset = false;

            bool trashMouse = false;

            int countKeyBooardTrash = 0;

            for (int i = 1; i <= gamesCount; i++)
            {
                if (i % 2 == 0 )
                {
                    damage += headSetPrice;

                    trashHeadset = true;
                }
                if (i % 3 == 0)
                {
                    damage += mousePrice;

                    trashMouse = true;
                }

                if (trashHeadset && trashMouse)
                {
                    damage += keyboardPrice;

                    countKeyBooardTrash++;
                }
                trashHeadset = false;

                trashMouse = false;

                if (countKeyBooardTrash == 2)
                {
                    damage += displayPrice;

                    countKeyBooardTrash = 0;
                }
            }

            Console.WriteLine("Rage expenses: {0:F2} lv.",damage);
        }
    }
}
