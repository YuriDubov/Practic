using System;
using System.Collections.Generic;

namespace Задание1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string> {"скунс", "свинья", "шкаф", "коллайдер", "марцепан", "мармелад", "машина", "гадюка", "игра", "десятка", "водка", "спорт", "слово", "фокус", "фильм", "документ", "экзамен", "памагити", "победа", "связь"};
            Console.WriteLine("Введите слово:");
            string word = Console.ReadLine();

            for(int i = 0; i < words.Count; i++)
            {
                if (word == words[i])
                {
                    Console.WriteLine("Значение слова: " + words[i] + ". Позиция: " + i);
                    break;
                }
                else
                {
                    int err = 0;
                    for(int j = 0; j < word.Length; j++)
                    {
                        string word2 = words[i];
                        if (word[j] != word2[j])
                            err++;

                        if (err > 2)
                            break;
                    }
                    if (err <= 2)
                    {
                        Console.WriteLine("Ближайшее слово: " + words[i] + ". Позиция: " + i);
                        break;
                    }
                }
                    

                if (i == words.Count - 1)
                {
                    Console.WriteLine("Такого слова нет");
                }
                    
            }
            Console.ReadKey();
            
        }
    }
}
