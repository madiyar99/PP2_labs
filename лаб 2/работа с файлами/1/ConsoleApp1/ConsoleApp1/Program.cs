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
            FileStream file1 = new FileStream(@"C:\Users\Asus\Desktop\PP2_labs_local\лаб 2\работа с файлами\1\file.txt", FileMode.Open); //создаем файловый поток
            StreamReader reader = new StreamReader(file1); // создаем «потоковый читатель» и связываем его с файловым потоком 
            string s = reader.ReadToEnd(); //считываем все данные с потока и записываем в переменную s
           
            Console.WriteLine(s);
            reader.Close(); //закрываем поток
            string[] arr = s.Split(' ');
            int a;
            int b;
            int min = 100000;
            int max = int.Parse(arr[0]);
            for(int i = 0; i < arr.Length; i++)
            {
                a = int.Parse(arr[i]);
                b = int.Parse(arr[i]);
                if(a > max) max = a;
                if (b < min) min = b;
            }

            Console.WriteLine(max + " " + min);

            StreamWriter write = new StreamWriter(@"C:\Users\Asus\Desktop\PP2_labs_local\лаб 2\работа с файлами\1\file2.txt");
            write.WriteLine(max + " " + min);
            write.Close();
            Console.ReadLine();
        }
    }
}
