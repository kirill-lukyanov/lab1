using System;

namespace lab3
{
    class Program
    {
        static void Main(string[] args)
        {

            
            double x, y, res;
            int n;

            Console.Write("x = ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("y = ");
            y = Convert.ToDouble(Console.ReadLine());
            Console.Write("Количество итераций = ");
            n = Convert.ToInt32(Console.ReadLine());

            res = 0;
            for (int i = 1, j = 0; j < n; i+=2, j++)
            {
                if (j % 2 == 0) res += Math.Pow(x, i + 1) / (i * (i + 2));
                else res -= Math.Pow(y, i + 1) / (i * (i + 2));
            }

            Console.WriteLine($"res = {res}");
            Console.ReadKey();
        }

    }
}
