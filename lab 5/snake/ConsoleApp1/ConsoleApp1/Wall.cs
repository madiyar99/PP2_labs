using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class Wall
    {
        public List<Point> body;
        public string sign;
        public ConsoleColor color;
        public Random rand = new Random();
        public int tempX, tempY, result = 0;
        public bool proverka = false;

        public void ReadLevel(int level)
        {
            StreamReader sr = new StreamReader(@"C:\Users\Asus\Desktop\PP2_labs_local\lab 5\snake\level" + level + ".txt");
            int n = int.Parse(sr.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string s = sr.ReadLine();
                for (int j = 0; j < s.Length; j++)
                    if (s[j] == '*')
                        body.Add(new Point(j, i));
            }
            sr.Close();

            while (true)
            {
                tempX = rand.Next(2, 17);
                tempY = rand.Next(5, 17);
                StreamReader br = new StreamReader(@"C:\Users\Asus\Desktop\PP2_labs_local\lab 5\snake\level" + level + ".txt");
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
            }
            proverka = true;
        }

        public Wall(){}

        public Wall(int level)
        {
            body = new List<Point>();
            sign = "o";
            color = ConsoleColor.Magenta;
            ReadLevel(level);
        }

        public void Draw()
        {
            Console.ForegroundColor = color;
            foreach (Point p in body)
            {
                Console.SetCursorPosition(p.x, p.y);
                Console.Write(sign);
            }
            Console.SetCursorPosition(tempX, tempY);
            Console.Write("@");
        }
    }
}
