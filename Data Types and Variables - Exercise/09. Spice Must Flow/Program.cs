using System;
using System.Numerics;

namespace _09._Spice_Must_Flow
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int startingYield = int.Parse(Console.ReadLine());

            int days = 0;

            BigInteger sumMining = 0;

            if (startingYield < 100)
            {
                Console.WriteLine(days);
                Console.WriteLine(sumMining);
            }
            else
            {
                while (startingYield >= 100)
                {
                    sumMining += startingYield - 26;
                    startingYield -= 10;
                    days++;
                }

                sumMining -= 26;

                Console.WriteLine(days);
                Console.WriteLine(sumMining);
            }

        }
    }
}
