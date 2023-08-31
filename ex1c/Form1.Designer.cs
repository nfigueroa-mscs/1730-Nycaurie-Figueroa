namespace ex1c
{
    partial class frmFoodTruck
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHamburgers = new System.Windows.Forms.TextBox();
            this.txtHotDogs = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHotDogsSubtotal = new System.Windows.Forms.TextBox();
            this.txtHamburgersSubtotal = new System.Windows.Forms.TextBox();
            this.txtPretaxTotal = new System.Windows.Forms.TextBox();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hot Dogs:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hamburgers:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtHamburgers
            // 
            this.txtHamburgers.Location = new System.Drawing.Point(109, 60);
            this.txtHamburgers.Name = "txtHamburgers";
            this.txtHamburgers.Size = new System.Drawing.Size(52, 20);
            this.txtHamburgers.TabIndex = 2;
            this.txtHamburgers.Text = "0";
            this.txtHamburgers.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtHotDogs
            // 
            this.txtHotDogs.AcceptsReturn = true;
            this.txtHotDogs.Location = new System.Drawing.Point(109, 34);
            this.txtHotDogs.Name = "txtHotDogs";
            this.txtHotDogs.Size = new System.Drawing.Size(52, 20);
            this.txtHotDogs.TabIndex = 3;
            this.txtHotDogs.Text = "0";
            this.txtHotDogs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(167, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "x $4.00 = ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(167, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "x $5.00 =";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtHotDogsSubtotal
            // 
            this.txtHotDogsSubtotal.Location = new System.Drawing.Point(224, 34);
            this.txtHotDogsSubtotal.Name = "txtHotDogsSubtotal";
            this.txtHotDogsSubtotal.Size = new System.Drawing.Size(50, 20);
            this.txtHotDogsSubtotal.TabIndex = 6;
            this.txtHotDogsSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtHamburgersSubtotal
            // 
            this.txtHamburgersSubtotal.Location = new System.Drawing.Point(224, 60);
            this.txtHamburgersSubtotal.Name = "txtHamburgersSubtotal";
            this.txtHamburgersSubtotal.Size = new System.Drawing.Size(50, 20);
            this.txtHamburgersSubtotal.TabIndex = 7;
            this.txtHamburgersSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPretaxTotal
            // 
            this.txtPretaxTotal.Location = new System.Drawing.Point(224, 86);
            this.txtPretaxTotal.Name = "txtPretaxTotal";
            this.txtPretaxTotal.ReadOnly = true;
            this.txtPretaxTotal.Size = new System.Drawing.Size(50, 20);
            this.txtPretaxTotal.TabIndex = 8;
            this.txtPretaxTotal.TabStop = false;
            this.txtPretaxTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTax
            // 
            this.txtTax.Location = new System.Drawing.Point(224, 112);
            this.txtTax.Name = "txtTax";
            this.txtTax.ReadOnly = true;
            this.txtTax.Size = new System.Drawing.Size(50, 20);
            this.txtTax.TabIndex = 9;
            this.txtTax.TabStop = false;
            this.txtTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(224, 138);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(50, 20);
            this.txtTotal.TabIndex = 10;
            this.txtTotal.TabStop = false;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(46, 164);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 11;
            this.btnCalculate.Text = "&Clculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(127, 164);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(208, 164);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(145, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Pretax total =";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(181, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Tax = ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(178, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Total =";
            // 
            // frmFoodTruck
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 233);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtTax);
            this.Controls.Add(this.txtPretaxTotal);
            this.Controls.Add(this.txtHamburgersSubtotal);
            this.Controls.Add(this.txtHotDogsSubtotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtHotDogs);
            this.Controls.Add(this.txtHamburgers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmFoodTruck";
            this.Text = "frmFoodTruck";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHamburgers;
        private System.Windows.Forms.TextBox txtHotDogs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHotDogsSubtotal;
        private System.Windows.Forms.TextBox txtHamburgersSubtotal;
        private System.Windows.Forms.TextBox txtPretaxTotal;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

