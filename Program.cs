using System;

namespace lab7
{
    class Program
    {
        class Pyramid
        {
            private float height = 1, width = 1;
            
            public Pyramid()
            {
                
            }
            public Pyramid(float height)
            {
                this.height = height;
            }

            public Pyramid(float height, float width)
            {
                this.height = height;
                this.width = width;
            }

            public void PrintPyr()
            {
                string str = "";
                #if !DEBUG
                str += $"Длина: {height}\n";
                str += $"Сторона: {width}\n";
#else
                str += $"{height}\n";
                str += $"{width}\n";
#endif
                Console.WriteLine(str);
            }

            public void PrintPyr(bool Volume)
            {
                string str = "";
                #if !DEBUG
                str += $"Длина: {height}\n";
                str += $"Сторона: {width}\n";
                str += $"Объём пирамиды: {(1.0/3.0) * height * width * width}\n";
#else
                str += $"{height}\n";
                str += $"{width}\n";
                str += $"{1.0 / 3.0 * height * width * width}\n";
#endif
                Console.WriteLine(str);
            }
            public void PrintPyr(bool Volume, bool SurfaceArea)
            {
                string str = "";
                #if !DEBUG
                str += $"Длина: {height}\n";
                str += $"Сторона: {width}\n";
                str += $"Объём пирамиды: {(1.0 / 3.0) * height * width * width}\n";
                str += $"Площадь поверхности: {width * (width + 2 * height)}\n";
#else
                str += $"{height}\n";
                str += $"{width}\n";
                str += $"{1.0 / 3.0 * height * width * width}\n";
                str += $"{width * (width + 2 * height)}\n";
#endif
                Console.WriteLine(str);
            }
        }
        static void Main(string[] args)
        {
            string height, width;
            Console.Write("Высота: ");
            height = Console.ReadLine();
            Console.Write("Сторона: ");
            width = Console.ReadLine();

            Pyramid pyramid;
            if (height != "")
            {
                if (width != "")
                {
                    pyramid = new Pyramid(Convert.ToSingle(height), Convert.ToSingle(width));
                }
                else
                {
                    pyramid = new Pyramid(Convert.ToSingle(height));
                }
            }
            else
            {
                pyramid = new Pyramid();
            }
            
            pyramid.PrintPyr(true, true);

            Console.ReadKey();
        }
    }
}
