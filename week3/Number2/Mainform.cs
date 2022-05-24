using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Number2
{
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            int num1, num2;

            num1 = int.Parse(txtX.Text);
            num2 = int.Parse(txtY.Text);


            if (num1 > num2)
            {
                lblResult.Text = num1 + ">  " + num2;
            }
            else if (num1 < num2)
            {
                lblResult.Text = num1 + "<  " + num2;
            }
            else
            {
                lblResult.Text = num1 + " = " + num2;
            }
        }
    }
}
