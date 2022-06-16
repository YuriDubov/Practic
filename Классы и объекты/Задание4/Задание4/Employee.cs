using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание4
{
    class Employee
    {
        private string Name;
        private string Surname;
        private int exp;

        public Employee(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        public int Exp
        {
            get
            {
                return exp;
            }
            set
            {
                exp = value;
            }
        }

        public void CalcAndPrint()
        {
            string dol;
            string[] dols = new string[3] { "Генеральный директор", "Менеджер", "Специалист по кибербезопасности" };

            Random r = new Random();
            dol = dols[r.Next(0, dols.Length)];

            int oklad = 0;
            if (dol == "Генеральный директор")
                oklad = 300000;
            else if (dol == "Менеджер")
                oklad = 250000;
            else if (dol == "Специалист по кибербезопасности")
                oklad = 200000;

            if (exp < 5)
                oklad += 0;
            else if (exp > 5 && exp < 10)
                oklad += 50000;
            else if (exp > 10)
                oklad += 100000;

            double NS = oklad * 0.1;

            Console.WriteLine("Имя: " + Name + ". Фамилия: " + Surname + ". Должность: " + dol + ". Оклад: " + oklad + ". Налоговый сбор: " + NS);
        }
    }
}
