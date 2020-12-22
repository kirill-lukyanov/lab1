using System;

namespace lab6
{
    class Labor6
    {
        class Cylinder
        {
            private float radius, height;

            public Cylinder(float radius, float height)
            {
                this.radius = radius;
                this.height = height;
            }

            public void PrintCyl()
            {
                string str = "";
                #if !DEBUG
                str += $"Радиус: {radius}\n";
                str += $"Высота: {height}\n";
                str += $"Объём: {Math.PI * radius * radius * height}\n";
                str += $"Площадь поверхности: {2 * Math.PI * radius * (radius + height)}\n";
                #else
                str += $"{radius}\n";
                str += $"{height}\n";
                str += $"{Math.PI * radius * radius * height}\n";
                str += $"{2 * Math.PI * radius * (radius + height)}\n";
                #endif
                Console.WriteLine(str);
            }
        }
        static void Main(string[] args)
        {
            float radius, height;
            Console.Write("Радиус цилиндра: ");
            radius = Convert.ToSingle(Console.ReadLine());
            Console.Write("Высота цилиндра: ");
            height = Convert.ToSingle(Console.ReadLine());

            Cylinder cylinder = new Cylinder(radius, height);

            cylinder.PrintCyl();

            Console.ReadKey();
        }
    }
}
