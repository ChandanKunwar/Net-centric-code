using System;

namespace area_of_circle
{
   
    class Program
    {
       
        static void Main(string[] args)
        {
            double pi = 3.14;
            Console.WriteLine("enter the radius:");
            double r = double.Parse(Console.ReadLine());

            double A = pi*Math.Pow(r,2);
            Console.WriteLine($"area of circle= {A}");

        }
    }
}
