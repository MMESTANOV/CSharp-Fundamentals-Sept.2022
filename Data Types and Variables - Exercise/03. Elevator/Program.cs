using System;

namespace _03._Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            Console.WriteLine((int)Math.Ceiling((double)numberOfPeople/capacity));
        }
    }
}
