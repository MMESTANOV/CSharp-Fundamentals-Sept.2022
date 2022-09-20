using System;

namespace _02.Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputNum = int.Parse(Console.ReadLine());
            int number = 0;  

            if (inputNum % 10 == 0)
            {
                number = 10;
                Console.WriteLine($"The number is divisible by {number}");
            }
            else if (inputNum % 7 == 0)
            {
                number = 7;
                Console.WriteLine($"The number is divisible by {number}");
            }
            else if (inputNum % 6 == 0)
            {
                number = 6;
                Console.WriteLine($"The number is divisible by {number}");
            }
            else if (inputNum % 3 == 0)
            {
                number = 3;
                Console.WriteLine($"The number is divisible by {number}");
            }
            else if (inputNum % 2 == 0)
            {
                number = 2;
                Console.WriteLine($"The number is divisible by {number}");
            }
            else
            {
                Console.WriteLine("Not divisible");
            }
            
        }
    }
}
