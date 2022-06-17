using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание4
{
    enum Post
    {
        Менеджер = 40,
        Маркетолог = 30,
        Бухгалтер = 38,
        Специалист_по_продажам = 48
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Введите кол-во часов, отработанных сотрудником: ");
            int h = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Выберите сотрудника: " + "\n1. Менеджер" + "\n2. Маркетолог" + "\n3. Бухгалтер" + "\n4. Специалист по продажам");
            int n = Convert.ToInt32(Console.ReadLine());

            Accauntant accauntant = new Accauntant();

            switch(n)
            {
                case 1:
                    if (accauntant.AskForBonus(Post.Менеджер, h))
                        Console.WriteLine("Премия положена");
                    else
                        Console.WriteLine("Премия не положена. В другой раз");
                    break;
                case 2:
                    if (accauntant.AskForBonus(Post.Маркетолог, h))
                        Console.WriteLine("Премия положена");
                    else
                        Console.WriteLine("Премия не положена. В другой раз");
                    break;
                case 3:
                    if (accauntant.AskForBonus(Post.Бухгалтер, h))
                        Console.WriteLine("Премия положена");
                    else
                        Console.WriteLine("Премия не положена. В другой раз");
                    break;
                case 4:
                    if (accauntant.AskForBonus(Post.Специалист_по_продажам, h))
                        Console.WriteLine("Премия положена");
                    else
                        Console.WriteLine("Премия не положена. В другой раз");
                    break;
                default:
                    Console.WriteLine("Такого сотрудника нет");
                    break;
            }
            
                
        }
    }
    class Accauntant
    {
        public bool AskForBonus(Post worker, int hours)
        {
            if ((int)worker < hours)
                return true;
            else
                return false;

        }
    }
    
}
