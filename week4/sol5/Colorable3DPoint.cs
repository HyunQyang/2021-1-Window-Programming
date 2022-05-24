using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sol5
{
    class Colorable3DPoint : Point
    {
        private int z;
        private string color;

        public Colorable3DPoint(int x,int y,int z, string color) : base(x, y)
        {
            this.z = z;
            this.color = color;
        }
       public void SetZ()
        {
            this.z = z;
        } 
        public void Setcolor()
        {
            this.color = color;
        }

        public int GetZ()
        {
            return z;
        }
        public string Getcolor()
        {
            return this.color;
        }
        public void MoveTo(int x,int y, int z)
        {
            MoveTo(x, y);
            this.z = z;
        }
        public void MoveBy(int x,int y, int z)
        {
            MoveBy(x, y);
            this.z = z;
        }
        public override string ToString()
        {
            return base.ToString() + ", z:" + this.z + ", color : " + this.color;
        }
    }
}
