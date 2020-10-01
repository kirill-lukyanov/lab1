using System;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(
                "Лабораторная работа №1 Разработка консольного приложения\n"+
                "Лукьянов Кирилл Александрович\n"+
                "ИНС-б-о-191\n" +
                "26.01.2002\n" +
                "г. Михайловск\n" +
                "Ручка\n" +
                "Дизайн, музыка");

            Console.WriteLine("\nЗадание №2\n");

            float R_x = 0, a = 1, b = 2, t = 3, x = 4, f = 5, i_2 = 6;
            R_x = a * b + b / t - x + f * i_2;

            Console.WriteLine($"R_x = {R_x}");
            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");
            Console.WriteLine($"t = {t}");
            Console.WriteLine($"x = {x}");
            Console.WriteLine($"f = {f}");
            Console.WriteLine($"i_2 = {i_2}");

            Console.ReadKey();
        }
    }
}
