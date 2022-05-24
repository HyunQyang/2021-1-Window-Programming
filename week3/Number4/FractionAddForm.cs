using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Number4
{
    public partial class FractionAddForm : Form
    {
        public FractionAddForm()
        {
            InitializeComponent();
        }

        private void btnRUN_Click(object sender, EventArgs e)
        {
            int numerator1, numerator2, numerator3 = 0;
            int denominator1, denominator2, denominator3 = 0;

            numerator1 = int.Parse(txtNumer1.Text);
            numerator2 = int.Parse(txtNumer2.Text);

            denominator1 = int.Parse(txtDenom1.Text);
            denominator2 = int.Parse(txtDenom2.Text);


            if (denominator1 == denominator2)
            {
                denominator3 = denominator1;
                numerator3 = numerator1 + numerator2;
            }
            else
            {
                //통분

                denominator3 = denominator1 * denominator2;
                numerator3 = (numerator2 * denominator1) + (numerator1 * denominator2);

                //약분 부분(유클리드 호제법)
                
                numerator3 = Gcd(denominator3,numerator3 );
                denominator3 = Gcd(numerator3, denominator3);
                
               

            }



            txtDenom3.Text = denominator3.ToString();
            txtNumer3.Text = numerator3.ToString();

          
        }

        public int Gcd(int a,int b)
        {
            if (b == 0) return a;
            else return Gcd(b, a % b);
        }
    }
}
