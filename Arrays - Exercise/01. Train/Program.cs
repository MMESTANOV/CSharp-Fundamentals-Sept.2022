using System;

namespace _01._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] vagons = new int[n];
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                vagons[i] = int.Parse(Console.ReadLine());
                sum += vagons[i];
            }

            Console.WriteLine(String.Join(" ", vagons));
            Console.WriteLine(sum);
        }
    }
}
