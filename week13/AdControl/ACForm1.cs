using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdControl
{
    public partial class ACForm1 : Form
    {
        public ACForm1()
        {
            InitializeComponent();
        }

        private void nupdown_ValueChanged(object sender, EventArgs e)
        {
            tbValue.Value = (int)nupdown.Value;
            progress.Maximum = (int)nupdown.Value;
        }

        private void tbValue_Scroll(object sender, EventArgs e)
        {
            nupdown.Value = tbValue.Value;
            progress.Maximum = tbValue.Value;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(progress.Value < progress.Maximum)
                progress.Value += 10;
            else if(progress.Value == progress.Maximum){
                MessageBox.Show("끝입니다 헤헤헤");
            }

        }
    }
}
