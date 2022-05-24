using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowFormApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            subForm sf = new subForm();
            sf.Show();
            sf.Text = txtTitle.Text;
            sf.Location = new Point(int.Parse(txtX.Text),int.Parse(txtY.Text));
            sf.Size = new Size(int.Parse(txtW.Text),int.Parse(txtH.Text));
            sf.Opacity = double.Parse(txtO.Text);
            if (rdoNone.Checked )
            {
                sf.FormBorderStyle = FormBorderStyle.None;
            }
            else if (rdoSingle.Checked)
            {
                sf.FormBorderStyle = FormBorderStyle.FixedSingle;
            }
            else
                sf.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            //sf.ShowDialog();// 원래 폼이 끝나야지만 다른것도 끝남.
        }
    }
}
