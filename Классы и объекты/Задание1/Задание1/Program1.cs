using System;

namespace Задание1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите значение 1 стороны прямоугольника: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите значение 2 стороны прямоугольника");
                int b = Convert.ToInt32(Console.ReadLine());

                Ractangle rec = new Ractangle(a, b);

                Console.WriteLine("Площадь прямоугольника: " + rec.Area);
                Console.WriteLine("Периметр прямоугольника: " + rec.Perimeter);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
