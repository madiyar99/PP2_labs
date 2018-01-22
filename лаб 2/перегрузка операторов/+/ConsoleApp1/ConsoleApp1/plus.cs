using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class plus
    {
        int x, y;

        public plus(int x = 0, int y = 0)
        {
            this.x = x;
            this.y = y;
        }
        
        public static plus operator +(plus obj1, plus obj2)
        {
            plus sum = new plus();
            sum.x = obj1.x + obj2.x;
            sum.y = obj1.y + obj2.y;
            return sum;
        }

        public override string ToString()
        {
            return x + " " + y;
        }
    }
}
