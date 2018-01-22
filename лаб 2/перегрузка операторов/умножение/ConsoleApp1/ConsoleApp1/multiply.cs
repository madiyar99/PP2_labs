using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class multiply
    {
        public int x, y;
        public multiply(int x = 0, int y = 0)
        {
            this.x = x;
            this.y = y;
        }

        public static multiply operator *(multiply obj1, multiply obj2)
        {
            multiply ml = new multiply();
            ml.x = obj1.x * obj2.x;
            ml.y = obj1.y * obj2.y;
            return ml;
        }

        public override string ToString()
        {
            return x + " " + y;
        }

    }
}
