using System;

namespace Задание3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите кол-во долларов, евро и рублей через строку: ");
            Converter conv = new Converter(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()));

            Console.WriteLine("Введите кол-во гривен: ");
            double u = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Выберите операцию: " + "\n1. Конвертация из гривны в доллар" + "\n2. Конвертация из гривны в евро" + "\n3. Конвертация из гривны в рубли" + "\n4. Конвертация из доллара в гривну" + "\n5. Конвертация из евро в гривну" + "\n6. Конвертация из рублей в гривну");
            int n = Convert.ToInt32(Console.ReadLine());

            switch(n)
            {
                case 1:
                    Console.WriteLine("Результат: " + conv.ToUsd(u));
                    break;
                case 2:
                    Console.WriteLine("Результат: " + conv.ToEur(u));
                    break;
                case 3:
                    Console.WriteLine("Результат: " + conv.ToRub(u));
                    break;
                case 4:
                    Console.WriteLine("Результат: " + conv.FromUsd());
                    break;
                case 5:
                    Console.WriteLine("Результат: " + conv.FromEur());
                    break;
                case 6:
                    Console.WriteLine("Результат: " + conv.FromRub());
                    break;
                default:
                    Console.WriteLine("Операция не найдена");
                    break;
            }
                
        }
    }
}
