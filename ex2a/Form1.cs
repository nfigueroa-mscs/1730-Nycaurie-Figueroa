using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex2a
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int Subtotal = 5;
            decimal DiscountAmount = 0m;
            Decimal DiscountPercent = 5.0m;

            decimal Total = Subtotal * DiscountPercent;
            decimal discountPercent = Subtotal * DiscountAmount / 100;
            txtDiscountPercent.Text = DiscountPercent.ToString("0.00");
            txtDiscountAmount.Text = DiscountAmount.ToString("0.00");
            txtTotal.Text = Total.ToString("0.00");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
