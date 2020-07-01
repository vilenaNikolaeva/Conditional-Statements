using System;

namespace Time_Plus_15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());

            int inMin = hour * 60 + min;
            int minPlus = inMin + 15;

            int forHour = minPlus / 60;
            int forMin = minPlus % 60;

            if (forHour == 24)
            {
                forHour -= 24;
            }

            if (forMin < 10)
            {
                Console.WriteLine("{0}:0{1}", forHour, forMin);
            }
            else
            {
                Console.WriteLine("{0}:{1}", forHour, forMin);
            }
        }
    }
}
