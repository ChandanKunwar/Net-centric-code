using System;

namespace mass_energy
{
    class Program
    {
        static void Main(string[] args)
        {
            double c = 3.00E8;
            Console.WriteLine("enter the mass of body in kg");
            double m = double.Parse(Console.ReadLine());
            double E = m * c * c;
            Console.WriteLine($"energy={E}");
        }
    }
}
