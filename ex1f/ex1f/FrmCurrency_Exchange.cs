using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex1f
{
    public partial class FrmCurrencyExchange : Form
    {
        public FrmCurrencyExchange()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnKorean.BackgroundImage = picKorea.Image;
            btnUnitedArab.BackgroundImage = picUnitedArabDim.Image;
            btnSpain.BackgroundImage = picSpainDim.Image;
            btnSouthAfrica.BackgroundImage = picSouthAfricaDim.Image;
            txtRate.Text = "0.00075258171";
            lblCurrency.Text = btnKorean.Text + ": ";
            txtUSDollar.Text = "0.00";
            txtTotalUSD.Text = "0.00";
            txtCurrency.Focus();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnKorean.BackgroundImage = picKoreanDim.Image;
            btnUnitedArab.BackgroundImage = picUnitedArabDim.Image;
            btnSpain.BackgroundImage = picSpainDim.Image;
            btnSouthAfrica.BackgroundImage = picSouthAfricaDim.Image;
                      
            
        }

        private void btnUnitedArab_Click(object sender, EventArgs e)
        {
            btnUnitedArab.BackgroundImage = picUnitedArab.Image;
            btnKorean.BackgroundImage = picKoreanDim.Image;
            btnSpain.BackgroundImage = picSpainDim.Image;
            btnSouthAfrica.BackgroundImage = picSouthAfricaDim.Image;
            lblCurrency.Text = btnUnitedArab.Text + ": ";
            txtRate.Text = "0.27229408";
            txtUSDollar.Text = "0.00";
            txtTotalUSD.Text = "0.00";
        }

        private void btnSpain_Click(object sender, EventArgs e)
        {
            btnSpain.BackgroundImage = picSpain.Image;
            btnSouthAfrica.BackgroundImage = picSouthAfricaDim.Image;
            btnKorean.BackgroundImage = picKoreanDim.Image;
            btnUnitedArab.BackgroundImage = picUnitedArabDim.Image;
            txtRate.Text = "1.0656312";
            lblCurrency.Text = btnSpain.Text + ": ";
            txtUSDollar.Text = "0.00";
            txtTotalUSD.Text = "0.00";
        }

        private void btnSouthAfrica_Click(object sender, EventArgs e)
        {
            btnSouthAfrica.BackgroundImage = picSouthAfrica.Image;
            btnSpain.BackgroundImage = picSpainDim.Image;
            btnKorean.BackgroundImage = picKoreanDim.Image;
            btnUnitedArab.BackgroundImage = picUnitedArabDim.Image;
            txtRate.Text = "0.052503191";
            lblCurrency.Text = btnSouthAfrica.Text + ": ";
            txtUSDollar.Text = "0.00";
            txtTotalUSD.Text = "0.00";
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void calcUSD(object sender, EventArgs e)
        {
            txtUSDollar.Text = txtCurrency.Text + txtTotalUSD.Text;
        }

        private void txtCurrency_Enter(object sender, EventArgs e)
        {
            txtCurrency.Select();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lblEquation.Text = lblEquation.Text + " + " + txtTotalUSD.Text;
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtCurrency.Text = "0";
            txtTotalUSD.Text = "0";
            txtUSDollar.Text = "0";
        }

        private void txtUSD_Click(object sender, EventArgs e)
        {
            txtCurrency.Text = txtRate.Text +  txtUSDollar.Text;
        }
    }
}
