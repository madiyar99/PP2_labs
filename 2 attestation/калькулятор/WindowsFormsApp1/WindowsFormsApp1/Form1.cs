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
        double d, perc, fact = 1, memory_value;
        int count = 0, length, znak_count, znak_count1;
        string str;
        string znak;
        double value;

        public Form1()
        {
            InitializeComponent();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "";
            znak = "";
            str = "";
            value = 0;
            count = 0;
            fact = 0;
            d = 0;
        }

        private void back_Click(object sender, EventArgs e)
        {
            length = textBox1.Text.Length;
            if(length == 1)
            {
                textBox1.Text = "0";
            }
            else
            {
                str = textBox1.Text;
                textBox1.Text = "";
                for (int i = 0; i < length - 1; i++)
                {
                    textBox1.Text = textBox1.Text + str[i];
                }
            }
        }

        private void plus_minus_Click(object sender, EventArgs e)
        {
            length = textBox1.Text.Length;
            str = textBox1.Text;
            if(str[0] == '-')
            {
                textBox1.Text = "";
                for(int i = 1; i < length; i++)
                {
                    textBox1.Text = textBox1.Text + str[i];
                }
            }
            else
            {
                textBox1.Text = "-" + textBox1.Text;
            }         
        }

        private void comma_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + comma.Text;
        }

        private void num1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (textBox1.Text == "0" || znak_count != 0)
                textBox1.Text = "";
            textBox1.Text = textBox1.Text + btn.Text;
            znak_count = 0;
        }

        private void znak_Click(object sender, EventArgs e)
        {
            Button btn_zn = (Button)sender;

            znak = btn_zn.Text;
            if(znak_count1 == 0)
            {
                value = double.Parse(textBox1.Text);
            }
            textBox2.Text = value + " " + znak;
            //textBox1.Text = "";
            count = 0;
            d = 0;
            znak_count++;
            znak_count1++;
        }

        private void memory_Click(object sender, EventArgs e)
        {
            Button btn_mem = (Button)sender;
            if(btn_mem == MS)
            {
                memory_value = double.Parse(textBox1.Text);
            }

            else if(btn_mem == M_minus)
            {
                memory_value = memory_value - double.Parse(textBox1.Text);
            }

            else if (btn_mem == M_plus)
            {
                memory_value = memory_value + double.Parse(textBox1.Text);
            }

            else if (btn_mem == MR)
            {
                textBox1.Text = (memory_value).ToString();
            }

            else if (btn_mem == MC)
            {
                memory_value = 0;
            }

        }

        private void CE_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void func_Click(object sender, EventArgs e)
        {
            Button btn_func = (Button)sender;
            if(btn_func == square)
            {
                textBox2.Text = "sqr(" + double.Parse(textBox1.Text) + ")";
                textBox1.Text = (double.Parse(textBox1.Text) * double.Parse(textBox1.Text)).ToString();
            }

            else if(btn_func == change)
            {
                textBox2.Text = "1 / (" + double.Parse(textBox1.Text) + ")";
                textBox1.Text = (1 / double.Parse(textBox1.Text)).ToString();
            }

            else if(btn_func == root)
            {
                textBox2.Text = "1 √ (" + double.Parse(textBox1.Text) + ")";
                textBox1.Text = Math.Sqrt(double.Parse(textBox1.Text)).ToString();
            }

            else if(btn_func == percent)
            {
                if(znak == "+")
                {
                    perc = double.Parse(textBox1.Text);
                    perc = (perc * value) / 100;
                    textBox2.Text = value + " + " + perc;
                    textBox1.Text = perc + "";
                }

                else if(znak == "X")
                {
                    perc = double.Parse(textBox1.Text);
                    perc = (perc * value) / 100;
                    textBox2.Text = value + " X " + perc;
                    textBox1.Text = perc + "";
                }
            }

            else if(btn_func == p)
            {
                textBox1.Text = "3,1415926535897932";
            }

            else if(btn_func == factorial)
            {
                textBox2.Text = "fact(" + double.Parse(textBox1.Text) + ")";
                for(int i = 1; i <= double.Parse(textBox1.Text); i++)
                {
                    fact = fact * i;
                }
                textBox1.Text = fact + "";
                fact = 1;
            }

            else if(btn_func == ln)
            {
                textBox2.Text = "ln(" + double.Parse(textBox1.Text) + ")";
                textBox1.Text = Math.Log(double.Parse(textBox1.Text)).ToString();
            }

            else if(btn_func == ex)
            {
                textBox2.Text = "e^(" + double.Parse(textBox1.Text) + ")";
                textBox1.Text = Math.Pow(2.7182, double.Parse(textBox1.Text)).ToString();
            }

            else if(btn_func == x10)
            {
                textBox2.Text = "10^(" + double.Parse(textBox1.Text) + ")";
                textBox1.Text = Math.Pow(10, double.Parse(textBox1.Text)).ToString();
            }

            else if(btn_func == sin)
            {
                textBox2.Text = "sin(" + double.Parse(textBox1.Text) + ")";
                textBox1.Text = Math.Sin(double.Parse(textBox1.Text) * Math.PI / 180).ToString();
            }

            else if (btn_func == cos)
            {
                textBox2.Text = "cos(" + double.Parse(textBox1.Text) + ")";
                if (double.Parse(textBox1.Text) % 90 == 0 && (double.Parse(textBox1.Text) / 90) % 2 != 0)
                {
                    textBox1.Text = "0";
                }
                else
                {
                    textBox1.Text = Math.Cos(double.Parse(textBox1.Text) * Math.PI / 180).ToString();
                }
            }

            else if (btn_func == tan)
            {
                textBox2.Text = "tan(" + double.Parse(textBox1.Text) + ")";
                if (double.Parse(textBox1.Text) % 90 == 0 && (double.Parse(textBox1.Text) / 90) % 2 != 0)
                {
                    textBox1.Text = "Ошибка";
                }
                else
                {
                    textBox1.Text = Math.Tan(double.Parse(textBox1.Text) * Math.PI / 180).ToString();
                }
            }

            else if(btn_func == asin)
            {
                textBox2.Text = "sin^-1(" + double.Parse(textBox1.Text) + ")";
                textBox1.Text = (Math.Asin(double.Parse(textBox1.Text)) * 180 / Math.PI).ToString();
            }

            else if (btn_func == acos)
            {
                textBox2.Text = "acos^-1(" + double.Parse(textBox1.Text) + ")";
                textBox1.Text = (Math.Acos(double.Parse(textBox1.Text)) * 180 / Math.PI).ToString();
            }

            else if(btn_func == atan)
            {
                textBox2.Text = "atan^-1(" + double.Parse(textBox1.Text) + ")";
                textBox1.Text = (Math.Atan(double.Parse(textBox1.Text)) * 180 / Math.PI).ToString();
            }
        }

        private void equal_click(object sender, EventArgs e)
        {
            znak_count = 0;
            znak_count1 = 0;
            if(znak == "+")
            {
                if(count != 0)
                {
                    textBox1.Text = (double.Parse(textBox1.Text) + d).ToString();
                }
                else
                {
                    d = double.Parse(textBox1.Text);
                    textBox1.Text = (value + double.Parse(textBox1.Text)).ToString();
                }
            }

            else if (znak == "-")
            {
                if(count != 0)
                {
                    textBox1.Text = (double.Parse(textBox1.Text) - d).ToString();
                }
                else
                {
                    d = double.Parse(textBox1.Text);
                    textBox1.Text = (value - double.Parse(textBox1.Text)).ToString();
                }
            }

            else if (znak == "X")
            {
                if (count != 0)
                {
                    textBox1.Text = (double.Parse(textBox1.Text) * d).ToString();
                }
                else
                {
                    d = double.Parse(textBox1.Text);
                    textBox1.Text = (value * double.Parse(textBox1.Text)).ToString();
                }
            }

            else if (znak == "/")
            {
                if (count != 0 && textBox1.Text != "Ошибка")
                {
                    textBox1.Text = (double.Parse(textBox1.Text) / d).ToString();
                }
                else
                {
                    if(textBox1.Text == "Ошибка" || double.Parse(textBox1.Text) == 0)
                    {
                        textBox1.Text = "Ошибка";
                    }
                    else
                    {
                        d = double.Parse(textBox1.Text);
                        textBox1.Text = (value / double.Parse(textBox1.Text)).ToString();
                    }
                }
            }

            else if (znak == "mod")
            {
                textBox1.Text = (value % double.Parse(textBox1.Text)).ToString();
            }

            count++;
            textBox2.Text = "";
        }

    }
}
