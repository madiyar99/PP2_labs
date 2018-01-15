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
            string s = Console.ReadLine();

            string[] arr = s.Split(' ');

            int length = int.Parse(arr[0]);
            int width = int.Parse(arr[1]);
            
            Rectangle c = new Rectangle(length, width);

            Console.WriteLine(c);

            Console.ReadKey();
        }
    }
}
