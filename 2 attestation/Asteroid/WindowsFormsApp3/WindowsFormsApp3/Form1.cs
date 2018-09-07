using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
   
    public partial class Form1 : Form
    {


        Graphics g;
        Pen pen;
        public Form1()
        {
            InitializeComponent();
            g = CreateGraphics();
            pen = new Pen(Color.Black, 10);
        }

    

        private void Form1_Paint_1(object sender, PaintEventArgs e)
        {
            g.FillRectangle(new SolidBrush(Color.Blue), new Rectangle(0, 0, Width, Height));
            g.DrawRectangle(pen, 0, 0, Width - 17, Height - 40);
            g.FillEllipse(new SolidBrush(Color.White), 39, 69, 40, 40);
            g.FillEllipse(new SolidBrush(Color.White), 48, 439, 40, 40);
            g.FillEllipse(new SolidBrush(Color.White), 317, 37, 40, 40);
            g.FillEllipse(new SolidBrush(Color.White), 325, 416, 40, 40);
            g.FillEllipse(new SolidBrush(Color.White), 564, 78, 40, 40);
            g.FillEllipse(new SolidBrush(Color.White), 897, 176, 40, 40);
            g.FillEllipse(new SolidBrush(Color.White), 784, 275, 40, 40);
            g.FillEllipse(new SolidBrush(Color.White), 920, Height - 140, 40, 40);
            Point[] FirstStar =
            {
                new Point(153, 148),
                new Point(178, 118),
                new Point(128, 118)
            };
            Point[] FirstSt4r =
            {
                new Point(128, 138),
                new Point(178, 138),
                new Point(153, 108),
            };
            g.FillPolygon(new SolidBrush(Color.Red), FirstStar);
            g.FillPolygon(new SolidBrush(Color.Red), FirstSt4r);
            Point[] SecondStar =
            {
                new Point(150, 250),
                new Point(200, 250),
                new Point(175, 280),
            };
            Point[] SecondSt4r =
            {
                new Point(150, 270),
                new Point(175, 240),
                new Point(200, 270)
            };
            g.FillPolygon(new SolidBrush(Color.Red), SecondStar);
            g.FillPolygon(new SolidBrush(Color.Red), SecondSt4r);
            Point[] ThirdStar =
            {
                new Point(700, 120),
                new Point(750, 120),
                new Point(725, 150)
            };
            Point[] ThirdSt4r =
            {
                new Point(700, 140),
                new Point(750, 140),
                new Point(725, 110)
            };
            g.FillPolygon(new SolidBrush(Color.Red), ThirdStar);
            g.FillPolygon(new SolidBrush(Color.Red), ThirdSt4r);
            Point[] FourthStar =
            {
                new Point(670, 350),
                new Point(695, 380),
                new Point(720, 350)
            };
            Point[] FourthSt4r =
            {
                new Point(670, 370),
                new Point(695, 340),
                new Point(720, 370)
            };
            g.FillPolygon(new SolidBrush(Color.Red), FourthStar);
            g.FillPolygon(new SolidBrush(Color.Red), FourthSt4r);
            Point[] Body =
            {
                new Point(452, 310),
                new Point(452, 251),
                new Point(525, 215),
                new Point(593, 251),
                new Point(593, 310),
                new Point(525, 341),
            };
            g.FillPolygon(new SolidBrush(Color.Yellow), Body);
            Point[] Pushka =
            {
                new Point(525, 240),
                new Point(502, 265),
                new Point(547, 265)
            };
            g.FillPolygon(new SolidBrush(Color.DarkGreen), Pushka);
            g.FillRectangle(new SolidBrush(Color.DarkGreen), new Rectangle(518, 265, 15, 35));
            g.FillPolygon(new SolidBrush(Color.Green), new Point[3] { new Point(520, 155), new Point(523, 141), new Point(526, 155) });
            g.FillPolygon(new SolidBrush(Color.Green), new Point[3] { new Point(520, 161), new Point(523, 175), new Point(526, 161) });
            g.FillPolygon(new SolidBrush(Color.Green), new Point[3] { new Point(520, 155), new Point(517, 161), new Point(506, 158) });
            g.FillPolygon(new SolidBrush(Color.Green), new Point[3] { new Point(526, 155), new Point(526, 161), new Point(540, 158) });
            g.FillRectangle(new SolidBrush(Color.Green), new Rectangle(520, 155, 6, 6));
            g.FillRectangle(new SolidBrush(Color.White), 645, 17, 220, 30);
            g.DrawRectangle(new Pen(Color.Yellow, 3), 645, 17, 220, 30);
           // g.DrawString("Level: 1 Score: 200 Live: ***", new Font(FontFamily.GenericSansSerif, 12), new SolidBrush(Color.Black), 650, 20);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    }


       
