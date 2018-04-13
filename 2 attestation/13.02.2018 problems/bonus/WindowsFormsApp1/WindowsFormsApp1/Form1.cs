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

        int x = 20, y = 200, result = 0;
        int dx = 1;
        bool proverka = true;
        Random rand = new Random();
        int tempX1 = 123, tempY1 = 0;
        int tempX2 = 357, tempY2 = -10;
        int tempX3 = 200, tempY3 = -22;
        int tempX4 = 50, tempY4 = 0;
        int tempX5 = 499, tempY5 = -45;

        private void button1_Click(object sender, EventArgs e)
        {
            proverka = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            proverka = true;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          
            if (proverka == false)
            {
                x -= dx;
                label1.Location = new Point(x, y);
            }
                
            if (proverka == true)
            {
                x += dx;
                label1.Location = new Point(x, y);
            }
                      
            tempY1++;
            tempY2++;
            tempY3++;
            tempY4++;
            tempY5++;

            label2.Location = new Point(tempX1, tempY1);
            label3.Location = new Point(tempX2, tempY2);
            label4.Location = new Point(tempX3, tempY3);
            label5.Location = new Point(tempX4, tempY4);
            label6.Location = new Point(tempX5, tempY5);

            if (Math.Abs(x - tempX1) < 28 && tempY1 == 200)
            {
                timer1.Enabled = false;
                MessageBox.Show("GAME OVER!!! Your score: " + result);
            }

            if (Math.Abs(x - tempX2) < 28 && tempY2 == 200)
            {
                timer1.Enabled = false;
                MessageBox.Show("GAME OVER!!! Your score: " + result);
            }

            if (Math.Abs(x - tempX3) < 28 && tempY3 == 200)
            {
                timer1.Enabled = false;
                MessageBox.Show("GAME OVER!!! Your score: " + result);
            }

            if (Math.Abs(x - tempX4) < 28 && tempY4 == 200)
            {
                timer1.Enabled = false;
                MessageBox.Show("GAME OVER!!! Your score: " + result);
            }

            if (Math.Abs(x - tempX5) < 28 && tempY5 == 200)
            {
                timer1.Enabled = false;
                MessageBox.Show("GAME OVER!!! Your score: " + result);
            }

            if (tempY1 > Height)
            {
                tempX1 = rand.Next(140, 400);
                tempY1 = 0;
                result += 10;
            }

            if(tempY2 > Height)
            {
                tempX2 = rand.Next(140, 400);
                tempY2 = -10;
                result += 10;
            }

            if (tempY3 > Height)
            {
                tempX3 = rand.Next(140, 400);
                tempY3 = -22;
                result += 10;
            }

            if (tempY4 > Height)
            {
                tempX4 = rand.Next(140, 400);
                tempY4 = 0;
                result += 10;
            }

            if (tempY5 > Height)
            {
                tempX5 = rand.Next(140, 400);
                tempY5 = 0;
                result += 10;
            }

            label7.Text = "result: " + result.ToString();
        }
    }
}
