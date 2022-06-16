using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание2
{
    class Store
    {
        private Article[] articles = null;

        public Store(Article[] a)
        {
            articles = a;
        }

        public void GetArticle(int n)
        {
            try
            {
                Console.WriteLine(articles[n].GoodName + "\t" + articles[n].ShopName + "\t" + articles[n].Price);
            }
            catch
            {
                Console.WriteLine("Индекс за пределами массива!");
            }
        }


        public void FindArticle(string n)
        {
            List<Article> listart = new List<Article>();
            for (int i = 0; i < articles.Length; i++)
            {
                if (articles[i].GoodName.Contains(n))
                {
                    listart.Add(articles[i]);
                }
            }

            if (listart.Count > 0)
            {
                for (int i = 0; i < listart.Count; i++)
                {
                    Console.WriteLine(listart[i].GoodName + "\t" + listart[i].ShopName + "\t" + listart[i].Price);
                }
            }
            else
            {
                Console.WriteLine("Товар не найден!");
            }
        }
    }
}
