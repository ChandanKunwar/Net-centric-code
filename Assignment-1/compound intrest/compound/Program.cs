using System;

namespace compound
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter principal amount");
            double P = double.Parse(Console.ReadLine());

            Console.WriteLine("enter rate");
            double r = double.Parse(Console.ReadLine());

            Console.WriteLine("enter number of times interest applied per time period");
            double n = double.Parse(Console.ReadLine());

            Console.WriteLine("enter number of time periods elapsed");
            double t = double.Parse(Console.ReadLine());

            double C = P * Math.Pow((1 + (r / 100) / n), n * t);
            Console.WriteLine($"compound intrest={C}");





        }
    }
}
