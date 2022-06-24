using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;
using System.Diagnostics;

namespace Задание3
{
    class Program
    {
        static string path;
        static void Search(DirectoryInfo dr, string filename)
        {
            FileInfo[] fi = dr.GetFiles();
            foreach (FileInfo info in fi)
            {
                if (info.Name == filename)
                {
                    path = info.FullName;
                    Console.WriteLine(path);
                }
            }
            DirectoryInfo[] dirs = dr.GetDirectories();
            foreach (DirectoryInfo directoryInfo in dirs)
            {
                Search(directoryInfo, filename);
            }
        }
        static void Main(string[] args)
        {
            string filename = "test.txt";

            DirectoryInfo dr = new DirectoryInfo(@"C:\test");
            Search(dr, filename);
            
            if (path == null)
                Console.WriteLine("Такого файла нет");
            else
            {
                Process proc = Process.Start(@"C:\test\test.txt", path);
                proc.WaitForExit();
                proc.Close();
            }
            Console.WriteLine("Для сжатия нажмите Enter");
            Console.ReadLine();

            path = path.Replace(filename, "");

            ZipFile.CreateFromDirectory(path, @"C:\test\test.zip");

            Console.ReadLine();
        }
    }
}
