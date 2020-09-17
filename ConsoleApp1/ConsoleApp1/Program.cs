using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите длину окружности L: ");
                double l = double.Parse(Console.ReadLine());

                double r = l / (2 * Math.PI);
                double s = Math.PI * Math.Pow(r, 2);

                Console.WriteLine($"Радиус круга: {r:0.00}\nПлощадь круга: {s:0.00}");
                Console.ReadKey();
            }
           
            catch
            {
                Console.WriteLine("Ошибка! Неправельные данные!");
                Console.ReadKey();
            }
        }
    }
}
