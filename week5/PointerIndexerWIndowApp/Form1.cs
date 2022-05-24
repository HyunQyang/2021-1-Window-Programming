using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointerIndexerWIndowApp
{
    public partial class Form1 : Form
    {
        Point p = null;
        PointArray par = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMake_Click(object sender, EventArgs e)
        {
            int x, y;
            x = Convert.ToInt32(txtX.Text);
            y = int.Parse(txtY.Text);

            p.MoveTo(x, y);

            txtR.Text = p.ToString();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            int x, y;

            x = Convert.ToInt32(txtX.Text);
            y = Convert.ToInt32(txtY.Text);

            p = new Point(x, y);
            par = new PointArray();
            par[0] = p;
            txtR.Text = par[0].ToString();
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            MyDelegate myd = new MyDelegate(p.MoveBy);
            myd(int.Parse(txtX.Text), int.Parse(txtY.Text));
            txtR.Text = p.ToString();
            myd = new MyDelegate(p.MoveTo);
            myd(int.Parse(txtX.Text), int.Parse(txtY.Text));
            myd += new MyDelegate(p.MoveBy);
            myd -= new MyDelegate(p.MoveTo);
        }
    }
}
