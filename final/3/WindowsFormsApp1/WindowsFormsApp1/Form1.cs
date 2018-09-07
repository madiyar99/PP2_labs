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
        Button[,] btn1 = new Button[3, 3];
        bool check = false;
        int count1 = 0, count2 = 0, count3 = 0;
        string tool;
        public Form1()
        {
            InitializeComponent();
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3;j++)
                {
                    Button b = new Button();
                    b.Size = new Size(50, 50);
                    b.Location = new Point(50 + 50 * i, 50 + 50 * j);
                    b.Click += button_Click;
                    Controls.Add(b);
                    btn1[i, j] = b;
                }
            }
        }


        private void button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if(check == false)
            {
                btn.Text = "X";
                tool = "X";
                check = true;
                btn.Enabled = false;
            }
            else if(check == true)
            {
                btn.Text = "O";
                tool = "O";
                check = false;
                btn.Enabled = false;
            }

            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    if(btn1[i, j].Text == tool)
                    {
                        count1++;
                    }
                    if(btn1[j, i].Text == tool)
                    {
                        count2++;
                    }
                }
                if (count1 == 3)
                {
                    MessageBox.Show("Game over");
                    break;
                }
                if( count2 == 3)
                {
                    MessageBox.Show("Game over");
                    break;
                }
                else
                {
                    count1 = 0;
                    count2 = 0;
                }
            }

            if (btn1[0, 0].Text == tool && btn1[1, 1].Text == tool && btn1[2, 2].Text == tool)
                MessageBox.Show("Game over");
            if (btn1[0, 2].Text == tool && btn1[1, 1].Text == tool && btn1[2, 0].Text == tool)
                MessageBox.Show("Game over");

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
