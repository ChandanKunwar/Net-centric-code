using System;

namespace body_mass_index
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter weight");
            double W = double.Parse(Console.ReadLine());

            Console.WriteLine("enter height in meters");
            double H = double.Parse(Console.ReadLine());

            double I = ((W / Math.Pow(H,2))*703);
            Console.WriteLine($"body mass index={I}");
        }
    }
}
