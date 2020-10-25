namespace SynthesisApp
{
    partial class Loan
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.radioButtonSeven = new System.Windows.Forms.RadioButton();
            this.radioButtonEight = new System.Windows.Forms.RadioButton();
            this.radioButtonNine = new System.Windows.Forms.RadioButton();
            this.groupBoxInterestRate = new System.Windows.Forms.GroupBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.labelName = new System.Windows.Forms.Label();
            this.labelBorrowedCapital = new System.Windows.Forms.Label();
            this.labelRepaymentPeriod = new System.Windows.Forms.Label();
            this.labelNumberOfMonths = new System.Windows.Forms.Label();
            this.labelRepaymentFrequency = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.labelNumberOfRepayments = new System.Windows.Forms.Label();
            this.labelRepayments = new System.Windows.Forms.Label();
            this.labelAmount = new System.Windows.Forms.Label();
            this.groupBoxInterestRate.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.textBox1.Location = new System.Drawing.Point(167, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(225, 23);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.textBox2.Location = new System.Drawing.Point(167, 88);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(225, 23);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // radioButtonSeven
            // 
            this.radioButtonSeven.AutoSize = true;
            this.radioButtonSeven.Location = new System.Drawing.Point(16, 26);
            this.radioButtonSeven.Name = "radioButtonSeven";
            this.radioButtonSeven.Size = new System.Drawing.Size(46, 21);
            this.radioButtonSeven.TabIndex = 2;
            this.radioButtonSeven.TabStop = true;
            this.radioButtonSeven.Text = "7%";
            this.radioButtonSeven.UseVisualStyleBackColor = true;
            // 
            // radioButtonEight
            // 
            this.radioButtonEight.AutoSize = true;
            this.radioButtonEight.Location = new System.Drawing.Point(16, 49);
            this.radioButtonEight.Name = "radioButtonEight";
            this.radioButtonEight.Size = new System.Drawing.Size(46, 21);
            this.radioButtonEight.TabIndex = 3;
            this.radioButtonEight.TabStop = true;
            this.radioButtonEight.Text = "8%";
            this.radioButtonEight.UseVisualStyleBackColor = true;
            // 
            // radioButtonNine
            // 
            this.radioButtonNine.AutoSize = true;
            this.radioButtonNine.Location = new System.Drawing.Point(16, 72);
            this.radioButtonNine.Name = "radioButtonNine";
            this.radioButtonNine.Size = new System.Drawing.Size(46, 21);
            this.radioButtonNine.TabIndex = 4;
            this.radioButtonNine.TabStop = true;
            this.radioButtonNine.Text = "9%";
            this.radioButtonNine.UseVisualStyleBackColor = true;
            // 
            // groupBoxInterestRate
            // 
            this.groupBoxInterestRate.Controls.Add(this.radioButtonNine);
            this.groupBoxInterestRate.Controls.Add(this.radioButtonEight);
            this.groupBoxInterestRate.Controls.Add(this.radioButtonSeven);
            this.groupBoxInterestRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.groupBoxInterestRate.Location = new System.Drawing.Point(434, 23);
            this.groupBoxInterestRate.Name = "groupBoxInterestRate";
            this.groupBoxInterestRate.Size = new System.Drawing.Size(80, 110);
            this.groupBoxInterestRate.TabIndex = 5;
            this.groupBoxInterestRate.TabStop = false;
            this.groupBoxInterestRate.Text = "Rate";
            // 
            // buttonOK
            // 
            this.buttonOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.buttonOK.Location = new System.Drawing.Point(532, 34);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(108, 29);
            this.buttonOK.TabIndex = 6;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.buttonCancel.Location = new System.Drawing.Point(532, 84);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(108, 31);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(167, 147);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(225, 23);
            this.hScrollBar1.TabIndex = 8;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelName.Location = new System.Drawing.Point(12, 34);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(45, 17);
            this.labelName.TabIndex = 10;
            this.labelName.Text = "Name";
            // 
            // labelBorrowedCapital
            // 
            this.labelBorrowedCapital.AutoSize = true;
            this.labelBorrowedCapital.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelBorrowedCapital.Location = new System.Drawing.Point(12, 91);
            this.labelBorrowedCapital.Name = "labelBorrowedCapital";
            this.labelBorrowedCapital.Size = new System.Drawing.Size(113, 17);
            this.labelBorrowedCapital.TabIndex = 11;
            this.labelBorrowedCapital.Text = "Borrowed capital";
            // 
            // labelRepaymentPeriod
            // 
            this.labelRepaymentPeriod.AutoSize = true;
            this.labelRepaymentPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelRepaymentPeriod.Location = new System.Drawing.Point(12, 150);
            this.labelRepaymentPeriod.Name = "labelRepaymentPeriod";
            this.labelRepaymentPeriod.Size = new System.Drawing.Size(124, 17);
            this.labelRepaymentPeriod.TabIndex = 12;
            this.labelRepaymentPeriod.Text = "Repayment period";
            // 
            // labelNumberOfMonths
            // 
            this.labelNumberOfMonths.AutoSize = true;
            this.labelNumberOfMonths.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelNumberOfMonths.Location = new System.Drawing.Point(164, 186);
            this.labelNumberOfMonths.MaximumSize = new System.Drawing.Size(225, 0);
            this.labelNumberOfMonths.MinimumSize = new System.Drawing.Size(225, 0);
            this.labelNumberOfMonths.Name = "labelNumberOfMonths";
            this.labelNumberOfMonths.Size = new System.Drawing.Size(225, 17);
            this.labelNumberOfMonths.TabIndex = 13;
            this.labelNumberOfMonths.Text = "120 months";
            this.labelNumberOfMonths.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelRepaymentFrequency
            // 
            this.labelRepaymentFrequency.AutoSize = true;
            this.labelRepaymentFrequency.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelRepaymentFrequency.Location = new System.Drawing.Point(12, 246);
            this.labelRepaymentFrequency.Name = "labelRepaymentFrequency";
            this.labelRepaymentFrequency.Size = new System.Drawing.Size(147, 17);
            this.labelRepaymentFrequency.TabIndex = 14;
            this.labelRepaymentFrequency.Text = "Repayment frequency";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(15, 272);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(172, 82);
            this.listBox1.TabIndex = 15;
            // 
            // labelNumberOfRepayments
            // 
            this.labelNumberOfRepayments.AutoSize = true;
            this.labelNumberOfRepayments.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.labelNumberOfRepayments.Location = new System.Drawing.Point(365, 272);
            this.labelNumberOfRepayments.Name = "labelNumberOfRepayments";
            this.labelNumberOfRepayments.Size = new System.Drawing.Size(36, 20);
            this.labelNumberOfRepayments.TabIndex = 16;
            this.labelNumberOfRepayments.Text = "100";
            // 
            // labelRepayments
            // 
            this.labelRepayments.AutoSize = true;
            this.labelRepayments.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.labelRepayments.Location = new System.Drawing.Point(407, 272);
            this.labelRepayments.Name = "labelRepayments";
            this.labelRepayments.Size = new System.Drawing.Size(115, 20);
            this.labelRepayments.TabIndex = 17;
            this.labelRepayments.Text = "repayments of";
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.labelAmount.Location = new System.Drawing.Point(528, 272);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(90, 20);
            this.labelAmount.TabIndex = 18;
            this.labelAmount.Text = "10000,00 $";
            // 
            // Loan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(652, 374);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.labelRepayments);
            this.Controls.Add(this.labelNumberOfRepayments);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.labelRepaymentFrequency);
            this.Controls.Add(this.labelNumberOfMonths);
            this.Controls.Add(this.labelRepaymentPeriod);
            this.Controls.Add(this.labelBorrowedCapital);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.groupBoxInterestRate);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Loan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loan";
            this.groupBoxInterestRate.ResumeLayout(false);
            this.groupBoxInterestRate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RadioButton radioButtonSeven;
        private System.Windows.Forms.RadioButton radioButtonEight;
        private System.Windows.Forms.RadioButton radioButtonNine;
        private System.Windows.Forms.GroupBox groupBoxInterestRate;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelBorrowedCapital;
        private System.Windows.Forms.Label labelRepaymentPeriod;
        private System.Windows.Forms.Label labelNumberOfMonths;
        private System.Windows.Forms.Label labelRepaymentFrequency;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label labelNumberOfRepayments;
        private System.Windows.Forms.Label labelRepayments;
        private System.Windows.Forms.Label labelAmount;
    }
}

