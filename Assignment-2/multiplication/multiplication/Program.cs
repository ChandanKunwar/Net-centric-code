using System;

namespace multiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("multiplication of which number");
            int m = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                int n = m * i;
                Console.WriteLine($"{m}*{i}={n}");
            }
        }
    }
}
