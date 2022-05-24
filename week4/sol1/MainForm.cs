using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sol1
{
    public partial class MainForm : Form
    {
        Fraction fr = null;

        private int r1;
        private int r2;
        public MainForm()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            int x1, x2, y1, y2;

            x1 = int.Parse(txtX1.Text);
            x2 = int.Parse(txtX2.Text);

            y1 = int.Parse(txtY1.Text);
            y2 = int.Parse(txtY2.Text);

            fr = new Fraction(x1, x2, y1, y2);

            r1 = (x1 * y2) + (x2 * y1);
            r2 = y1 * y2;

            txtR1.Text = r1 + "";
            txtR2.Text = r2 + "";

        }

    }
}
