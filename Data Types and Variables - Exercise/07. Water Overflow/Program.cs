using System;

namespace _07._Water_Overflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int n = int.Parse(Console.ReadLine());
            

            int sumQuatities = 0;

            for (int i = 1; i <= n; i++)
            {
                int quantitiesOfWater = int.Parse(Console.ReadLine());
                sumQuatities += quantitiesOfWater;

                if (quantitiesOfWater > 255 || sumQuatities > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                    sumQuatities -= quantitiesOfWater;
                }

            }
            
            if (sumQuatities <= 255)
            {
                Console.WriteLine(sumQuatities);
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
