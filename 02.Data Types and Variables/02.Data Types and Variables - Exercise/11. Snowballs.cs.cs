using System;
using System.Numerics;

namespace _11._Snowballs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            sbyte snowbals = sbyte.Parse(Console.ReadLine());
            BigInteger snowballMaxValue = 0;    
            short biggestSnowballSnow = 0;
            short biggestSnowballTime = 0;
            byte biggestSnowbalQuality = 0;
            for (int i = 0; i < snowbals; i++)
            {
                short snowballSnow = short.Parse(Console.ReadLine());
                short snowballTime = short.Parse(Console.ReadLine());
                byte snowbalQuality = byte.Parse(Console.ReadLine());

                BigInteger snowballValue = BigInteger.Pow(snowballSnow / snowballTime, snowbalQuality) ;
                if (snowballValue > snowballMaxValue)
                {
                    snowballMaxValue = snowballValue;
                    biggestSnowballSnow = snowballSnow;
                    biggestSnowballTime = snowballTime;
                    biggestSnowbalQuality = snowbalQuality;
                }
                
            }
            Console.WriteLine($"{biggestSnowballSnow} : {biggestSnowballTime} = {snowballMaxValue} ({biggestSnowbalQuality})");

        //Memory: 0.00 MB
        //Time: 0.090 s
        // It was way more quicker when snowball is sbyte Type!
        }
    }
}