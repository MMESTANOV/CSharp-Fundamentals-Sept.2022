using System;

namespace _03.Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int peoples = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string day = Console.ReadLine();
            double price = 0;
            double totalPrice = 0;

            if (groupType == "Students")
            {
                switch (day)
                {
                    case "Friday":
                        price = 8.45;
                        break;
                    case "Saturday":
                        price = 9.80;
                        break;
                    case "Sunday":
                        price = 10.46;
                        break;
                }
                if ( peoples >= 30)
                {
                    totalPrice = price * peoples * 0.85;
                }
                else
                {
                    totalPrice = price * peoples;
                }
            }
            else if(groupType == "Business")
            {
                switch (day)
                {
                    case "Friday":
                        price = 10.90;
                        break;
                    case "Saturday":
                        price = 15.60;
                        break;
                    case "Sunday":
                        price = 16;
                        break;
                }
                if (peoples >= 100)
                {
                    totalPrice = price * peoples - (price * 10);
                }
                else
                {
                    totalPrice = price * peoples;
                }
            }
            else if (groupType == "Regular")
            {
                switch (day)
                {
                    case "Friday":
                        price = 15;
                        break;
                    case "Saturday":
                        price = 20;
                        break;
                    case "Sunday":
                        price = 22.50;
                        break;
                }
                if (peoples >= 10 && peoples <= 20)
                {
                    totalPrice = price * peoples  * 0.95;
                }
                else
                {
                    totalPrice = price * peoples;
                }
            }
                      
            Console.WriteLine($"Total price: {totalPrice:f2}");
        }
    }
}
