using System;

namespace _05._Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = string.Empty;

            int cnt = 0;

            for (int i = username.Length -1; i >= 0; i--)
            {
                char cCh = username[i];
                password += cCh;
            }
            string entPass;
            while ((entPass=Console.ReadLine()) != password)
            {
                
                cnt++;
                if (cnt >= 4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    return;
                }
                else
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }
                                     
            }
                      
            Console.WriteLine($"User {username} logged in.");
        }
    }
}
