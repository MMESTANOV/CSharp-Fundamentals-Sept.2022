using System;

namespace _07._Vending_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            double sumCoins = 0;
            double balance = 0;

            while (input != "Start")
            {
                double addCoin = double.Parse(input);
                if (addCoin==0.1 || addCoin == 0.2 || addCoin == 0.5 || addCoin == 1 || addCoin == 2)
                {
                    sumCoins += addCoin;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {addCoin}");
                }
                input = Console.ReadLine();
            }
            input = Console.ReadLine();
            while (input != "End")
            {
                
                if (input == "Nuts")
                {
                    balance += 2.0;
                    if (balance<=sumCoins)
                    {
                        Console.WriteLine("Purchased nuts");
                    }
                    else
                    {
                        balance -= 2.0;
                        Console.WriteLine("Sorry, not enough money");
                    }
                    
                }
                else if (input == "Water")
                {
                    
                    balance += 0.7;
                    if (balance <= sumCoins)
                    {
                        Console.WriteLine("Purchased water");
                    }
                    else
                    {
                        balance -= 0.7;
                        Console.WriteLine("Sorry, not enough money");
                    }
                    
                }
                else if (input == "Crisps")
                {
                    balance += 1.5;
                    if (balance <= sumCoins)
                    {
                        Console.WriteLine("Purchased crisps");
                    }
                    else
                    {
                        balance -= 1.5;
                        Console.WriteLine("Sorry, not enough money");
                    }
                    
                }
                else if (input == "Soda")
                {
                    balance += 0.8;
                    if (balance <= sumCoins)
                    {
                        Console.WriteLine("Purchased soda");
                    }
                    else
                    {
                        balance -= 0.8;
                        Console.WriteLine("Sorry, not enough money");
                    }
                    
                }
                else if (input == "Coke")
                {
                    balance += 1.0;
                    if (balance <= sumCoins)
                    {
                        Console.WriteLine("Purchased coke");
                    }
                    else
                    {
                        balance -= 1.0;
                        Console.WriteLine("Sorry, not enough money");
                    }
                    
                }
                else
                {                  
                    Console.WriteLine("Invalid product");                   
                }
                input = Console.ReadLine();
            }
            
            Console.WriteLine($"Change: { (sumCoins-balance):f2}");
                
        }
    }
}
