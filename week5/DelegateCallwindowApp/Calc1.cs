using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateCallwindowApp
{
    delegate int Calc(int x, int y);
    class Calc1
    {
        int x, y;

        public Calc1(int x, int y) {

            this.x = x;
            this.y = y;
        }
        public String Add(int x, int y)
        {
            return x + "+" + y + "=" + x + y+"\n";
        }
        public String Minus(int x, int y)
        {
            return x + "-" + y + "=" + (x - y) + "\n";
        }
        public String Mul(int x, int y)
        {
            return x + "*" + y + "=" + (x * y) + "\n";
        }
        public String Div(int x, int y)
        {
            return x + "*" + y + "=" + (x / y) + "\n";
        }
    }
}
