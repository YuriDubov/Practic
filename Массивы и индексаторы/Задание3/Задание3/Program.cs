using System;

namespace Задание3
{
    class Program
    {
        public static void Sort(int[] arr)
        {
            try
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    for (int j = i + 1; j < arr.Length; j++)
                    {
                        int temp;
                        if (arr[i] > arr[j])
                        {
                            temp = arr[i];
                            arr[i] = arr[j];
                            arr[j] = temp;
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
        static void Main(string[] args)
        {
            try
            {
                int[] array = new int[5] { 5, 4, 8, 10, 12 };
                Console.WriteLine("Текущий массив: " + String.Join(" ", array));
                Sort(array);
                Console.Write("Отсортированный массив: " + String.Join(" ", array));
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
