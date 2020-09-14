using System;

namespace geometric_mean
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geometric Mean Calculation\n");
            int[] data = { 2, 5, 9, 10, 18,55 };
            int value = 1;
            for (int i = 0; i < data.Length; i++)
            {
                value = value * data[i];
            }
            double result = Math.Pow(value, (1.0 / data.Length));

            Console.WriteLine($"Geometric Mean = {result}");
        }
    }
}
