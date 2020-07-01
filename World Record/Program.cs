using System;

namespace World_Record
{
    class Program
    {
        static void Main(string[] args)
        {
            double recordinSec = double.Parse(Console.ReadLine());
            double distanceinMet = double.Parse(Console.ReadLine());
            double timeInSecForMeter = double.Parse(Console.ReadLine());

            double shouldSwim = distanceinMet * timeInSecForMeter;
            double waterResistance = 100 * 12.5;
            double waterResistance2 = 201 * 12.5;

            double tottalTime = shouldSwim + waterResistance;
            double ivanTime = tottalTime - recordinSec;
            double ivanTime2 = shouldSwim + waterResistance2;

            if (recordinSec <= tottalTime)
            {

                Console.WriteLine($"Yes,he succeeded.The new world record is {ivanTime} soconds");
            }
            else
            {

                Console.WriteLine($"No ,he failed!He was {ivanTime2} seconds slower");
            }
        }
    }
}
