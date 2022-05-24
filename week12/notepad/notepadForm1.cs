using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace notepad
{
    public partial class notepadForm1 : Form
    {
        public notepadForm1()
        {
            InitializeComponent();
        }

        private void mnuexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuNew_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult=
            MessageBox.Show("저장 하시겠습니까?", "메모장", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                txtEdit.Text = "";
            }
        }

        private void mnuFont_Click(object sender, EventArgs e)
        {
            if (fontDlg.ShowDialog() == DialogResult.OK)
            {
                txtEdit.Font = fontDlg.Font;
            }
        }

        private void mnuOpen_Click(object sender, EventArgs e)
        {
            if(openDlg.ShowDialog() == DialogResult.OK)
            {
                txtEdit.Text = "파일을 열었습니다.";
            }
        }

        private void mnuSave_Click(object sender, EventArgs e)
        {
            if(saveDlg.ShowDialog() == DialogResult.OK)
            {
                txtEdit.Text = "저장 했습니다.";
            }
        }

        private void mnuPrint_Click(object sender, EventArgs e)
        {
            if (printDlg.ShowDialog() == DialogResult.OK)
            {
                txtEdit.Text = "파일을 출력했습니다.";
            }
        }
    }
}
