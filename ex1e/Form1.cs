using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex1e
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            txtAverage.Text = (
                (Convert.ToDecimal(txtTest1.Text) 
                + Convert.ToDecimal(txtTest2.Text) 
                + Convert.ToDecimal(txtTest3.Text)) 
                / 3m).ToString("0.00");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAverage.Text = "0";
            txtTest1.Text = "0";
            txtTest2.Text = "0";
            txtTest3.Text = "0";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
