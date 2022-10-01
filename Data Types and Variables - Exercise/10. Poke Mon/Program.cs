using System;

namespace _10._Poke_Mon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            int poked = 0;

            int firstN = n;
            while (n >= m)
            {
                int difference = n - m;
                n = difference;
                poked++;
                if (n == firstN / 2 && y > 0)
                {

                    n = n / y;

                }
            }

            Console.WriteLine(n);
            Console.WriteLine(poked);

        }
    }
}
