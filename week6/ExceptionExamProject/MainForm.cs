using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace asdfa
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            int inputValue1 = 0;
            int inputValue2 = 0;

            try//그 받아야 하는 인자값이 없을때 예외처리문.
            {
                inputValue1 = int.Parse(txtIn1.Text);
                inputValue2 = int.Parse(txtIn2.Text);
            }catch(FormatException fe)
            {

                lblInfo.Text = "입력형식이 잘못되었습니다. 다시 입력해 주세요:";
                return;
            }


            try// 2값이 0으로 들어운경우 예외처리
            {
                txtOutput.Text = (inputValue1 / inputValue2) + "";// .Tostring(); 가능.
            }catch(DivideByZeroException dbze)
            {
                txtOutput.Text = "Div/0";
                lblInfo.Text = dbze.Message;
            }
        }
    }
}
