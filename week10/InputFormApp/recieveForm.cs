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
    public partial class recieveForm : Form
    {
        public recieveForm()
        {
            InitializeComponent();
        }
        public recieveForm(Info info)
        {
            InitializeComponent();
            txtName.Text = info.Name;
            txtAge.Text = info.Age.ToString();
            txtGender.Text = info.Gender;
            txtYear.Text = info.Year.ToString();
            txtMonth.Text = info.Month.ToString();
            txtDay.Text = info.Day.ToString();
            txtFavorite.Text = info.Favorite;
        }
        private void btnc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
