using System;

namespace Measure_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            string output = Console.ReadLine();

            if (input == "mm")
            {
                num /= 1000;
            }
            else if (input == "cm")
            {
                num /= 100;
            }


            if (output == "mm")
            {
                num *= 1000;
            }
            else if (output == "cm")
            {
                num *= 100;
            }

            Console.WriteLine("{0:f3}", num);
        }
    }
}
