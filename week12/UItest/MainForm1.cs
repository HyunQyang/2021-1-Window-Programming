using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UItest
{
    public partial class MainForm1 : Form
    {
        public MainForm1()
        {
            InitializeComponent();
        }


        private void mnuSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("파일저장 메뉴 선택", "ToolStripMenuItem_Click");
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("파일열기 메뉴 선택", "ToolStripMenuItem_Click");
        }

        private void mnuLeft_Click(object sender, EventArgs e)
        {
            mnuLeft.Checked = true;
            mnuRight.Checked = false;
            mnuCenter.Checked = false;
            txtEdit.TextAlign = HorizontalAlignment.Left;
        }

        private void mnuCenter_Click(object sender, EventArgs e)
        {
            mnuLeft.Checked = false;
            mnuRight.Checked = true;
            mnuCenter.Checked = false;
            txtEdit.TextAlign = HorizontalAlignment.Center;
        }

        private void mnuRight_Click(object sender, EventArgs e)
        {
            mnuLeft.Checked = false;
            mnuRight.Checked = false;
            mnuCenter.Checked = true;
            txtEdit.TextAlign = HorizontalAlignment.Right;
        }

        private void mnuCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtEdit.Text);
        }

        private void mnuPaste_Click(object sender, EventArgs e)
        {
            txtEdit.Text = Clipboard.GetText();
        }

        private void toolStripStatusLabel1_MouseMove(object sender, MouseEventArgs e)
        {
            statusStrip1.Items[0].Text = e.X + " " + e.Y;
        }

       
        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            StatusStrip statusStrip1 = (StatusStrip)sender;
            MessageBox.Show("파일열기 메뉴 선택", "ToolStripMenuItem_Click");
        }

        private void txtEdit_MouseMove(object sender, MouseEventArgs e)
        {
            statusStrip1.Items[0].Text = e.X + " " + e.Y;
        }
    }
}
