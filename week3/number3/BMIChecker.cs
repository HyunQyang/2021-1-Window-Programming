using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace number3
{
    public partial class BMIChecker : Form
    {
        public BMIChecker()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            double weight, height;
            double standard, bmi;
            string obesity;

            weight = double.Parse(txtW.Text);
            height = double.Parse(txtH.Text);

            standard = (height - 100) * 0.9;
            bmi = (weight - standard) / standard * 100;

            if (bmi < 20)
            {
                obesity = "정상";
            }else if(bmi < 30)
            {
                obesity = "경도비만";
            }
            else if (bmi < 50)
            {
                obesity = "중도비만";
            }
            else
            {
                obesity = "고도비만";
            }
            txtSW.Text = standard.ToString();
            txtBMI.Text = bmi.ToString();
            txtObesity.Text = obesity;
        }
    }
}
