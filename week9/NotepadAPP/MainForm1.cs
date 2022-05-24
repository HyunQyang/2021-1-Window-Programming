using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotepadAPP
{
    public partial class MainForm1 : Form
    {
        public MainForm1()
        {
            InitializeComponent();
        }

        private void MainForm1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Notepad V.01");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainForm1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (txtMemo.Text != "")
            {
                if (MessageBox.Show("변경내역을 버리고 종료하시겠습니가.", "종료확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

       
    }
}
