using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание2
{
    class Article
    {
        private string goodname;
        private string shopname;
        private double price;

        public string GoodName
        {
            get
            {
                return goodname;
            }
            set
            {
                goodname = value;
            }
        }
        public string ShopName
        {
            get
            {
                return shopname;
            }
            set
            {
                shopname = value;
            }
        }
        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }
    }
}
