﻿using System;

namespace _04._Sum_of_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int numberOfLines = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = 1; i <= numberOfLines; i++)
            {
                char letter = char.Parse(Console.ReadLine());
                
                 sum += (int)letter;
            }

            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
