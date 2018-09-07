using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Bitmap bmp;
        Graphics bmpgraphics;

        Bitmap bmp1;
        Graphics bmpgraphics1;

        Bitmap bmp2;
        Graphics bmpgraphics2;

        int x, y, numX, numY;
        int initialX, initialY;
        int enemy_initX, enemy_initY, enemy_numX, enemy_numY;
        int count = 0, counter = 0, func1_num, func2_num;
        string tool, dir;
        int tool_num, s1, s2, s3, s4;
        int tempX, tempY;
        int sum_my, sum_enemy;
        List<Point> body = new List<Point>();
        Color enemy_c, my_c;
        bool click = false, point = false;
        Random rand = new Random();



        Pen pen = new Pen(Color.White);

        public Form1()
        {
            InitializeComponent();
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = bmp;
            bmpgraphics = Graphics.FromImage(bmp);

            bmp1 = new Bitmap(pictureBox2.Width, pictureBox2.Height);
            pictureBox2.Image = bmp1;
            bmpgraphics1 = Graphics.FromImage(bmp1);

            bmp2 = new Bitmap(pictureBox3.Width, pictureBox3.Height);
            pictureBox3.Image = bmp2;
            bmpgraphics2 = Graphics.FromImage(bmp2);
        }

        public int func1(int a, int f_numX, int f_numY, Bitmap f_bmp) //функция првоерки точек возле корабля - горизонтально
        {
            Color c, c1, c2;
            int proverka = 0;
            
            if (f_numY != 0)
            {
                if(f_numX != 0)
                {
                    for (int i = -1; i < 1 + a; i++)
                    {
                        c1 = f_bmp.GetPixel(((f_numX + i) * 20 + 1), ((f_numY - 1) * 20 + 1));
                        if (c1.R == 0 && c1.G == 0 && c1.B == 0)
                        {
                            proverka++;
                        }
                    }
                }
                else
                {
                    proverka++;
                    for (int i = 0; i < 1 + a; i++)
                    {
                        c1 = f_bmp.GetPixel(((f_numX + i) * 20 + 1), ((f_numY - 1) * 20 + 1));
                        if (c1.R == 0 && c1.G == 0 && c1.B == 0)
                        {
                            proverka++;
                        }
                    }
                }
            }
            else
                proverka = proverka + a + 2;

            if(f_numY != 9)
            {
                if (f_numX != 0)
                {
                    for (int i = -1; i < 1 + a; i++)
                    {
                        c2 = f_bmp.GetPixel(((f_numX + i) * 20 + 1), ((f_numY + 1) * 20 + 1));
                        if (c2.R == 0 && c2.G == 0 && c2.B == 0)
                        {
                            proverka++;
                        }
                    }
                }
                else
                {
                    proverka++;
                    for (int i = 0; i < 1 + a; i++)
                    {
                        c2 = f_bmp.GetPixel(((f_numX + i) * 20 + 1), ((f_numY + 1) * 20 + 1));
                        if (c2.R == 0 && c2.G == 0 && c2.B == 0)
                        {
                            proverka++;
                        }
                    }
                }
            }
            else
                proverka = proverka + a + 2;

            if (f_numX != 0)
            {
                c = f_bmp.GetPixel((f_numX - 1) * 20 + 1, f_numY * 20 + 1);
                if (c.R == 0 && c.G == 0 && c.B == 0)
                {
                    proverka++;
                }
            }
            else
                proverka = proverka + 1;

            if (f_numX + a != 10)
            {
                c = f_bmp.GetPixel((f_numX + a) * 20 + 1, f_numY * 20 + 1);
                if (c.R == 0 && c.G == 0 && c.B == 0)
                {
                    proverka++;
                }
            }
            else
                proverka = proverka + 1;

            return proverka;
        }

        public int func2(int a, int f_numX, int f_numY, Bitmap f_bmp) //функция првоерки точек возле корабля - вертикально
        {
            Color c, c1, c2;
            int proverka = 0;
            
            if (f_numX != 0) //Проверяет точки слева
            {
                if (f_numY != 0)
                {
                    if(f_numY + a == 10)
                    {
                        proverka++;
                        for (int i = -1; i < a; i++)
                        {
                            c1 = f_bmp.GetPixel(((f_numX - 1) * 20 + 1), ((f_numY + i) * 20 + 1));
                            if (c1.R == 0 && c1.G == 0 && c1.B == 0)
                            {
                                proverka++;
                            }
                        }
                    }
                    else
                    {
                        for (int i = -1; i < 1 + a; i++)
                        {
                            c1 = f_bmp.GetPixel(((f_numX - 1) * 20 + 1), ((f_numY + i) * 20 + 1));
                            if (c1.R == 0 && c1.G == 0 && c1.B == 0)
                            {
                                proverka++;
                            }
                        }
                    }
                }

                else
                {
                    proverka++;
                    for (int i = 0; i < 1 + a; i++)
                    {
                        c1 = f_bmp.GetPixel(((f_numX - 1) * 20 + 1), ((f_numY + i) * 20 + 1));
                        if (c1.R == 0 && c1.G == 0 && c1.B == 0)
                        {
                            proverka++;
                        }
                    }
                }
            }
            else
                proverka = proverka + a + 2;

            if (f_numX != 9) //Проверяет точки справа
            {
                if (f_numY != 0)
                {
                    if(f_numY + a == 10)
                    {
                        proverka++;
                        for (int i = -1; i < a; i++)
                        {
                            c2 = f_bmp.GetPixel(((f_numX + 1) * 20 + 1), ((f_numY + i) * 20 + 1));
                            if (c2.R == 0 && c2.G == 0 && c2.B == 0)
                            {
                                proverka++;
                            }
                        }
                    }
                    else
                    {
                        for (int i = -1; i < 1 + a; i++)
                        {
                            c2 = f_bmp.GetPixel(((f_numX + 1) * 20 + 1), ((f_numY + i) * 20 + 1));
                            if (c2.R == 0 && c2.G == 0 && c2.B == 0)
                            {
                                proverka++;
                            }
                        }
                    }
                }
                else
                {
                    proverka++;
                    for (int i = 0; i < 1 + a; i++)
                    {
                        c2 = f_bmp.GetPixel(((f_numX + 1) * 20 + 1), ((f_numY + i) * 20 + 1));
                        if (c2.R == 0 && c2.G == 0 && c2.B == 0)
                        {
                            proverka++;
                        }
                    }
                }
            }
            else
                proverka = proverka + a + 2;

            if (f_numY != 0)
            {
                c = f_bmp.GetPixel(f_numX * 20 + 1, (f_numY - 1) * 20 + 1);
                if (c.R == 0 && c.G == 0 && c.B == 0)
                {
                    proverka++;
                }
            }
            else
                proverka = proverka + 1;

            if (f_numY + a != 10)
            {
                c = f_bmp.GetPixel(f_numX * 20 + 1, (f_numY + a) * 20 + 1);
                if (c.R == 0 && c.G == 0 && c.B == 0)
                {
                    proverka++;
                }
            }
            else
                proverka = proverka + 1;

            return proverka;
        }

        private void ship_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if(btn == ship4)
            {
                tool = "ship4";
                tool_num = 4;
            }
            else if(btn == ship3)
            {
                tool = "ship3";
                tool_num = 3;
            }
            else if(btn == ship2)
            {
                tool = "ship2";
                tool_num = 2;
            }
            else if(btn == ship1)
            {
                tool = "ship1";
                tool_num = 1;
            }
        }

        private void direct_Click(object sender, EventArgs e)
        {
            Button btn_dir = (Button)sender;

            if(btn_dir == hor)
            {
                dir = "hor";
            }

            else if(btn_dir == vertic)
            {
                dir = "vertic";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {             
                    bmpgraphics.DrawRectangle(new Pen(Color.Black, 2), j * 20, i * 20, 20, 20);
                    bmpgraphics1.DrawRectangle(new Pen(Color.Black, 2), j * 20, i * 20, 20, 20);
                    bmpgraphics2.DrawRectangle(new Pen(Color.Black, 2), j * 20, i * 20, 20, 20);
                }
            }

            bmpgraphics1.FillRectangle(new SolidBrush(Color.Blue), 0, 60, 20, 80);

            bmpgraphics1.FillRectangle(new SolidBrush(Color.Blue), 20, 180, 60, 20);
            bmpgraphics1.FillRectangle(new SolidBrush(Color.Blue), 40, 100, 20, 60);

            bmpgraphics1.FillRectangle(new SolidBrush(Color.Blue), 180, 0, 20, 40);
            bmpgraphics1.FillRectangle(new SolidBrush(Color.Blue), 180, 80, 20, 40);
            bmpgraphics1.FillRectangle(new SolidBrush(Color.Blue), 100, 140, 40, 20);

            bmpgraphics1.FillRectangle(new SolidBrush(Color.Blue), 0, 0, 20, 20);
            bmpgraphics1.FillRectangle(new SolidBrush(Color.Blue), 180, 180, 20, 20);
            bmpgraphics1.FillRectangle(new SolidBrush(Color.Blue), 80, 0, 20, 20);
            bmpgraphics1.FillRectangle(new SolidBrush(Color.Blue), 120, 80, 20, 20);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            click = true;
            initialX = e.X;
            initialY = e.Y;
            if (count == 0)
            {
                numX = initialX / 20;
                numY = initialY / 20;
            }

        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            enemy_initX = e.X;
            enemy_initY = e.Y;

            enemy_numX = enemy_initX / 20;
            enemy_numY = enemy_initY / 20;
            enemy_c = bmp1.GetPixel(enemy_initX, enemy_initY);


            if(counter == 0)
            {
                tempX = rand.Next(0, 9);
                tempY = rand.Next(0, 9);
                my_c = bmp.GetPixel(tempX * 20 + 1, tempY * 20 + 1);
                body.Add(new Point(tempX, tempY));
            }
            else
            {
                while (true)
                {
                    tempX = rand.Next(0, 9);
                    tempY = rand.Next(0, 9);
                    for (int i = 0; i < body.Count; i++)
                    {
                        if (body[i].x == tempX && body[i].y == tempY)
                        {
                            point = true;
                            break;
                        }
                    }
                    if (point == false)
                    {
                        body.Add(new Point(tempX, tempY));
                        my_c = bmp.GetPixel(tempX * 20 + 1, tempY * 20 + 1);
                        break;
                    }
                    point = false;
                }
            }
            counter++;

        }

        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            if (enemy_c.R == 0 && enemy_c.G == 0 && enemy_c.B == 0)
            {
                bmpgraphics2.FillEllipse(new SolidBrush(Color.Blue), enemy_numX * 20 + 5, enemy_numY * 20 + 5, 8, 8);
                pictureBox3.Refresh();
            }
            else
            {
                bmpgraphics2.DrawLine(new Pen(Color.Red, 2), enemy_numX * 20, enemy_numY * 20, enemy_numX * 20 + 20, enemy_numY * 20 + 20);
                bmpgraphics2.DrawLine(new Pen(Color.Red, 2), enemy_numX * 20, enemy_numY * 20 + 20, enemy_numX * 20 + 20, enemy_numY * 20);
                pictureBox3.Refresh();
                sum_my++;
            }


            if(my_c.R == 0 && my_c.G == 0 && my_c.B == 0)
            {
                bmpgraphics.FillEllipse(new SolidBrush(Color.Blue), tempX * 20 + 5, tempY * 20 + 5, 8, 8);
                pictureBox1.Refresh();
            }
            else
            {
                bmpgraphics.DrawLine(new Pen(Color.Red, 2), tempX * 20, tempY * 20, tempX * 20 + 20, tempY * 20 + 20);
                bmpgraphics.DrawLine(new Pen(Color.Red, 2), tempX * 20, tempY * 20 + 20, tempX * 20 + 20, tempY * 20);
                pictureBox1.Refresh();
                sum_enemy++;
            }

            if(sum_my == 20)
            {
                MessageBox.Show("Вы победили!");
            }

            else if(sum_enemy == 20)
            {
                MessageBox.Show("Компьютер победил!");
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            click = false;

            if(dir == "hor" && numX + tool_num < 11)
            {
                func1_num = func1(tool_num, numX, numY, bmp);
                      
                if (func1_num == tool_num * 2 + 6)
                {
                    bmpgraphics.FillRectangle(new SolidBrush(Color.Green), numX * 20, numY * 20, tool_num * 20, 20);
                    pictureBox1.Refresh();
                    func1_num = 0;
                    count = 0;
               
                    if(tool == "ship1")
                    {
                        s1++;
                        if(s1 == 4)
                        {
                            ship1.Enabled = false;
                            tool = "no";
                            MessageBox.Show("Корабль - 1 закончился");
                        }
                    }

                    else if (tool == "ship2")
                    {
                        s2++;
                        if (s2 == 3)
                        {
                            ship2.Enabled = false;
                            tool = "no";
                            MessageBox.Show("Корабль - 2 закончился");
                        }
                    }

                    else if (tool == "ship3")
                    {
                        s3++;
                        if (s3 == 2)
                        {
                            ship3.Enabled = false;
                            tool = "no";
                            MessageBox.Show("Корабль - 3 закончился");
                        }
                    }

                    else if (tool == "ship4")
                    {
                        s4++;
                        if (s4 == 1)
                        {
                            ship4.Enabled = false;
                            tool = "no";
                            MessageBox.Show("Корабль - 4 закончился");
                        }
                    }
                }

                else
                {
                    // bmpgraphics.FillRectangle(new SolidBrush(Color.Red), numX * 20, numY * 20, 80, 20);
                    func1_num = 0;
                    count++;
                    pictureBox1.Refresh();
                }
            }

            else if(dir == "vertic" && numY + tool_num < 11)
            {
                func2_num = func2(tool_num, numX, numY, bmp);          
            
                if (func2_num == tool_num * 2 + 6)
                {
                    bmpgraphics.FillRectangle(new SolidBrush(Color.Green), numX * 20, numY * 20, 20, tool_num * 20);
                    pictureBox1.Refresh();
                    func2_num = 0;
                    count = 0;

                    if (tool == "ship1")
                    {
                        s1++;
                        if (s1 == 4)
                        {
                            ship1.Enabled = false;
                            tool = "no";
                            MessageBox.Show("Корабль - 1 закончился");
                        }
                    }

                    else if (tool == "ship2")
                    {
                        s2++;
                        if (s2 == 3)
                        {
                            ship2.Enabled = false;
                            tool = "no";
                            MessageBox.Show("Корабль - 2 закончился");
                        }
                    }

                    else if (tool == "ship3")
                    {
                        s3++;
                        if (s3 == 2)
                        {
                            ship3.Enabled = false;
                            tool = "no";
                            MessageBox.Show("Корабль - 3 закончился");
                        }
                    }

                    else if (tool == "ship4")
                    {
                        s4++;
                        if (s4 == 1)
                        {
                            ship4.Enabled = false;
                            tool = "no";
                            MessageBox.Show("Корабль - 4 закончился");
                        }
                    }
                }

                else
                {
                    // bmpgraphics.FillRectangle(new SolidBrush(Color.Red), numX * 20, numY * 20, 80, 20);
                    func2_num = 0;
                    count++;
                    pictureBox1.Refresh();
                }
            }

        pictureBox1.Refresh();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            
            if(dir == "hor" && numX + tool_num < 11)
            {                               
                func1_num = func1(tool_num, numX, numY, bmp);
           
                if (func1_num == tool_num * 2 + 6)
                {
                    e.Graphics.FillRectangle(new SolidBrush(Color.Green), numX * 20, numY * 20, 20 * tool_num, 20);
                    func1_num = 0;
                }
                
                else if (func1_num != tool_num * 2 + 6)
                {
                    e.Graphics.FillRectangle(new SolidBrush(Color.Red), numX * 20, numY * 20, 20 * tool_num, 20);
                    func1_num = 0;
                }
            }

            else if (dir == "vertic" && numY + tool_num < 11)
            {
                func2_num = func2(tool_num, numX, numY, bmp);
          
                if (func2_num == tool_num * 2 + 6)
                {
                    e.Graphics.FillRectangle(new SolidBrush(Color.Green), numX * 20, numY * 20, 20, 20 * tool_num);
                    func2_num = 0;
                }

                else if (func2_num != tool_num * 2 + 6)
                {
                    e.Graphics.FillRectangle(new SolidBrush(Color.Red), numX * 20, numY * 20, 20, 20 * tool_num);
                    func2_num = 0;
                }
            }

        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (count != 0 && click == true)
            {
                x = e.X;
                y = e.Y;
                numX = x / 20;
                numY = y / 20;
            }

            if (click)
                pictureBox1.Refresh();
        }
    }
}
