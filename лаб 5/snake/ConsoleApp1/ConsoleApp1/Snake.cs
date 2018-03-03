using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{ 
    class Snake
    {
        Wall wall1 = new Wall();
        List<Point> body;
        string sign;
        ConsoleColor color;
        public int cnt;
        public int result;
        public int golovaX, golovaY;
        public int tailX, tailY, tail1X, tail1Y; 

        public Snake()
        {
            body = new List<Point>();
            body.Add(new Point(5, 5));
            sign = "*";
            color = ConsoleColor.Yellow;
            cnt = 0;
        }

        public void Move(int dx, int dy)
        {
            cnt++;
            if (cnt % 20 == 0)
            {
                body.Add(new Point(0, 0));
            }

            for (int i = body.Count - 1; i > 0; i--)
            {
                body[i].x = body[i - 1].x;
                body[i].y = body[i - 1].y;
            }

            if (body.Count == 1)
            {
                tail1X = body[0].x;
                tail1Y = body[0].y;
            }

            golovaX = body[0].x;
            golovaY = body[0].y;

            body[0].x += dx;
            body[0].y += dy;

            tailX = body[body.Count - 1].x;
            tailY = body[body.Count - 1].y;            

            if (body[0].x < 1)
                body[0].x = Console.WindowWidth - 1;
            if (body[0].x > Console.WindowWidth - 1)
                body[0].x = 1;

            if (body[0].y < 1)
                body[0].y = Console.WindowHeight - 1;
            if (body[0].y > Console.WindowHeight - 1)
                body[0].y = 1;
        }

        public void Draw()
        {

            int index = 0;
            foreach (Point p in body)
            {
                if (index == 0)
                    Console.ForegroundColor = ConsoleColor.Green;
                else
                    Console.ForegroundColor = color;
                Console.SetCursorPosition(p.x, p.y);
                Console.Write(sign);
                index++;
            }

            if (body.Count != 1)
            {
                Console.SetCursorPosition(tailX, tailY);
                Console.Write(" ");
            }

            else if(body.Count == 1)
            {
                Console.SetCursorPosition(tail1X, tail1Y);
                Console.Write(" ");
            }

        }

        public bool CollisionWithWall(Wall w)
        {
            foreach (Point p in w.body)
            {
                if (p.x == body[0].x && p.y == body[0].y)
                    return true;
            }
            return false;
        }

        public bool Collision()
        {
            for (int i = 1; i < body.Count; i++)
            {
                if (body[0].x == body[i].x && body[0].y == body[i].y)
                    return true;
            }
            return false;
        }

        

    }
}
