using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace ThreadExamFormApp
{
    public partial class ThreadForm : Form
    {
        Thread t1;
        Thread t2;
        public ThreadForm()
        {
            InitializeComponent();
        }

        private void btnRUn_Click(object sender, EventArgs e)
        {
            //스레드 생성과 실행
            ThreadStart ts1 = new ThreadStart(print_increase);//델리게이트 생성,increase 위임
            ThreadStart ts2 = new ThreadStart(print_increase);//델리게이트 생성,decrease 위임
             t1 = new Thread(ts1);
             t2 = new Thread(ts2);

            t1.Start();
            t2.Start();
        }
        private void print_increase()
        {
            int i = 0;
            while(true)
            {
                txtPrintView1.Text += i + Environment.NewLine;
                i++;
                Thread.Sleep(1000);
            }
        }
        private void print_decrease()
        {
            int i = 100000;
            while (true)
            {
                txtPrintView2.Text += i + Environment.NewLine;
                i--;
                Thread.Sleep(10);
            }
        }

        private void btnStop_click(object sender, EventArgs e)
        {
            t1.Suspend();
            t2.Suspend();
        }

        private void ThreadForm_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
        }
    }
}
