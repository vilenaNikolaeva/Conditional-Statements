using System;

namespace Sum_The_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int timeF = int.Parse(Console.ReadLine());
            int timeS = int.Parse(Console.ReadLine());
            int timeT = int.Parse(Console.ReadLine());

            int totalTime = timeF + timeS + timeT;

            double minutes = totalTime / 60;
            double sec = totalTime % 2;

            if (sec < 10)
            {
                Console.WriteLine("{minutes}:0{sec}");
            }
            else
            {
                Console.WriteLine("{minutes}:{sec}");

            }
        }
    }
}
