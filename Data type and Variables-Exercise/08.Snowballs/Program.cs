using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Numerics;

namespace _08.Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersBall = int.Parse(Console.ReadLine());

            BigInteger bestBall = 0;

            int bestSnowBallSnow = 0;

            int bestSnowTime = 0;

            int bestSnowQuality = 0;

            for (int i = 0; i < numbersBall; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());

                int snowballTime = int.Parse(Console.ReadLine());

                int snowballQuality = int.Parse(Console.ReadLine());

                BigInteger current = BigInteger.Pow((snowballSnow / snowballTime), snowballQuality);

                if (current > bestBall )
                {
                    bestSnowBallSnow = snowballSnow;

                    bestSnowTime = snowballTime;

                    bestSnowQuality = snowballQuality;

                    bestBall = current;
                }

            }
            Console.WriteLine($"{bestSnowBallSnow} : {bestSnowTime} = {bestBall} ({bestSnowQuality})");
        }
    }
}
