using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookInfoWIndowApp
{
    public partial class Form1 : Form
    {
        EBook eb = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string title,author,ISBN,publisher;
            int page, price;

            title = txtTilte.Text;
            author = txtAuthor.Text;
            page = int.Parse(txtPages.Text);
            ISBN = txtISBM.Text;
            publisher = txtPublisher.Text;
            price = int.Parse(txtPrice.Text);
           
            
        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            eb.DiscountPrice(int.Parse(txtDiscount.Text));
        }

        private void bttnOfs_Click(object sender, EventArgs e)
        {
            eb.StorageInWareHouse();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            txtResult.Text = eb.ToString();

        }
    }
}
