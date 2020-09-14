using System;

namespace simple_intrest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("principal: ");
            decimal P= decimal.Parse(Console.ReadLine());

            Console.Write("intrest rate: ");
            decimal R = decimal.Parse(Console.ReadLine());

            Console.Write("time: ");
            decimal T = decimal.Parse(Console.ReadLine());

            decimal I = P * T * R/100;
            Console.WriteLine($"simple intrest={I}");
        }
    }
}
