using System;
using System.Collections.Generic;
using System.IO;

namespace lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int n;

            Console.Write("Количество чисел: ");
            n = Convert.ToInt32(Console.ReadLine());

            double[] array = new double[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"a[{i}] = ");
                array[i] = Convert.ToDouble(Console.ReadLine());
            }

            double minPositive = 100001;
            List<double> list = new List<double>();

            foreach (double e in array)
            {
                if (e < minPositive && e > 0) minPositive = e;
                if (Math.Abs(e) <= 1000) list.Add(e);
            }
            Array.Sort(array);
            Console.WriteLine($"Второй по величине элемент = {array[n-2]}");
            Console.WriteLine($"Минимальный положительный элемент = {minPositive}");
            Console.Write("Числа не превышающие по модулю 1000: ");
            foreach(double e in list)
            {
                Console.Write($"{e}, ");
            }

            Console.ReadKey();

        }
    }
}
