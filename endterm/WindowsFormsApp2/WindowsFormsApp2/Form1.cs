using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        Graphics g;
        Pen pen;
        int x, y, i, color;
        Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
            g = CreateGraphics();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            color = rand.Next(0, 5);
            if(color == 1)
            {
                pen = new Pen(Color.Red, 4);
            }
            if (color == 2)
            {
                pen = new Pen(Color.Blue, 4);
            }
            if (color == 3)
            {
                pen = new Pen(Color.Black, 4);
            }
            if (color == 4)
            {
                pen = new Pen(Color.Gray, 4);
            }
            else
            {
                pen = new Pen(Color.Green, 4);
            }

            i = i + 10;
            g.DrawEllipse(pen, x - 5 - i / 2, y - 5 - i / 2, 10 + i, 10 + i);
        }
    }
}
