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
        Bitmap bmp;
        Graphics bmpgraphics;

        int prevX, prevY, x, y;
        int font_size = 1;
        int initialX, initialY;
        int count = 0, width, height;
        int initialXtr, initialYtr, xtr, ytr;
        bool click;
        bool rezinka_click;
        bool instr_click;
        bool cleared;
        string color;
        string tool;
        //string[] arr = new string[] { "red", "black", "blue", "orange", "yellow", "green" };

        Pen pen = new Pen(Color.Black, 5);

        private void Clear_screen_Click(object sender, EventArgs e)
        {
            cleared = true;
            bmpgraphics.Clear(Color.White);
            pictureBox1.Refresh();
            cleared = false;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if(pictureBox1.Image != null)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Title = "Сохранить картинку как...";
                sfd.OverwritePrompt = true; //Если файл на этом пути существует, то программа спросит: Перезаписать ли файл?
                sfd.CheckPathExists = true; //Если путь не существует, то программа предупредит
                sfd.Filter = "Image Files(*.BMP)|*.BMP|Image Files(*.JPG)|*.JPG|Image Files(*.GIF)|*.GIF|Image Files(*.PNG)|*.PNG|All Files(*.*)|*.*";
                sfd.ShowHelp = true;

                if(sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        pictureBox1.Image.Save(sfd.FileName);
                    }
                    catch
                    {
                        MessageBox.Show("Невозможно сохранить изображение", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }

        private void Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "Image Files(*.BMP;*.GIF;*.JPG;*.PNG)|*.BMP;*.GIF;*.JPG;*.PNG|All Files(*.*)|*.*";

            if(ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox1.Image = new Bitmap(ofd.FileName);
                    //bmp = (Bitmap)Image.FromFile(ofd.FileName, true);
                }
                catch
                {
                    MessageBox.Show("Невозможно открыть изображение", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = bmp;
            bmpgraphics = Graphics.FromImage(bmp);
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            click = false;
            if(tool == "rectangle")
            {
                if (count != 2)
                {
                    //bmpgraphics.DrawRectangle(new Pen(Color.Red), initialX, initialY, x - initialX, y - initialY);
                    pictureBox1.Refresh();
                    width = x - initialX;
                    height = y - initialY;
                }

                if (count == 2)
                {
                    bmpgraphics.DrawRectangle(pen, initialX + (x - initialX), y + (y - initialY), width, height);
                    pictureBox1.Refresh();
                    count = 0;
                }
            }

            if (tool == "circle")
            {
                if (count != 2)
                {
                    //bmpgraphics.DrawRectangle(new Pen(Color.Red), initialX, initialY, x - initialX, y - initialY);
                    pictureBox1.Refresh();
                    width = x - initialX;
                    height = y - initialY;
                }

                if (count == 2)
                {
                    bmpgraphics.DrawEllipse(pen, initialX + (x - initialX), y + (y - initialY), width, height);
                    pictureBox1.Refresh();
                    count = 0;
                }
            }

            if (tool == "triangle")
            {
                if (count != 2)
                {
                    //bmpgraphics.DrawRectangle(new Pen(Color.Red), initialX, initialY, x - initialX, y - initialY);
                    pictureBox1.Refresh();

                    initialXtr = initialX;
                    initialYtr = initialY;
                    xtr = x;
                    ytr = y;
                }

                if (count == 2)
                {
                    bmpgraphics.DrawLine(pen, x, y, x + (xtr - initialXtr), y + (ytr - initialYtr));
                    bmpgraphics.DrawLine(pen, x, y, x - (xtr - initialXtr), y + (ytr - initialYtr));
                    bmpgraphics.DrawLine(pen, x + (xtr - initialXtr), y + (ytr - initialYtr), x - (xtr - initialXtr), y + (ytr - initialYtr));
                    pictureBox1.Refresh();
                    count = 0;              
                }
            }

            if (tool == "square")
            {
                if (count != 2)
                {
                    //bmpgraphics.DrawRectangle(new Pen(Color.Red), initialX, initialY, x - initialX, y - initialY);
                    pictureBox1.Refresh();
                    width = x - initialX;
                    height = width;
                }

                if (count == 2)
                {
                    bmpgraphics.DrawRectangle(pen, initialX + (x - initialX), y + (y - initialY), width, height);
                    pictureBox1.Refresh();
                    count = 0;
                }

            }

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            click = true;
            initialX = e.X;
            initialY = e.Y;
            if(tool != "no")
            {
                count++;
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (tool == "rectangle" && cleared == false)
            {
                //e.Graphics.Clear(Color.White);
                if(count != 2)
                {
                    e.Graphics.DrawRectangle(new Pen(Color.Blue, font_size), initialX, initialY, x - initialX, y - initialY);
                }

                if (count == 2)
                {
                    e.Graphics.DrawRectangle(pen, initialX + (x - initialX), y + (y - initialY), width, height);
                }
            }

            if (tool == "circle" && cleared == false)
            {
                //e.Graphics.Clear(Color.White);
                if (count != 2)
                {
                    e.Graphics.DrawEllipse(new Pen(Color.Blue, font_size), initialX, initialY, x - initialX, y - initialY);
                }
                
                if (count == 2)
                {
                    e.Graphics.DrawEllipse(pen, initialX + (x - initialX), y + (y - initialY), width, height);
                }
            }

            if (tool == "triangle" && cleared == false)
            {
                //e.Graphics.Clear(Color.White);
                if (count != 2)
                {
     
                    e.Graphics.DrawLine(new Pen(Color.Blue), initialX, initialY, x, y);
                    e.Graphics.DrawLine(new Pen(Color.Blue), initialX, initialY, initialX - (x - initialX), y);
                    e.Graphics.DrawLine(new Pen(Color.Blue), x, y, initialX - (x - initialX), y);
                }

                if (count == 2)
                {
                    // e.Graphics.DrawEllipse(pen, initialX + (x - initialX), y + (y - initialY), width, height);

                    e.Graphics.DrawLine(pen, x, y, x + (xtr - initialXtr), y + (ytr - initialYtr));
                    e.Graphics.DrawLine(pen, x, y, x - (xtr - initialXtr), y + (ytr - initialYtr));
                    e.Graphics.DrawLine(pen, x + (xtr - initialXtr), y + (ytr - initialYtr), x - (xtr - initialXtr), y + (ytr - initialYtr));
                }
            }

            if (tool == "square" && cleared == false)
            {
                //e.Graphics.Clear(Color.White);
                if (count != 2)
                {
                    e.Graphics.DrawRectangle(new Pen(Color.Blue, font_size), initialX, initialY, x - initialX, x - initialX);
                }

                if (count == 2)
                {
                    e.Graphics.DrawRectangle(pen, initialX + (x - initialX), y + (y - initialY), width, height);
                }
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            prevX = x;
            prevY = y;
            x = e.X;
            y = e.Y;

            if (color == "red")
            {
                pen = new Pen(Color.Red, font_size);
            }
            else if (color == "black")
            {
                pen = new Pen(Color.Black, font_size);
            }
            else if (color == "blue")
            {
                pen = new Pen(Color.Blue, font_size);
            }
            else if (color == "orange")
            {
                pen = new Pen(Color.Orange, font_size);
            }
            else if (color == "yellow")
            {
                pen = new Pen(Color.Yellow, font_size);
            }
            else if (color == "green")
            {
                pen = new Pen(Color.Green, font_size);
            }

            if (click)
            {
                if(instr_click == true)
                {
                    bmpgraphics.DrawLine(pen, x, y, prevX, prevY);
                }
                pictureBox1.Refresh();
            }

            if (click)
            {
                if (rezinka_click == true)
                {
                    bmpgraphics.DrawRectangle(new Pen(Color.White, font_size), x, y, 1, 1);
                }             
            }
          
        }

        private void Color_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if(btn == Red)
            {
                color = "red";
            }
            else if(btn == Black)
            {
                color = "black";
            }
            else if (btn == Blue)
            {
                color = "blue";
            }
            else if (btn == Orange)
            {
                color = "orange";
            }
            else if (btn == Yellow)
            {
                color = "yellow";
            }
            else if (btn == Green)
            {
                color = "green";
            }
            else if (btn == rezinka)
            {
                tool = "no";
                rezinka_click = true;
                instr_click = false;
            }
        }

        private void size_Click(object sender, EventArgs e)
        {
            Button btn_size = (Button)sender;

            if(btn_size == size1)
            {
                font_size = 5;
            }

            else if (btn_size == size2)
            {
                font_size = 12;
            }

            else if (btn_size == size3)
            {
                font_size = 19;
            }
        }

        private void Pencil_Click(object sender, EventArgs e)
        {
            instr_click = true;
            rezinka_click = false;
            tool = "no";
        }

        private void Figure_Click(object sender, EventArgs e)
        {
            Button btn_figure = (Button)sender;
            if (btn_figure == Rectangle)
            {
                tool = "rectangle";
                instr_click = false;
                rezinka_click = false;
            }

            if (btn_figure == Circle)
            {
                tool = "circle";
                instr_click = false;
                rezinka_click = false;
            }

            if (btn_figure == Triangle)
            {
                tool = "triangle";
                instr_click = false;
                rezinka_click = false;
            }

            if (btn_figure == Square)
            {
                tool = "square";
                instr_click = false;
                rezinka_click = false;
            }
        }


    }
}
