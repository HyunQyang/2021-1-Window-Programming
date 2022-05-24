using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListViewControl
{
    public partial class LVForm1 : Form
    {
        public LVForm1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ListViewItem.ListViewSubItem sub1 = new ListViewItem.ListViewSubItem();
            ListViewItem.ListViewSubItem sub2 = new ListViewItem.ListViewSubItem();
            ListViewItem.ListViewSubItem sub3 = new ListViewItem.ListViewSubItem();
            ListViewItem.ListViewSubItem sub4 = new ListViewItem.ListViewSubItem();
            //sub1.Text = txtS.Text;
            sub1.Text = txtName.Text;
            sub2.Text = txtAdress.Text;
            sub3.Text = txtTel.Text;
            sub4.Text = txtMajor.Text;

            ListViewItem lvitem = new ListViewItem();
            lvitem.Text = txtS.Text;
            lvitem.SubItems.Add(sub1);
            lvitem.SubItems.Add(sub2);
            lvitem.SubItems.Add(sub3);
            lvitem.SubItems.Add(sub4);

            listView1.Items.Add(lvitem);


            /*
            listView1.Items.Add(txtS.Text);
            listView1.Items[0].SubItems.Add(txtName.Text);
            listView1.Items[0].SubItems.Add(txtAdress.Text);
            listView1.Items[0].SubItems.Add(txtTel.Text);
            listView1.Items[0].SubItems.Add(txtMajor.Text);
            */
        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count != 0)
            {
                listView1.SelectedItems[0].Remove();
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count != 0)
            {
             //   txtS.Text = listView1.SelectedItems[0].Text;
                txtS.Text = listView1.SelectedItems[0].SubItems[0].Text;
                txtName.Text = listView1.SelectedItems[0].SubItems[1].Text;
                txtAdress.Text = listView1.SelectedItems[0].SubItems[2].Text;
                txtTel.Text = listView1.SelectedItems[0].SubItems[3].Text;
                txtMajor.Text = listView1.SelectedItems[0].SubItems[4].Text;
            }
        }

        private void dmView_SelectedItemChanged(object sender, EventArgs e)
        {
            if(dmView.Text == "Detail") 
                listView1.View = View.Details;
                else if(dmView.Text == "Largeicon")
                {
                    listView1.View = View.LargeIcon;
                }
                else if (dmView.Text == "Smallicon")
                {
                    listView1.View = View.SmallIcon;
                }
            
        }
    }
}
