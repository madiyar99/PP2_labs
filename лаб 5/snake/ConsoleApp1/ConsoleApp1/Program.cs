using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static int direction = 1; // 1 - right, 2 - left, 3 - down, 4 - up
        static int level = 1;
        static Snake snake = new Snake();
        static Wall wall = new Wall(1);
        static Food food1 = new Food(level);

        
        static int speed = 400;
       
        public static void func()
        {
       
            while (true)
            {

                if (direction == 3)
                    snake.Move(0, 1);
                if (direction == 4)
                    snake.Move(0, -1);
                if (direction == 2)
                    snake.Move(-1, 0);
                if (direction == 1)
                    snake.Move(1, 0);


                if (snake.CollisionWithWall(wall) || snake.Collision())
                {
                    Console.Clear();
                    Console.SetCursorPosition(53, 10);
                    Console.WriteLine("GAME OVER!!!!");
                    Console.ReadKey();
                    Console.Clear();
                    snake = new Snake();
                    level = 1;
                    wall = new Wall(level);
                    Food food1 = new Food(level);
                    speed = 400;
                    food1.result = 0;
                }

                if (snake.golovaX == food1.tempX && snake.golovaY == food1.tempY)
                {
                    food1.result += 10;
                    food1.food(level);
                }

                snake.Draw();
                wall.Draw();
                food1.Draw();
               
                if (snake.cnt % 50 == 0)
                    speed = Math.Max(1, speed - 100);
                Thread.Sleep(speed);

            }
        }

        static void Main(string[] args)
        {
           
            Thread thread = new Thread(func);
            thread.Start();

            Console.CursorVisible = false;

            while (true)
            {

                ConsoleKeyInfo keyInfo = Console.ReadKey();
                if (keyInfo.Key == ConsoleKey.DownArrow && direction != 4)
                    direction = 3;
                if (keyInfo.Key == ConsoleKey.UpArrow)
                    direction = 4;
                if (keyInfo.Key == ConsoleKey.LeftArrow)
                    direction = 2;
                if (keyInfo.Key == ConsoleKey.RightArrow)
                    direction = 1;

                if (keyInfo.Key == ConsoleKey.R)
                {
                   
                    Console.Clear();
                    level = 1;
                    snake = new Snake();
                    wall = new Wall(level);
                    Food food1 = new Food(level);
                }

                if (snake.cnt % 400 == 0)
                {
                    level++;
                    wall = new Wall(level);
                }
          
            }

 
        }
    }
}
