using System;

namespace Задание2
{
    class Program
    {
        static void Main(string[] args)
        {
            Article a1 = new Article();
            Article a2 = new Article();
            Article a3 = new Article();

            a1.GoodName = "Телевизор";
            a1.ShopName = "Эльдорадо";
            a1.Price = 50000;

            a2.GoodName = "Консоль PS5";
            a2.ShopName = "DNS";
            a2.Price = 100000;

            a3.GoodName = "Смартфон";
            a3.ShopName = "Связной";
            a3.Price = 15000;

            Store store = new Store(new Article[] { a1, a2, a3 });

            Console.WriteLine("Введите индекс: ");
            store.GetArticle(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("Введите название товара: ");
            store.FindArticle(Console.ReadLine());


        }
    }
}
