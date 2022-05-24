using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Number1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*  String temp;
              temp = txtX.Text;
              txtX.Text = txtY.Text;
              txtY.Text = temp;
            */
            int x, y;
            x = int.Parse(txtX.Text);
            y = int.Parse(txtY.Text);
            unsafe
            {
                swap(&x, &y);
            }
                txtX.Text = x + "";
            txtY.Text = y.ToString();
        }
        private unsafe void swap(int *p1, int* p2)
        {
            int temp;
            temp = *p1;
            *p1 = *p2;
            *p2 = temp;
        }
    }
}
