using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComplexCalcWIndowApps
{
    public partial class Form1 : Form
    {
        Complex c = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Complex c1 = new Complex(double.Parse(txtX1.Text), double.Parse(txtX2.Text));
            Complex c2 = new Complex(double.Parse(txtY1.Text), double.Parse(txtY2.Text));
            Complex c3 = c1 + c2;

            txtX3.Text = c3.Real.ToString();
            txtY3.Text = c3.Imagianry.ToString();
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            Complex c1 = new Complex(double.Parse(txtX1.Text), double.Parse(txtX2.Text));
            Complex c2 = new Complex(double.Parse(txtY1.Text), double.Parse(txtY2.Text));
            Complex c3 = c1 * c2;

            txtX3.Text = c3.Real.ToString();
            txtY3.Text = c3.Imagianry.ToString();

        }
    }
}
