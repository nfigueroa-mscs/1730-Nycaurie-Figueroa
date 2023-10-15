using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex2d
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SetPassValueBotton_Click(object sender, EventArgs e)
        {
            textBox1input.Text = "Frank";
            textBox2input.Text = "";
            textBox3input.Text = "2.3";
            textBox4input.Text = "false";
            textBox5inputA.Text = "2";
            textBox5inputB.Text = "2";
            textBox6input.Text = "xyz";
            textBox7input.Text = "1";
            textBox8inputA.Text = "1";
            textBox8inputB.Text = "2";
            textBox9input.Text = "500";
            textBox10inputA.Text = "2";
            textBox10inputB.Text = "3";
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            textBox1Result.Text = "Fail";
            textBox2Result.Text = "Fail";
            textBox3Result.Text = "Fail";
            textBox4Result.Text = "Fail";
            textBox5Result.Text = "Fail";
            textBox6Result.Text = "Fail";
            textBox7Result.Text = "Fail";
            textBox8Result.Text = "Fail";
            textBox9Result.Text = "Fail";
            textBox10Result.Text = "Fail";

            textBox1Result.Text = "Success";
            textBox2Result.Text = "Success";
            textBox3Result.Text = "Success";
            textBox4Result.Text = "Success";
            textBox5Result.Text = "Success";
            textBox6Result.Text = "Success";
            textBox7Result.Text = "Success";
            textBox8Result.Text = "Success";
            textBox9Result.Text = "Success";
            textBox10Result.Text = "Success";

            if (textBox1input.Text == "Frank")
                textBox1Result.Text = "Success";
            if (textBox1input.Text != "Frank")
                textBox1Result.Text = "Fail";

            if (textBox2input.Text == "")
                textBox2Result.Text = "Success";
            if (textBox2input.Text != "")
                textBox2Result.Text = "Fail";

            decimal val3 = Convert.ToDecimal(textBox3input.Text);
            if (val3 == 2.3m)
                textBox3Result.Text = "Success";
            if (val3 != 2.3m)
                textBox3Result.Text = "Fail";

            bool val4 = Convert.ToBoolean(textBox4input.Text);
            if (val4 != false)
                textBox4Result.Text = "Success";
            if (val4 == true)
                textBox4Result.Text = "Fail";
            
            if (textBox5inputA.Text == textBox5inputB.Text)
                textBox5Result.Text = "Success";
            if (textBox5inputA.Text != textBox5inputB.Text)
                textBox5Result.Text = "Fail";
            

            if (textBox6input.Text != "xyz")
                textBox6Result.Text = "Success";
            if (textBox6input.Text == "Jones")
                textBox6Result.Text = "Fail";

            decimal val7 = Convert.ToDecimal(textBox7input.Text);
            if (val7 > 0)
                textBox7Result.Text = "Success";
            if (val7 <= 0)
                textBox7Result.Text = "Fail";

            decimal val8A = Convert.ToDecimal(textBox8inputA.Text);
            decimal val8B = Convert.ToDecimal(textBox8inputB.Text);
            if (val8A < val8B)
                textBox8Result.Text = "Success";
            if (val8A >= val8B)
                textBox8Result.Text = "Fail";

            decimal val9 = Convert.ToDecimal(textBox9input.Text);
            if (val9 >= 500)
                textBox9Result.Text = "Success";
            if (val9 < 500)
                textBox9Result.Text = "Fail";

            decimal val10A = Convert.ToDecimal(textBox10inputA.Text);
            decimal val10B = Convert.ToDecimal(textBox10inputB.Text);
            if (val10A <= val10B)
                textBox10Result.Text = "Success";
            if (val10A >= val10B)
                textBox10Result.Text = "Fail";
        }

        private void SetFailValueButton_Click(object sender, EventArgs e)
        {
            textBox1input.Text = "xyz";
            textBox2input.Text = "xyz";
            textBox3input.Text = "2.4";
            textBox4input.Text = "true";
            textBox5inputA.Text = "2";
            textBox5inputB.Text = "3";
            textBox6input.Text = "Jones";
            textBox7input.Text = "0";
            textBox8inputA.Text = "1";
            textBox8inputB.Text = "1";
            textBox9input.Text = "499";
            textBox10inputA.Text = "4";
            textBox10inputB.Text = "3";
        }
    }
}
