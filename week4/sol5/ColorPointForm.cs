using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sol5
{
    public partial class Form1 : Form
    {
        Colorable3DPoint c3p = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            int x;
            int y;
            int z;
            string color;

            x = int.Parse(txtX.Text);
            y = Convert.ToInt32(txtY.Text);
            z = Convert.ToInt32(txtZ.Text);
            color = txtColor.Text;

            c3p = new Colorable3DPoint(x, y, z, color);

            print3DPoint();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            int x, y, z;
            string color;

            x = int.Parse(txtX.Text);
            y = Convert.ToInt32(txtY.Text);
            z = Convert.ToInt32(txtZ.Text);
            color = txtColor.Text;

            c3p.MoveTo(x, y, z);

            print3DPoint();
            
        }
        private void print3DPoint()
        {
            txtXPrint.Text = Convert.ToString(c3p.GetX());
            txtYPint.Text = Convert.ToString(c3p.GetY());
            txtZPrint.Text = c3p.GetZ().ToString();
            txtColoPrint.Text = c3p.Getcolor();

        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            int x, y, z;
            string color;

            x = int.Parse(txtX.Text);
            y = Convert.ToInt32(txtY.Text);
            z = Convert.ToInt32(txtZ.Text);
            color = txtColor.Text;

            c3p.MoveBy(x, y, z);

            print3DPoint();
        }

        private void btnChangeX_Click(object sender, EventArgs e)
        {
            int x;
            x = int.Parse(txtX.Text);
            c3p.SetX(x);
            print3DPoint();
        }

        private void btnChangeY_Click(object sender, EventArgs e)
        {
            int y;
            y = int.Parse(txtY.Text);
            c3p.SetY(y);
            print3DPoint();
        }

        private void btnChangeZ_Click(object sender, EventArgs e)
        {
            int z;
            z = int.Parse(txtZ.Text);
            c3p.SetZ(z);
            print3DPoint();
        }

        private void btnChangeColor_Click(object sender, EventArgs e)
        {
            c3p.Setcolor(txtColor.Text);
            print3DPoint();
        }
    }
}
