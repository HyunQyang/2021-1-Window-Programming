using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointerIndexerWIndowApp
{
    public delegate void MyDelegate(int x, int y);
    class Point
    {
        int x, y;

        public Point(int x,int y)
        {
            this.x = x;
            this.y = y;
        }
        public Point()
        {
            this.x = 0;
            this.y = 0;
        }
        //프로퍼티
        public int X
        {
            get
            {
                return this.x;
            }
            set
            {
                this.x = value;
            }
        }
        public int Y
        {
            get
            {
                return this.y;
            }
            set
            {
                this.y = value;
            }
        }
        // 메소드
        public void MoveTo(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public void MoveBy(int moveX,int MoveY)
        {
            this.x += moveX;
            this.y += MoveY;
        }

        public override string ToString()
        {
            return "x:"+ x + ", y:"+y;
        }

        public static Point operator+ (Point p1,Point p2)
        {
            int x,y;
            x = p1.X + p2.X;
            y = p1.Y + p2.Y;
            Point pnew = new Point(x, y);

            return pnew;
        }
        public static Point operator -(Point p1, Point p2)
        {
            int x, y;
            x = p1.X - p2.X;
            y = p1.Y - p2.Y;
            Point pnew = new Point(x, y);

            return pnew;
        }
    }
}
