using System;
using System.Linq;

namespace _04._Array_Rotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int[] arr = Console.ReadLine()
                    .Split(" ")
                    .Select(int.Parse)
                    .ToArray();

            int rotationQnt = int.Parse(Console.ReadLine());

            for (int r = 1; r <= rotationQnt; r++)
            {
                int el1 = arr[0];
                for (int i = 1; i < arr.Length; i++)
                {
                    arr[i - 1] = arr[i];
                }
                arr[arr.Length - 1] = el1;
            }

            Console.WriteLine(String.Join(" ",arr));
        }
    }
}
