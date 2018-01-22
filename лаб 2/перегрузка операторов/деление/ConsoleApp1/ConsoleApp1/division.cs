using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class division
    {
        public float x, y;

        public division(float x = 0, float y = 0)
        {
            this.x = x;
            this.y = y;
        }

        public static division operator /(division obj1, division obj2)
        {
            division div = new division();
            div.x = obj1.x / obj2.x;
            div.y = obj1.y / obj2.y;
            return div;   
        }

        public override string ToString()
        {
            return x + " " + y;
        }
    }
}
