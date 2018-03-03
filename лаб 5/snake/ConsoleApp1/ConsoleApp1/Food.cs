using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class Food
    {
        public Random rand = new Random();
        public int tempX, tempY, result = 0;
        public bool proverka = true;

        public void food(int level)
        {
            while (true)
            {
                tempX = rand.Next(2, 20);
                tempY = rand.Next(2, 12);
                Console.ReadKey();
                StreamReader br = new StreamReader(@"C:\Users\Asus\Desktop\PP2_labs_local\лаб 5\snake\level" + level + ".txt");
                int k = int.Parse(br.ReadLine());
                for (int i = 0; i < k; i++)
                {
                    string s1 = br.ReadLine();
                    if (tempX == i && s1[tempY] != '*')
                    {
                        br.Close();
                        proverka = false;
                        break;
                    }
                }
                if (proverka == false) break;
                proverka = true;
            }
        }

        public Food(int level)
        {
            food(level);
        }

        public void Draw()
        {
            Console.SetCursorPosition(tempX, tempY);
            Console.Write("F");

            Console.SetCursorPosition(0, 20);
            Console.WriteLine("Result = " + result);
        }
    }
}
