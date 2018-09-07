using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Bitmap bmp;
        Graphics bmpgraphics;
        Random rand = new Random();
        Graphics g;
        Color c1, c2, c3, c4, c5, c6;
        Color cc1, cc2;
        int speed = 5;
        int count = 0;
        int sum;
        int num1, num2, num3, num4, num5, num6;

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if(cc1.R == cc2.R && cc1.G == cc2.G && cc1.B == cc2.B && count == 2)
            {
                if(c1.R == cc2.R && c1.G == cc2.G && c1.B == cc2.B)
                {
                    c1 = Color.White;
                }
                if (c2.R == cc2.R && c2.G == cc2.G && c2.B == cc2.B)
                {
                    c2 = Color.White;
                }
                if (c3.R == cc2.R && c3.G == cc2.G && c3.B == cc2.B)
                {
                    c3 = Color.White;
                }
                if (c4.R == cc2.R && c4.G == cc2.G && c4.B == cc2.B)
                {
                    c4 = Color.White;
                }
                if (c5.R == cc2.R && c5.G == cc2.G && c5.B == cc2.B)
                {
                    c5 = Color.White;
                }
                if (c6.R == cc2.R && c6.G == cc2.G && c6.B == cc2.B)
                {
                    c6 = Color.White;
                }
                count = 0;
                speed = speed + 5;
                sum -= 2;
            }
            else if(count == 2)
            {
                count = 0;
            }

        }

        int x, y;

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;

            count++;
            if(count == 1)
            {
                cc1 = bmp.GetPixel(x, y);
               
            }
            if (count == 2)
            {
                cc2 = bmp.GetPixel(x, y);
             
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {

        }

        int x1, y1, x2, y2, x3, y3, x4, y4, x5, y5, x6, y6;

        public Color func(int n)
        {
            Color c = Color.Red;

            if (n == 0)
                c = Color.Red;
            if (n == 1)
                c = Color.Blue;
            if (n == 2)
                c = Color.Green;
            if (n == 3)
                c = Color.Orange;
            if (n == 4)
                c = Color.PaleGoldenrod;
            if (n == 5)
                c = Color.Beige;
            if (n == 6)
                c = Color.Black;
            if (n == 7)
                c = Color.GhostWhite;
            if (n == 8)
                c = Color.Gold;
            if (n == 9)
                c = Color.Magenta;
            if (n == 10)
                c = Color.MediumPurple;

            return c;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {          

        }

        int i;

        public Form1()
        {
            InitializeComponent();
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = bmp;
            bmpgraphics = Graphics.FromImage(bmp);
           
            x1 = rand.Next(0, 1000);
            x2 = rand.Next(0, 1000);
            x3 = rand.Next(0, 1000);
            x4 = rand.Next(0, 1000);
            x5 = rand.Next(0, 1000);
            x6 = rand.Next(0, 1000);

            y1 = rand.Next(0, 300);
            y2 = rand.Next(0, 500);
            y3 = rand.Next(0, 100);
            y4 = rand.Next(0, 200);
            y5 = rand.Next(0, 300);
            y6 = rand.Next(0, 400);

            num1 = rand.Next(0, 10);
            c1 = func(num1);

            num2 = rand.Next(0, 10);
            c2 = func(num2);

            num3 = rand.Next(0, 10);
            c3 = func(num3);

            num4 = rand.Next(0, 10);
            c4 = func(num4);

            num5 = rand.Next(0, 10);
            c5 = func(num5);

            num6 = rand.Next(0, 10);
            c6 = func(num6);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bmpgraphics.Clear(Color.White);

            bmpgraphics.FillEllipse(new SolidBrush(c1), x1, y1 + i, 40, 40);
            bmpgraphics.FillEllipse(new SolidBrush(c2), x2, y2 + i, 40, 40);
            bmpgraphics.FillEllipse(new SolidBrush(c3), x3, y3 + i, 40, 40);
            bmpgraphics.FillEllipse(new SolidBrush(c4), x4, y4 + i, 40, 40);
            bmpgraphics.FillEllipse(new SolidBrush(c5), x5, y5 + i, 40, 40);
            bmpgraphics.FillEllipse(new SolidBrush(c6), x6, y6 + i, 40, 40);

            i += speed;
            pictureBox1.Refresh();

            if (i > 700)
            {
                sum += 6;
                if(sum >= 20)
                {
                    timer1.Enabled = false;
                    MessageBox.Show("game over");
      
                    sum = 0;
                }
                i = 0;
                x1 = rand.Next(0, 800);
                x2 = rand.Next(0, 800);
                x3 = rand.Next(0, 800);
                x4 = rand.Next(0, 800);
                x5 = rand.Next(0, 800);
                x6 = rand.Next(0, 800);

                y1 = rand.Next(0, 150);
                y2 = rand.Next(0, 200);
                y3 = rand.Next(0, 200);
                y4 = rand.Next(0, 200);
                y5 = rand.Next(0, 100);
                y6 = rand.Next(0, 100);

                num1 = rand.Next(0, 10);
                c1 = func(num1);

                num2 = rand.Next(0, 10);
                c2 = func(num2);

                num3 = rand.Next(0, 10);
                c3 = func(num3);

                num4 = rand.Next(0, 10);
                c4 = func(num4);

                num5 = rand.Next(0, 10);
                c5 = func(num5);

                num6 = rand.Next(0, 10);
                c6 = func(num6);
            }
        }
    }
}
