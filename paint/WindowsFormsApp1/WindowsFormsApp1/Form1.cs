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
        bool clicked;
        int tool = 0;
        Point prev, cur;
        int count = 0;
        int width, height;
        public Form1()
        {
            InitializeComponent();
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = bmp;
            bmpgraphics = Graphics.FromImage(bmp);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (tool == 1)
            {
                //e.Graphics.Clear(Color.White);
                if(count != 2)
                {
                   e.Graphics.DrawRectangle(new Pen(Color.Blue), prev.X, prev.Y, cur.X - prev.X, cur.Y - prev.Y);
                }
                if (count == 2)
                {
                   e.Graphics.DrawRectangle(new Pen(Color.Red), prev.X + (cur.X - prev.X), prev.Y + (cur.Y - prev.Y), width, height);               
                }
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if(btn.Text == "Pen")
            {
                tool = 0;
            }
            else
            {
                tool = 1;
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            clicked = false;
            if(tool == 1 && count != 2)
            {
                //bmpgraphics.DrawRectangle(new Pen(Color.Red), prev.X, prev.Y, cur.X - prev.X, cur.Y - prev.Y);
                pictureBox1.Refresh();
                width = cur.X - prev.X;
                height = cur.Y - prev.Y;
            }

            if(tool == 1 && count == 2)
            {
                bmpgraphics.DrawRectangle(new Pen(Color.Red), prev.X + (cur.X - prev.X), prev.Y + (cur.Y - prev.Y), width, height);
                pictureBox1.Refresh();
                count = 0;
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            clicked = true;
            prev = e.Location;
            if(tool == 1)
            {
                count++;
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            cur = e.Location;
            if (clicked)
            {
                if (tool == 0)
                {
                    bmpgraphics.DrawLine(new Pen(Color.Black), prev.X, prev.Y, cur.X, cur.Y);
                    prev = cur;
                }
                pictureBox1.Refresh();
            }

            /*if (clicked)
            {
                if(tool == 1 && count == 2)
                {
                    bmpgraphics.DrawRectangle(new Pen(Color.Red), prev.X + (cur.X - prev.X), prev.Y + (cur.Y - prev.Y), width, height);                 
                }
                pictureBox1.Refresh();
            } */
        }

    }
}
