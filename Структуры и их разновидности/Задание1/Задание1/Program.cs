using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Задание1
{
    class Program
    {
        static void Main(string[] args)
        {
            Train[] trains = new Train[8];

            for (int i = 0; i < trains.Length; i++)
            {
                Console.WriteLine("Введите название пункта назначения:  ");
                string destination = Console.ReadLine();

                Console.WriteLine("Введите номер поезда: ");
                int number = int.Parse(Console.ReadLine());

                Console.WriteLine("Введите дату отправления: ");
                DateTime departure = DateTime.Parse(Console.ReadLine());

                trains[i] = new Train(destination, number, departure);
            }

            Console.WriteLine("Введите номер поезда для поиска или 0 для выхода");
            int input;
            while ((input = Convert.ToInt32(Console.ReadLine())) != 0)
            {
                bool trainFound = false;
                for (int i = 0; i < trains.Length; i++)
                {
                    if (trains[i].Number == input)
                    {
                        Console.WriteLine(trains[i]);
                        trainFound = true;
                    }
                }

                if (!trainFound)
                    Console.WriteLine("Ничего не найдено. Повторите попытку");
            }
        }
    }
    
    
    struct Train
    {
        public string Destination;
        public int Number;
        public DateTime Departure;
        public Train(string destination, int number, DateTime departure)
        {
            this.Destination = destination;
            this.Number = number;
            this.Departure = departure;

        }

        public override string ToString()
        {
            return string.Format("Пункт назначения: {0}, № поезда: {1}, Отправление: {2}", Destination, Number, Departure);
        }
    }

}
