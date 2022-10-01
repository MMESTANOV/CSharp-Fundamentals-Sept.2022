using System;

namespace _08._Beer_Kegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int n =  int.Parse(Console.ReadLine());

            double maxVolume = 0;
            string currentModel = "";

            for (int i = 1; i <= n; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double volume = Math.PI * (radius * radius) * height;

                if (volume > maxVolume)
                {
                    maxVolume = volume;
                    currentModel = model;
                }
            }
            
            Console.WriteLine(currentModel);
        }
    }
}
