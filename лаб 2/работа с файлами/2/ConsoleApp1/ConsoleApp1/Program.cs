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
            FileStream file1 = new FileStream(@"C:\Users\Asus\Desktop\PP2_labs_local\лаб 2\работа с файлами\2\file.txt", FileMode.Open); //создаем файловый поток
            StreamReader reader = new StreamReader(file1); // создаем «потоковый читатель» и связываем его с файловым потоком 
            string s = reader.ReadToEnd(); //считываем все данные с потока и записываем в переменную s
            Console.WriteLine(s);
            reader.Close(); //закрываем поток
            string[] arr = s.Split(' ');
            int a, count = 0;
            int min = 100000000;
            for(int i = 0; i < arr.Length; i++)
            {
                a = int.Parse(arr[i]);
                for(int j = 1; j <= a; j++)
                {
                    if (a % j == 0) count++;
                }

                if(count == 2)
                {
                    if (a < min) min = a;
                }

                count = 0;
            }

            Console.WriteLine("min prostoe = " + min);

            Console.ReadLine();
        }
    }
}
