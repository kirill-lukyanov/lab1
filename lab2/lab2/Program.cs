using System;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d, e;
            double k, s;

            Console.Write("a = ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b = ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("c = ");
            c = Convert.ToDouble(Console.ReadLine());
            Console.Write("d = ");
            d = Convert.ToDouble(Console.ReadLine());
            Console.Write("e = ");
            e = Convert.ToDouble(Console.ReadLine());

            if (e == 0 || e-b < 0) 
            {
                Console.WriteLine("ERROR");
                Console.ReadKey();
                return;
            }
            if (a - Math.Sqrt(e - b) < 0)
            {
                Console.WriteLine("ERROR");
                Console.ReadKey();
                return;
            }
            s = Math.Sqrt(a - Math.Sqrt(e - b)) / e;

            if (b - a == 0 || c - 1000 < 0)
            {
                Console.WriteLine("ERROR");
                Console.ReadKey();
                return;
            }
            if ((d + Math.Sqrt(c-1000)) / Math.Abs(b-a) < 0)
            {
                Console.WriteLine("ERROR");
                Console.ReadKey();
                return;
            }

            k = Math.Sqrt((d + Math.Sqrt(c - 1000)) / Math.Abs(b - a));


            Console.WriteLine($"s = {s:0.##}");
            Console.WriteLine($"k = {k:0.##}");
            Console.ReadKey();
        }

        
    }
}
