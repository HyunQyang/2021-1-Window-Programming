using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sol4
{
    public class Point<DataType>
    {
        private DataType x;
        private DataType y;

        public Point(DataType x,DataType y)
        {
            this.x = x;
            this.y = y;
        }

        public void SetX()
        {
            this.x = x;
        }
        public void SetY()
        {
            this.y = y;
        }

        public DataType GetX()
        {
            return x;
        }

        public DataType GetY()
        {
            return y;
        }

        public void MoveTo(DataType movex,DataType movey)
        {
            
        }

        public override string ToString()
        {
            return "x:" + x + " , y:" + y;
        }
    }
}
