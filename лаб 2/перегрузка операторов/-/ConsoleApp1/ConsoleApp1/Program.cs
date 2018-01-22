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
            minus c1 = new minus(5, 9);
            minus c2 = new minus(1, 3);

            minus result = c1 - c2;
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
