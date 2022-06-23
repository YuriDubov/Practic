using System;
using System.Collections.Generic;

namespace Задание4
{
    class Program
    {
        static List<string> FIO = new List<string> { };
        static List<string> post = new List<string> { };
        //List<string> docie = new List<string> { };
        public static void AddDocie()
        {
            //string str = "";
            Console.WriteLine("Введите ФИО:");
            string data = Console.ReadLine();
            FIO.Add(data);
           // str += data;
            Console.WriteLine("Введите должность:");
            data = Console.ReadLine();
            post.Add(data);
          //  str += data;

            //docie.Add(str);
        }
        public static void Print()
        {
            if (FIO.Count == 0)
                Console.WriteLine("Выводить некого");
            else
            {
                for (int i = 0; i < FIO.Count; i++)
                {
                    Console.WriteLine((i + 1) + ". " + FIO[i] + " - " + post[i]);
                }
            }
            
            
        }
        public static void Delete()
        {
            if (FIO.Count == 0)
                Console.WriteLine("Пусто");
            else
            {
                Console.WriteLine("Введите ФИО:");
                string del = Console.ReadLine();

                for (int i = 0; i < FIO.Count; i++)
                {
                    if (FIO.Contains(del))
                    {
                        int n = FIO.IndexOf(del);
                        post.RemoveAt(n);
                        FIO.RemoveAt(n);
                        break;
                    }

                    if (i == FIO.Count - 1)
                        Console.WriteLine("Невозможно удалить того, кого нет");

                }
            }

            
        }
        public static void Search()
        {
            if (FIO.Count == 0)
                Console.WriteLine("Выводить некого");
            else
            {
                Console.WriteLine("Введите фамилию:");
                string surname = Console.ReadLine();

                for (int i = 0; i < FIO.Count; i++)
                {
                    string sur = FIO[i].Substring(0, surname.Length);
                    if (sur == surname)
                    {
                        Console.WriteLine("Результат: " + FIO[i] + " - " + post[i]);
                        break;
                    }

                    if (i == FIO.Count - 1)
                        Console.WriteLine("Не найдено");

                }
            }
            

            
        }
        static void Main(string[] args)
        {
            try
            {
                while (true)
                {
                    Console.WriteLine("Выберите операцию: \n1. Добавить досье \n2. Вывести все досье \n3. Удалить досье \n4. Поиск по фамилии \n5. Выход");
                    int n = Convert.ToInt32(Console.ReadLine());

                    switch (n)
                    {
                        case 1:
                            AddDocie();
                            break;
                        case 2:
                            Print();
                            break;
                        case 3:
                            Delete();
                            break;
                        case 4:
                            Search();
                            break;
                        case 5:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Такой операции нет");
                            break;
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            //Console.ReadKey();

            
        }
    }
}
