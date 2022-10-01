﻿using System;
using System.Linq;

namespace _05._Top_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                    .Split(" ")
                    .Select(int.Parse)
                    .ToArray();

            for (int i = 0; i < arr.Length; i++)
            {
                int currentNum = arr[i];

                bool topInt = true;
                for (int j = i+1; j < arr.Length; j++)
                {
                    int nextNum = arr[j];

                    if(nextNum >= currentNum)
                    {
                        topInt = false;
                        break;
                    }
                }
                if (topInt)
                {
                    Console.Write(currentNum + " ");
                }
            }
           
        }
    }
}
