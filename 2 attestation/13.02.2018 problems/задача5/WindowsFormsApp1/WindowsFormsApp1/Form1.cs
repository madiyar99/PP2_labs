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
        int dx = 1, dy = 1;
        int x = 2, y = 5;
       
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            x += dx;
            y += dy;

            if(x == Width)
            {
                dx *= -1;
            }

            if(y == Height)
            {
                dy *= -1;
            }

            if(x == 0)
            {
                dx *= -1;
            }

            if(y == 0)
            {
                dy *= -1;
            }

            label1.Location = new Point(x, y);
        }
    }
}
