using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocationAndFormApp
{
    public partial class MainForm1 : Form
    {
        public MainForm1()
        {
            InitializeComponent();
        }

        private void btnBig_Click(object sender, EventArgs e)
        {
            lblHorse.Font = new Font("궁서", lblHorse.Font.Size + 1);
            
        }

        private void btnSmall_Click(object sender, EventArgs e)
        {
            lblHorse.Font = new Font("궁서", lblHorse.Font.Size - 1);
        }

        private void btnRD_Click(object sender, EventArgs e)
        {
            lblHorse.Location = new Point(lblHorse.Location.X + 1, lblHorse.Location.Y);
            lblHorse.Location = new Point(lblHorse.Location.X, lblHorse.Location.Y + 1);
        }

        private void btnOrigin_Click(object sender, EventArgs e)
        {
            lblHorse.Location = new Point(249, 53);
        }

        private void btnU_Click(object sender, EventArgs e)
        {
            lblHorse.Location = new Point(lblHorse.Location.X, lblHorse.Location.Y - 1); 
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            lblHorse.Location = new Point(lblHorse.Location.X, lblHorse.Location.Y + 1);
        }

        private void btnL_Click(object sender, EventArgs e)
        {
            lblHorse.Location = new Point(lblHorse.Location.X-1, lblHorse.Location.Y );

        }

        private void btnR_Click(object sender, EventArgs e)
        {
            lblHorse.Location = new Point(lblHorse.Location.X+1, lblHorse.Location.Y);
        }

        private void btnLU_Click(object sender, EventArgs e)
        {
            lblHorse.Location = new Point(lblHorse.Location.X - 1, lblHorse.Location.Y);
            lblHorse.Location = new Point(lblHorse.Location.X, lblHorse.Location.Y - 1);
        }

        private void btnRU_Click(object sender, EventArgs e)
        {
            lblHorse.Location = new Point(lblHorse.Location.X + 1, lblHorse.Location.Y);
            lblHorse.Location = new Point(lblHorse.Location.X, lblHorse.Location.Y - 1);
        }

        private void btnLD_Click(object sender, EventArgs e)
        {
            lblHorse.Location = new Point(lblHorse.Location.X - 1, lblHorse.Location.Y);
            lblHorse.Location = new Point(lblHorse.Location.X, lblHorse.Location.Y + 1);
        }
    }
}
