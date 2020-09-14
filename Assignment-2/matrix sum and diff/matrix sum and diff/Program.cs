using System;

namespace matrix_sum_and_diff
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            int[,] a = new int[5, 5];
            int[,] b = new int[5, 5];
            int[,] s = new int[5, 5];
            int[,] d = new int[5, 5];
            Console.WriteLine("enter size of matrix m*n for matrix a");
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the values for matrix a");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m; j++)
                {
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("enter the values for matrix b");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m; j++)
                {
                    b[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m; j++)
                {
                    s[i, j] = a[i, j] + b[i, j];
                    d[i, j] = a[i, j] - b[i, j];

                }
            }
            Console.WriteLine("addition of two matrix is");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m; j++)
                {
                    Console.WriteLine(s[i, j]);
                }
            }
            Console.WriteLine("difference of two matrix is");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m; j++)
                {
                    Console.WriteLine(d[i, j]);
                }
            }
        }
    }
}
