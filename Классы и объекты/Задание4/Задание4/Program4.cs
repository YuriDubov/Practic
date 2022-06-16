using System;

namespace Задание4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите имя и фамилию сотрудника через строку: ");
                Employee employee = new Employee(Console.ReadLine(), Console.ReadLine());

                Console.WriteLine("Введите стаж сотрудника: ");
                employee.Exp = Convert.ToInt32(Console.ReadLine());

                employee.CalcAndPrint();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
