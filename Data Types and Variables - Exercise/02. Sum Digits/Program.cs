using System;

namespace _02._Sum_Digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());
            int result = 0;

            
            while (inputNumber != 0)
            {
                result += inputNumber % 10;
                inputNumber /= 10;
            }

            Console.WriteLine(result);
        }
    }
}
