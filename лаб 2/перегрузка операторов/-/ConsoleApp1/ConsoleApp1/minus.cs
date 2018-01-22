using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class minus
    {
        public int x, y;

        public minus(int x = 0, int y = 0)
        {
            this.x = x;
            this.y = y;
        }

        public static minus operator -(minus obj1, minus obj2)
        {
            minus dif = new minus();
            dif.x = obj1.x - obj2.x;
            dif.y = obj1.y - obj2.y;
            return dif;
        }

        public override string ToString()
        {
            return x + " " + y;
        }
    }
}
