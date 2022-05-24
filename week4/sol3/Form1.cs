using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sol3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Contact con = null;
        
        private void btnPrint_Click(object sender, EventArgs e)
        {

            int age;
            string name, company, cell, tel, mail;

            name = txtN.Text;
            age = int.Parse(txtA.Text);
            company = txtC.Text;
            cell = txtCell.Text;
            tel = txtT.Text;
            mail = txtM.Text;

            con = new Contact(name, age, company, cell, tel, mail);


        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            int age;
            string name, company, cell, tel, mail;

            name = txtN.Text;
            age = int.Parse(txtA.Text);
            company = txtC.Text;
            cell = txtCell.Text;
            tel = txtT.Text;
            mail = txtM.Text;

            con = new Contact(name, age, company, cell, tel, mail);

            txtR.Text = con.ToString();
        }
    }
}
