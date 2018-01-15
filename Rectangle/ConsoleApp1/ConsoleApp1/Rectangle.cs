using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Rectangle
    {
        public int width;
        public int length;
        public int area;

        public Rectangle()
        {
            length = 10;
            width = 5;
        }

        public Rectangle(int length, int width)
        {
            this.width = width;
            this.length = length;
            findArea();
        }

        public void findArea()
        {
            area = width * length;
        }


        public override string ToString()
        {
            return "width = " + width + "\nlength = " + length + "\narea = " + area;
        }


    }
}
