using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formeventProject
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            /*   this.Text = "load 이벤트 테스트";
               this.Width = 700;
               this.Height = 1200; 크기와 그 폼이름 이거 정해주는거
            */
            string forminfo = "EvetForm 의 넓이:" + this.Width + ", 높이:" + this.Height;
            MessageBox.Show(forminfo);

         }

        

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            lblOut.Text = "마우스 좌표: X:" + e.X + " Y:" + e.Y;
        }

        private void MainForm_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show(e.Button.ToString()); 
        }

        private void MainForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show(e.KeyChar.ToString());
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("Keycode:" + e.KeyCode, "KeyDown Event");
        }
    }
}
