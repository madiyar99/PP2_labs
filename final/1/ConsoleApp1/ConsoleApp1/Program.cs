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
            int num = 0;
            int count = 0;
            int count_pol = 0;
            int c = 0;
            string s;
            string s_num;

            s_num = Console.ReadLine();
            num = int.Parse(s_num);

            while(num > 0)
            {
                s = Console.ReadLine();
                string[] arr = s.Split(' ');
                /*
                for (int i = 0; i < s.Length; i++)
                {
                    if (i != s.Length - 1 && i != 0)
                    {
                        if (s[i] == ' ' && s[i - 1] != ' ' && s[i + 1] != ' ')
                        {
                            count++;
                        }
                    }
                }
                */
                count = arr.Length + count;

                for (int i = 0; i < arr.Length; i++)
                {
                    for (int j = 0; j < arr[i].Length / 2; j++)
                    {
                        if (arr[i][j] == arr[i][arr[i].Length - j - 1])
                        {
                            c++;
                        }
                    }

                    if (c == arr[i].Length / 2)
                    {
                        count_pol++;
                        c = 0;
                    }
                    else c = 0;
                }

                s = "";
                num--;
            }

            Console.WriteLine(count_pol);
            Console.WriteLine(count);
            Console.ReadKey();
        }
    }
}
