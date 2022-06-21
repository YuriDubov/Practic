using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Задание2
{
    class Program
    {
        static void Main(string[] args)
        {
            File.WriteAllText(@"C:\Dir\FileExample.txt", "ahdfjghsjhsn\n731974t461igyvfa");
            
            StreamReader sr = new StreamReader(@"C:\Dir\FileExample.txt");
            Console.WriteLine("Содержимое файла:");
            for(int i = 0; i < File.ReadAllLines(@"C:\Dir\FileExample.txt").Length; i++)
            {
                Console.WriteLine(sr.ReadLine());
            }
            
        }
    }
}
