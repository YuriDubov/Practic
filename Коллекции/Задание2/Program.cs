using System;
using System.Collections.Generic;

namespace Задание2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> money = new List<int> { };
                Random r = new Random();
                Random rnd = new Random();
                int sum = 0;
                int c = r.Next(1, 15);

                for (int i = 0; i < c; i++)
                {
                    money.Add(rnd.Next(1000, 10000));
                }

                for (int i = 0; i < money.Count; i++)
                {
                    Console.WriteLine("Выберите что сделать с клиентом №" + (i + 1) + ":\n1. Обслужить \n2. Послать к черту");
                    int n = Convert.ToInt32(Console.ReadLine());
                    switch (n)
                    {
                        case 1:
                            Console.WriteLine("Вы обслужили клиента. +" + money[i] + " к общей сумме");
                            sum += money[i];
                            break;
                        case 2:
                            Console.WriteLine("Вы послали клиента. Как грубо. Денег вы не получили");
                            break;
                        default:
                            Console.WriteLine("Такого действия нет");
                            break;
                    }
                }
                Console.WriteLine("Ваша сумма: " + sum);
                Console.ReadKey();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
