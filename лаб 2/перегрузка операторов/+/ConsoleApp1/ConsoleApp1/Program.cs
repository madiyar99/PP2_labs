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
            plus c1 = new plus(2, 3);
            plus c2 = new plus(7, 9);

            plus result = c1 + c2;

            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
