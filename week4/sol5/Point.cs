using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sol5
{
    class Point
    {
        private int x, y;

        public Point(int x, int y)//셍성자
        {
            this.x = x;
            this.y = y;
        }
        public void SetX(int x)
        {
            this.x = x;
        }
        public void SetY(int y)
        {
            this.y = y;
        }
        public int GetX()
        {
            return x;
        }
        public int GetY()
        {
            return y;
        }

        public void MoveTo(int x,int y)
        {
            this.x = x;
            this.y = y;
        }

        public void MoveBy(int moveX, int moveY)
        {
            this.x = this.x + moveX;
            this.y = y + moveY;
        }

        public override string ToString()
        {
            return "x: " + this.x + ", y:  " + this.y;
        }




    }
}
