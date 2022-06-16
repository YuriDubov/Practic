using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание5
{
    class Invoice
    {
        private int account;
        private string customer;
        private string provider;
        private string article;
        private int quantity;

        public Invoice(int acc, string cust, string prov)
        {
            account = acc;
            customer = cust;
            provider = prov;
        }

        public string Arcicle
        {
            set
            {
                article = value;
            }
            get
            {
                return article;
            }
        }
        public int Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                quantity = value;
            }
        }
        
        

        public void WithoutNDS()
        {
            double sum = account * quantity;
            Console.WriteLine("Заказчик: " + customer + ". Продавец: " + provider + ". Наименование товара: " + article + ". Количество: " + quantity + ". Цена за 1 шт: " + account + ". Всего без учета НДС: " + sum);
        }
        public void WithNDS()
        {
            double sum = account * quantity + ((account * quantity) * 0.2);
            Console.WriteLine("Заказчик: " + customer + ". Продавец: " + provider + ". Наименование товара: " + article + ". Количество: " + quantity + ". Цена за 1 шт: " + account + ". Всего с учетом НДС: " + sum);
        }
    }
}
