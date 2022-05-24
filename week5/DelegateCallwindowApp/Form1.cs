using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelegateCallwindowApp
{
    public partial class Form1 : Form
    {
        Calc1 c = null;
        Calc cal = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResult.Text = null;
        }

        private void btnP_Click(object sender, EventArgs e)
        {
            c = new Calc1(int.Parse(txtX.Text), int.Parse(txtY.Text));
            cal += new Calc(c.Add);
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            c= new Calc1(int.Parse(txtX.Text), int.Parse(txtY.Text));
            cal += new Calc(c.Minus);
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            c = new Calc1(int.Parse(txtX.Text), int.Parse(txtY.Text));
            cal += new Calc(c.Mul);
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            c = new Calc1(int.Parse(txtX.Text), int.Parse(txtY.Text));
            cal += new Calc(c.Div);
        }
    }
}
