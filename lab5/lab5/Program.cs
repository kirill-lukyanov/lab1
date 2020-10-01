using System;
using System.Diagnostics.CodeAnalysis;

namespace lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            int m, n;
            Console.Write("n = ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("m = ");
            m = Convert.ToInt32(Console.ReadLine());
            int[,] a = new int[n,m];

            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    a[i, j] = r.Next(10);
                    Console.Write(a[i, j] + " ");
                }
                Console.Write("\n");
            }


            float sum;
            float[] sr = new float[m];
            for (int i = 0; i < m; i++)
            {
                sum = 0;
                for (int j = 0; j < n; j++)
                {
                    sum += a[j, i];
                }
                sr[i] = sum / n;
                Console.WriteLine($"Средн ({i}) = " + sr[i]);
            }

            Console.WriteLine("\nМодифицированная матрица\n");
            char[,] mod = new char[n, m];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    mod[j, i] = a[j, i] < sr[j] ? 'x' : 'y';
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(mod[i, j] + " ");
                }
                Console.Write("\n");
            }

            Console.ReadKey();
        }
    }
}
