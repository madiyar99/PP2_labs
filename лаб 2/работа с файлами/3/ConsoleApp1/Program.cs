using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo directory = new DirectoryInfo(@"C:\Users\Asus\Desktop\PP2_labs_local"); //Создаем экземпляр и прописываем путь к папке
            DirectoryInfo[] ds = directory.GetDirectories(); // Записываем в массив ds все папки из этого пути
            FileInfo[] fs = directory.GetFiles(); // Записываем в массив fs все файлы из этого пути
           
            foreach (DirectoryInfo d in ds)
            {
                Console.WriteLine(d.Name);
            }
            Console.WriteLine();
            foreach (FileInfo f in fs)
            {
                Console.WriteLine(f.Name);
            }

            /*
            FileSystemInfo[] fss = directory.GetFileSystemInfos(); // Записываем в ммассив fss и папки и файлы 
            foreach (FileSystemInfo f in fss) // Выводим все, что есть в массиве fss
            {
                if (f.GetType() == typeof(DirectoryInfo)) //Если это папка, то выводим в таком виде
                {
                    Console.WriteLine("Directory: " + f.Name);
                }
                else
                {
                    Console.WriteLine("File: " + f.FullName); // Выводим весь путь к файлу
                }
            }

            */
            Console.ReadKey();
        }
    }
}
