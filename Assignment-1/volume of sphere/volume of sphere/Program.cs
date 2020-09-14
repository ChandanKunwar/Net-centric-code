using System;

namespace volume_of_sphere
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("volume of sphere calculation");
            Console.WriteLine("enter radius:");
            double r = double.Parse(Console.ReadLine());
            double a = (4 * Math.PI * r * r * r) / 3;
            Console.WriteLine($"volume of sphere is {a}");
        }
    }
}
