using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0; //Создаем счетчик
            string line = Console.ReadLine(); //Вводим строку
            string[] arr = line.Split(' ');   //Удаляем из нее пробелы и записываем в массив символов

            for (int i = 0; i < arr.Length; i++)
            {

                int a = int.Parse(arr[i]); //Переводим каждый символ в число

                for (int j = 1; j <= a; j++) //Считаем количество делителей
                {
                    if (a % j == 0) count++;
                }

                if (count == 2) Console.WriteLine(a + " "); //Если делителя 2, то выводим ответ
                count = 0; //Обнуляем счетчик

            }

            Console.ReadKey();

        }
    }
}
