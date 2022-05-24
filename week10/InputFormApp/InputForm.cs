using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InputFormApp
{
    public partial class InputForm : Form
    {
        public InputForm()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            string name;
            int age;
            string gender;
            int year;
            int month;
            int day;
            string favorite = "";

            name = txtName.Text;
            age = int.Parse(txtAge.Text);

            if (rdoM.Checked)
                gender = "man";
            else
                gender = "woman";

            year = int.Parse(txtYear.Text);
            month = int.Parse(txtMonth.Text);
            day = int.Parse(txtDay.Text);


            if (chkF.Checked)
                favorite += "fishing"+Environment.NewLine;
            if (chkG.Checked)
                favorite += "gaming" + Environment.NewLine;
            if (chkS.Checked)
                favorite += "Singing" + Environment.NewLine;

            Info info = new Info(name, age, gender, year, month, day, favorite);
            recieveForm rf = new recieveForm(info);//객체를 기반한 전달법
            //  recieveForm rf = new recieveForm(name,age,gender,year,month,day,favorite);

            // rf.Show();
        }
    }
}
