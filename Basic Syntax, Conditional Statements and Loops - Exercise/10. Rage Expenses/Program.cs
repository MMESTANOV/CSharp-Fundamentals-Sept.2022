using System;

namespace _10._Rage_Expenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lostGamesCount = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            int headsetCnt = lostGamesCount / 2;
            int mouseCnt = lostGamesCount / 3;
            int keyboardCnt = lostGamesCount / 6;
            int displayCnt = lostGamesCount / 12;

            double expenses = (headsetCnt * headsetPrice) + (mouseCnt * mousePrice) + (keyboardCnt*keyboardPrice) + (displayCnt*displayPrice);
            Console.WriteLine($"Rage expenses: {expenses:f2} lv.");
        }
    }
}
