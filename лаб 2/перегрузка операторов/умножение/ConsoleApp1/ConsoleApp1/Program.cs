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
            multiply c1 = new multiply(2, 3);
            multiply c2 = new multiply(5, 4);

            multiply result = c1 * c2;
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
