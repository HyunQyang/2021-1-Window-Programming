using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VolumeCalc
{
    public partial class frmVolumeCalc : Form
    {
        public frmVolumeCalc()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a;
            int b = 0;
            a = int.Parse(txtInt.Text);

            switch (a)
            {
                case 1: 
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12: b = 31; break;

                case 2:
                case 4:
                case 6:
                case 9:
                case 11: b = 30; break;
     
            }

            Fire.Text = b + "";

        }

        private void frmVolumeCalc_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Fire_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
