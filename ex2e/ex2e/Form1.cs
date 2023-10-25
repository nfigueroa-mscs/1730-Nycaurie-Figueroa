using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex2e
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            result01TextBox.Text = "";
            result02TextBox.Text = "";
            result03TextBox.Text = "";
            sideeffect03TextBox.Text = "";
            result04TextBox.Text = "";
            sideeffect04TextBox.Text = "";
            result05TextBox.Text = "";
            sideeffect05TextBox.Text = "";
            result06TextBox.Text = "";
            sideeffect06TextBox.Text = "";
            result07TextBox.Text = "";
            result08TextBox.Text = "";
            sideeffect09TextBox.Text = "";

            // #01
            decimal subtotal = Convert.ToDecimal(input01aTextBox.Text);
            result01TextBox.Text = (subtotal >= 250 && subtotal < 500).ToString();

            // #02
            int timeInService = Convert.ToInt32(input02aTextBox.Text);
            result02TextBox.Text = (timeInService <= 4 || timeInService >= 12).ToString();

            // #03 - 06 initialization
            bool isValid = Convert.ToBoolean(input03aTextBox.Text);
            int years = Convert.ToInt32(input03cTextBox.Text);

            // #03 
            int counter = Convert.ToInt32(input03bTextBox.Text);
            result03TextBox.Text = (isValid == true && counter++ <years).ToString();
            sideeffect03TextBox.Text = counter.ToString();

            // #04 
            counter = Convert.ToInt32(input03bTextBox.Text);
            result04TextBox.Text = (isValid == true && counter++ < years).ToString();
            sideeffect04TextBox.Text = counter.ToString();

            // #05 
            counter = Convert.ToInt32(input03bTextBox.Text);
            
            // #06 
            counter = Convert.ToInt32(input03bTextBox.Text);
            result06TextBox.Text = (isValid == true && counter++ < years).ToString();
            sideeffect06TextBox.Text = counter.ToString();


            // #07
            DateTime startDate = Convert.ToDateTime(input07aTextBox.Text);
            DateTime expirationDate = Convert.ToDateTime(input07bTextBox.Text);
            DateTime date = Convert.ToDateTime(input07cTextBox.Text);
            isValid = Convert.ToBoolean(input07dTextBox.Text);
            result07TextBox.Text = (
               (startDate, expirationDate, date, isValid)
               ).ToString();

            // #08
            decimal thisYTD = Convert.ToDecimal(input08aTextBox.Text);
            decimal lastYTD = Convert.ToDecimal(input08bTextBox.Text);
            string empType = input08cTextBox.Text;
            int startYear = Convert.ToInt32(input08dTextBox.Text);
            int currentYear = Convert.ToInt32(input08eTextBox.Text);
            result08TextBox.Text = (
                (thisYTD, lastYTD, empType, startYear, currentYear)
                ).ToString();

            // #09 
            counter = Convert.ToInt32(input09aTextBox.Text);
            years = Convert.ToInt32(input09bTextBox.Text);
            result09TextBox.Text = (
                (counter, years)
                ).ToString();
            sideeffect09TextBox.Text = counter.ToString();




        }
    }
}
