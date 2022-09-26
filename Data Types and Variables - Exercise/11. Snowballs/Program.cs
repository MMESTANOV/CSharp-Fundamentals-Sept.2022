using System;
using System.Numerics;

namespace _11._Snowballs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            BigInteger maxValue = BigInteger.MinusOne;
           
            int maxSnow = 0;
            int maxTime = 0;
            int maxQty = 0;
            for (int i = 0; i < n; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQty = int.Parse(Console.ReadLine());

                BigInteger snowballValue = BigInteger.Pow((snowballSnow / snowballTime), snowballQty);

                if (snowballValue > maxValue)
                {
                    maxValue = snowballValue;
                    maxSnow = snowballSnow;
                    maxTime = snowballTime;
                    maxQty = snowballQty;
                }
            }

            Console.WriteLine($"{maxSnow} : {maxTime} = {maxValue} ({maxQty})");
        }
    }
}
