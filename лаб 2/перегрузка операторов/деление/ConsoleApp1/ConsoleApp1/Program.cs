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
            division c1 = new division(15, 27);
            division c2 = new division(3, 9);

            division result = c1 / c2;
            Console.WriteLine(result);
      
            Console.ReadKey();
        }
    }
}
