using System;

namespace Задание5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите стоимость товара за 1 шт, заказчика и продавца через строку: ");
            Invoice invoice = new Invoice(Convert.ToInt32(Console.ReadLine()), Console.ReadLine(), Console.ReadLine());

            Console.WriteLine("Введите наименование товара: ");
            invoice.Arcicle = Console.ReadLine();

            Console.WriteLine("Введите количество: ");
            invoice.Quantity = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Выберите расчет: " + "\n1. С учетом НДС" + "\n2. Без Учета НДС");
            int n = 0;

            switch(n)
            {
                case 1:
                    invoice.WithNDS();
                    break;
                case 2:
                    invoice.WithoutNDS();
                    break;
                default:
                    Console.WriteLine("Такой операции нет");
                    break;
            }
        }
    }
}
