using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IndexExceptionExam
{
    public partial class ArrayForm : Form
    {
        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        public ArrayForm()
        {
            InitializeComponent();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                int index = int.Parse(txtIndex.Text);
                textBox1.Text = this.arr[index].ToString();

            }
            catch (IndexOutOfRangeException ir)//값이 범위를 넘어갈 경우 예외처리
            {
                textBox1.Text = "배열의 범위를 벗어났습니다.";
            }
            catch(FormatException fe)//정수형이 입력되지 않은 경우 예외처리.
            {
                textBox1.Text = " 정수형 인덱스가 입력되지 않았습니다.";
            }
        }

        private void btnPrintAll_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            for(int i=0; i<arr.Length; i++)
            {
                textBox1.Text += arr+",";
            }
            
        }
    }
}
