using System;

namespace Shcolarships
{
    class Program
    {
        static void Main(string[] args)
        {
            double incomeLV = double.Parse(Console.ReadLine());
            double averageSucceed = double.Parse(Console.ReadLine());
            double minSalary = double.Parse(Console.ReadLine());

            double socialScholarship = minSalary * 0.35;
            double excellentResult = averageSucceed * 25;

            if (incomeLV > minSalary)
            {
                Console.WriteLine("You cannot get a scholarship!");

                if (averageSucceed < 5.5)
                {
                    Console.WriteLine("You cannot get a scholarship!");
                }
            }
            if (incomeLV < minSalary)
            {
                Console.WriteLine("You get a Social Scholarship {socialScholarship} BGN");

                if (averageSucceed > 5.5)
                {
                    Console.WriteLine("You get a  scholarship for excellent results{excellentResult}");
                }
            }
        }
    }
}
