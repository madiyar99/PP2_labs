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
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Clear();

            while (true)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                if (keyInfo.Key == ConsoleKey.UpArrow)
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Up");
                }
                if (keyInfo.Key == ConsoleKey.DownArrow)
                {
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Down");
                }
                if (keyInfo.Key == ConsoleKey.LeftArrow)
                {
                    Console.BackgroundColor = ConsoleColor.Magenta;
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Left");
                }
                if (keyInfo.Key == ConsoleKey.RightArrow)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Right");
                }
                if (keyInfo.Key == ConsoleKey.Escape)
                    break;
                if (keyInfo.Key == ConsoleKey.Enter)
                    Console.Clear();
            }
        }
    }
}
