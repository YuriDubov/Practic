using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку: ");
            string str = Console.ReadLine();

            Console.WriteLine("Выберите цвет: " + "\n0. Красный" + "\n1. Синий" + "\n2. Зеленый" + "\n3. Желтый" + "\n4. Черный");
            int n = Convert.ToInt32(Console.ReadLine());

            Class.Print(str, n);

        }
    }
    static class Class
    {
        enum Colors
        {
            Красный,
            Синий,
            Зеленый,
            Желтый,
            Черный
        }
        public static void Print(string stroka, int color)
        {
            switch((Colors)color)
            {
                case Colors.Красный:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(stroka);
                    Console.ResetColor();
                    break;
                case Colors.Синий:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(stroka);
                    Console.ResetColor();
                    break;
                case Colors.Зеленый:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(stroka);
                    Console.ResetColor();
                    break;
                case Colors.Желтый:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(stroka);
                    Console.ResetColor();
                    break;
                case Colors.Черный:
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine(stroka);
                    Console.ResetColor();
                    break;
                default:
                    Console.WriteLine("Такого цвета нет");
                    break;
            }
        }
    }
}
