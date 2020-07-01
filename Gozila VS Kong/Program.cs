using System;

namespace Gozila_VS_Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int extras = int.Parse(Console.ReadLine());
            double price = double.Parse(Console.ReadLine());

            double sumDecor = budget * 0.1;
            double sumClothing = extras * price;
            double totalFilmPrice = budget + sumClothing;
            double leftMoney = budget - totalFilmPrice;

            if (extras > 150)
            {
                price *= 0.9;
            }

            double totalSum = sumDecor + sumClothing;

            if (totalSum > budget)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {Math.Abs(totalSum):f2},leva more");
            }

            else
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {Math.Abs(leftMoney):f2},leva left");
            }
        }
    }
}
