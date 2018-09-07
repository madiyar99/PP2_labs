using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Threads1
{
    class Program
    {
        static void func()
        {
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Поток 2 выводит: " + i);
            }
            Thread.Sleep(0);
        }

        static void Main(string[] args)
        {
            Thread thr = new Thread(func);

            thr.Start();

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Основной поток выводит: " + i);
            }

            Console.ReadKey();
        }
    }
}
