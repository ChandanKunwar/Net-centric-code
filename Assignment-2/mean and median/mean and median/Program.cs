using System;

namespace mean_and_median
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[100];
            int i, sum = 0,n;
            double median,mean;
            Console.WriteLine("enter how many value");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the values");
            for (i = 1; i <= n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            /* for (i = 0; i < n; i++)
             {
                 Console.WriteLine(a[i]);
             }*/
            for (i = 0; i < n; i++)
            {
                sum += a[i];
            }
            mean = sum /(double)n;
            Console.WriteLine($"mean={mean}");
            if (n % 2 == 0)
            {
                median = (a[(n + 1) / 2] + a[((n + 1) / 2) + 1]) / (double)2;
                Console.WriteLine($"median={median}");
            }
            else
            {
                median = a[(n + 1) / 2];
                Console.Write("median is " + median);
            }
            

        }
    }
}
