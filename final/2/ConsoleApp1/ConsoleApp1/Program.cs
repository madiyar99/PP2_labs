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
            int num = 1;
            int count = 0;
            while (num < 6)
            {
                StreamReader sr = new StreamReader(@"C:\Users\Asus\Desktop\final\2\f" + num + ".txt");

                string s = sr.ReadToEnd();
                string[] arr = s.Split(' ');

                for(int i = 0; i < arr.Length; i++)
                {
                    int n = int.Parse(arr[i]);
                    for(int j = 1; j <= n; j++)
                    {
                        if(n % j == 0)
                        {
                            count++;
                        }
                        if(count > 2)
                        {
                            count = 0;
                            break;
                        }
                    }
                    if(count == 2)
                    {
                        Console.WriteLine("f" + num);
                        break;
                    }
                }

                Console.WriteLine(s);
                num++;
            }
            Console.ReadKey();
        }
    }
}
