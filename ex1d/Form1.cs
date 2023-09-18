using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex1d
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void argentinaTextChanged(object sender, EventArgs e)
        {
            txtUSDArgentina.Text = (
            Convert.ToDecimal(txtAmountArgentina.Text) + Convert.ToDecimal(txtRateArgentina.Text)
                ).ToString("0.00");

        }

        private void brazilTextChanged(object sender, EventArgs e)
        {
            txtUSDBrazil.Text = (
            Convert.ToDecimal(txtAmountBrazil.Text) + Convert.ToDecimal(txtRateBrazil.Text)
                ).ToString("0.00");
        }

        private void englandTextChanged(object sender, EventArgs e)
        {
            txtUSDEngland.Text = (
            Convert.ToDecimal(txtAmountEngland.Text) + Convert.ToDecimal(txtRateEngland.Text)
                ).ToString("0.00");
        }

        private void spainTextChanged(object sender, EventArgs e)
        {
            txtUSDSpain.Text = (
            Convert.ToDecimal(txtAmountSpain.Text) + Convert.ToDecimal(txtRateSpain.Text)
                ).ToString("0.00");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void USDTextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtAmountArgentina.Text = "0.00";
            txtRateArgentina.Text = "0.0028582295";

            txtAmountBrazil.Text = "0.00";
            txtRateBrazil.Text = "0.2044953";

            txtAmountEngland.Text = "0.00";
            txtRateEngland.Text = "1.2670316";

            txtAmountSpain.Text = "0.00";
            txtRateSpain.Text = "1.0871308";
        }

        private void usdTextChanged(object sender, EventArgs e)
        {
            
            txtTotalUSD.Text = 
                (Convert.ToDecimal(txtAmountEngland.Text) * Convert.ToDecimal(txtRateEngland.Text)
                ).ToString("0.00");
            txtTotalUSD.Text =
                (Convert.ToDecimal(txtAmountSpain.Text) * Convert.ToDecimal(txtRateSpain.Text)
                ).ToString("0.00");
            txtTotalUSD.Text =
                (Convert.ToDecimal(txtAmountBrazil.Text) * Convert.ToDecimal(txtRateBrazil.Text)
                ).ToString("0.00");
            txtTotalUSD.Text =
                (Convert.ToDecimal(txtAmountArgentina.Text) * Convert.ToDecimal(txtRateArgentina.Text)
                ).ToString("0.00");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
