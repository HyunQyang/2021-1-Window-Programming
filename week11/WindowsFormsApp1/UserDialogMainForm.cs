using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace WindowsFormsApp1
{
    public partial class UserDialogMainForm : Form
    {
        public UserDialogMainForm()
        {
            InitializeComponent();
        }

        private void btnUserDialog1_Click(object sender, EventArgs e)
        {
            UserDialog1 ud1 = new UserDialog1(txtparam.Text);
            ud1.Show();
        }

        private void btnUserDialog2_Click(object sender, EventArgs e)
        {
            UserDialog2 ud2 = new UserDialog2();
            ud2.ShowDialog();
            txtparam.Text = ud2.Parameter;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("정보를 확인시켜주기 위한 대화 상자","기본 대화상자",0,MessageBoxIcon.Information);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            MessageBox.Show("OK,Cancel 대화상자", "사용자로 부터 OK Cancel을 확인 하기 위한 대화상자", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yes,No,Cancel 대화상자", "사용자로 부터 Yes No Cancel을 확인 하기 위한 대화상자", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
        }

        private void btnAbort_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Abort,retry,Ignore 대화상자", "사용자로 부터 Abort,retry,Ignore을 결정 하기 위한 대화상자", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);

        }

        private void btncolor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            textBox1.BackColor = colorDialog1.Color;
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            textBox1.Font = fontDialog1.Font;
            textBox1.ForeColor = fontDialog1.Color;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = @"C:\";
            //openFileDialog1.Filter = "텍스트 파일(*.txt)|*.txt|모든 파일(*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.Multiselect = true;
            openFileDialog1.ShowDialog();
            foreach (string strTmp in openFileDialog1.FileNames)
            {
                textBox1.Text += strTmp;
                textBox1.Text += "\r\n";
            }
            }

        private void btnFolder_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = @"C:W";
            folderBrowserDialog1.ShowDialog();
            string selected = folderBrowserDialog1.SelectedPath;
            textBox1.Text = selected;

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrinterSettings printer = new PrinterSettings();
            PrintDocument pd = new PrintDocument();
            printDialog1.PrinterSettings = printer;
            printDialog1.Document = pd;
            // PrintPage 이벤트는 Print() 메소드가 호출되기 직전 발생
            pd.PrintPage += new PrintPageEventHandler(this.pd_PrintPage);
            DialogResult result = printDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                textBox1.Text = printer.ToString();
            }
        }
        private void pd_PrintPage(object sender, PrintPageEventArgs e)
        {
            string text = textBox1.Text;
            Font printFont = new Font("Arial", 10, FontStyle.Regular);
            e.Graphics.DrawString(text, printFont, Brushes.Black, 10, 10);
        }

    }
}

