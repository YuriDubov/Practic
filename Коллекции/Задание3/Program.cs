using System;
using System.Collections.Generic;

namespace Задание3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { };
            Random r = new Random();
            int c = r.Next(2, 6);

            Console.WriteLine("Введите " + c + " чисел");
            for (int i = 0; i < c; i++)
            {
                numbers.Add(Convert.ToInt32(Console.ReadLine()));
            }

            int sum = 0;
            for (int i = 0; i < c; i++)
            {
                sum += numbers[i];
            }

            Console.WriteLine("Введите команду:");
            string command;

            while(true)
            {
                command = Console.ReadLine();
                switch (command)
                {
                    case "sum":
                        Console.WriteLine("Сумма всех чисел: " + sum);
                        break;
                    case "exit":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Такой команды нет");
                        break;
                }
            }
            
            //Console.ReadKey();
        }
    }
}
