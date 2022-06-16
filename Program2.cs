using System;

namespace Задание2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите координаты 1 точки (через новую строку): ");
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите координаты 2 точки (через новую строку): ");
                int c = Convert.ToInt32(Console.ReadLine());
                int d = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите координаты 3 точки (через новую строку): ");
                int e = Convert.ToInt32(Console.ReadLine());
                int f = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите координаты 4 точки (через новую строку): ");
                int g = Convert.ToInt32(Console.ReadLine());
                int h = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите координаты 5 точки (через новую строку): ");
                int k = Convert.ToInt32(Console.ReadLine());
                int l = Convert.ToInt32(Console.ReadLine());

                Point p1 = new Point(a, b);
                Point p2 = new Point(c, d);
                Point p3 = new Point(e, f);
                Point p4 = new Point(g, h);
                Point p5 = new Point(k, l);

                int n = 0;

                while (n < 3 || n > 5)
                {
                    Console.WriteLine("Сколько точек вы хотите задействовать? (от 3 до 5): ");
                    n = Convert.ToInt32(Console.ReadLine());
                    if (n < 3 || n > 5)
                    {
                        Console.WriteLine("Диапазон от 3 до 5");
                        n = Convert.ToInt32(Console.ReadLine());
                    }
                }

                if (n == 3)
                {
                    Figure f1 = new Figure(p1, p2, p3);
                    f1.PerimeterCalculator(p1, p2, p3);
                    Console.WriteLine("Название: " + f1.GetName + ". Периметр: " + f1.GetPer);
                }
                else if (n == 4)
                {
                    Figure f2 = new Figure(p1, p2, p3, p4);
                    f2.PerimeterCalculator(p1, p2, p3, p4);
                    Console.WriteLine("Название: " + f2.GetName + ". Периметр: " + f2.GetPer);
                }
                else if (n == 5)
                {
                    Figure f3 = new Figure(p1, p2, p3, p4, p5);
                    f3.PerimeterCalculator(p1, p2, p3, p4, p5);
                    Console.WriteLine("Название: " + f3.GetName + ". Периметр: " + f3.GetPer);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
