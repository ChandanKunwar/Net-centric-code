using System;

namespace gravity
{
    class Program
    {
        static void Main(string[] args)
        {
            double G = 6.67E-11;
            Console.WriteLine("enter the mass of first object");
            double M = double.Parse(Console.ReadLine());

            Console.WriteLine("enter the mass of second object");
            double m = double.Parse(Console.ReadLine());

            Console.WriteLine("enter the distance between them");
            double r = double.Parse(Console.ReadLine());

            double F = G * M * m / (r * r);
            Console.WriteLine($"the gravitational force between two objects={F}");
        }
    }
}
