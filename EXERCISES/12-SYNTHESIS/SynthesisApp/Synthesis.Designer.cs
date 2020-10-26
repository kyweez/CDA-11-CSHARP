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
            this.components = new System.ComponentModel.Container();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxBorrowedCapital = new System.Windows.Forms.TextBox();
            this.radioButtonSeven = new System.Windows.Forms.RadioButton();
            this.radioButtonEight = new System.Windows.Forms.RadioButton();
            this.radioButtonNine = new System.Windows.Forms.RadioButton();
            this.groupBoxInterestRate = new System.Windows.Forms.GroupBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.hScrollBarNumberOfMonths = new System.Windows.Forms.HScrollBar();
            this.labelName = new System.Windows.Forms.Label();
            this.labelBorrowedCapital = new System.Windows.Forms.Label();
            this.labelRepaymentPeriod = new System.Windows.Forms.Label();
            this.labelNumberOfMonths = new System.Windows.Forms.Label();
            this.labelRepaymentFrequency = new System.Windows.Forms.Label();
            this.listBoxRepaymentFrequency = new System.Windows.Forms.ListBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.errorProviderName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderAmount = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBoxInterestRate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.textBoxName.Location = new System.Drawing.Point(167, 31);
            this.textBoxName.MaxLength = 30;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(284, 23);
            this.textBoxName.TabIndex = 0;
            this.textBoxName.TextChanged += new System.EventHandler(this.TextBoxName_TextChanged);
            // 
            // textBoxBorrowedCapital
            // 
            this.textBoxBorrowedCapital.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.textBoxBorrowedCapital.Location = new System.Drawing.Point(167, 88);
            this.textBoxBorrowedCapital.MaxLength = 7;
            this.textBoxBorrowedCapital.Name = "textBoxBorrowedCapital";
            this.textBoxBorrowedCapital.Size = new System.Drawing.Size(135, 23);
            this.textBoxBorrowedCapital.TabIndex = 1;
            this.textBoxBorrowedCapital.TextChanged += new System.EventHandler(this.TextBorrowedCapital_TextChanged);
            // 
            // radioButtonSeven
            // 
            this.radioButtonSeven.AutoSize = true;
            this.radioButtonSeven.Checked = true;
            this.radioButtonSeven.Location = new System.Drawing.Point(16, 26);
            this.radioButtonSeven.Name = "radioButtonSeven";
            this.radioButtonSeven.Size = new System.Drawing.Size(46, 21);
            this.radioButtonSeven.TabIndex = 2;
            this.radioButtonSeven.TabStop = true;
            this.radioButtonSeven.Tag = "7";
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
            this.radioButtonEight.Tag = "8";
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
            this.radioButtonNine.Tag = "9";
            this.radioButtonNine.Text = "9%";
            this.radioButtonNine.UseVisualStyleBackColor = true;
            // 
            // groupBoxInterestRate
            // 
            this.groupBoxInterestRate.Controls.Add(this.radioButtonNine);
            this.groupBoxInterestRate.Controls.Add(this.radioButtonEight);
            this.groupBoxInterestRate.Controls.Add(this.radioButtonSeven);
            this.groupBoxInterestRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.groupBoxInterestRate.Location = new System.Drawing.Point(507, 23);
            this.groupBoxInterestRate.Name = "groupBoxInterestRate";
            this.groupBoxInterestRate.Size = new System.Drawing.Size(80, 110);
            this.groupBoxInterestRate.TabIndex = 5;
            this.groupBoxInterestRate.TabStop = false;
            this.groupBoxInterestRate.Text = "Rate";
            // 
            // buttonOK
            // 
            this.buttonOK.Enabled = false;
            this.buttonOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.buttonOK.Location = new System.Drawing.Point(605, 34);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(108, 29);
            this.buttonOK.TabIndex = 6;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.ButtonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.buttonCancel.Location = new System.Drawing.Point(605, 84);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(108, 31);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // hScrollBarNumberOfMonths
            // 
            this.hScrollBarNumberOfMonths.Location = new System.Drawing.Point(167, 147);
            this.hScrollBarNumberOfMonths.Maximum = 309;
            this.hScrollBarNumberOfMonths.Minimum = 1;
            this.hScrollBarNumberOfMonths.Name = "hScrollBarNumberOfMonths";
            this.hScrollBarNumberOfMonths.Size = new System.Drawing.Size(284, 23);
            this.hScrollBarNumberOfMonths.TabIndex = 8;
            this.hScrollBarNumberOfMonths.Value = 1;
            this.hScrollBarNumberOfMonths.ValueChanged += new System.EventHandler(this.HScrollBarNumberOfMonths_ValueChanged);
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
            // listBoxRepaymentFrequency
            // 
            this.listBoxRepaymentFrequency.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.listBoxRepaymentFrequency.FormattingEnabled = true;
            this.listBoxRepaymentFrequency.ItemHeight = 17;
            this.listBoxRepaymentFrequency.Location = new System.Drawing.Point(15, 272);
            this.listBoxRepaymentFrequency.Name = "listBoxRepaymentFrequency";
            this.listBoxRepaymentFrequency.Size = new System.Drawing.Size(144, 89);
            this.listBoxRepaymentFrequency.TabIndex = 15;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.labelResult.ForeColor = System.Drawing.Color.Red;
            this.labelResult.Location = new System.Drawing.Point(287, 287);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(295, 26);
            this.labelResult.TabIndex = 16;
            this.labelResult.Text = "100 repayment of 12345,12 $";
            this.labelResult.Visible = false;
            // 
            // errorProviderName
            // 
            this.errorProviderName.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderName.ContainerControl = this;
            // 
            // errorProviderAmount
            // 
            this.errorProviderAmount.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderAmount.ContainerControl = this;
            // 
            // Loan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(737, 383);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.listBoxRepaymentFrequency);
            this.Controls.Add(this.labelRepaymentFrequency);
            this.Controls.Add(this.labelNumberOfMonths);
            this.Controls.Add(this.labelRepaymentPeriod);
            this.Controls.Add(this.labelBorrowedCapital);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.hScrollBarNumberOfMonths);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.groupBoxInterestRate);
            this.Controls.Add(this.textBoxBorrowedCapital);
            this.Controls.Add(this.textBoxName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Loan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loan";
            this.groupBoxInterestRate.ResumeLayout(false);
            this.groupBoxInterestRate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxBorrowedCapital;
        private System.Windows.Forms.RadioButton radioButtonSeven;
        private System.Windows.Forms.RadioButton radioButtonEight;
        private System.Windows.Forms.RadioButton radioButtonNine;
        private System.Windows.Forms.GroupBox groupBoxInterestRate;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.HScrollBar hScrollBarNumberOfMonths;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelBorrowedCapital;
        private System.Windows.Forms.Label labelRepaymentPeriod;
        private System.Windows.Forms.Label labelNumberOfMonths;
        private System.Windows.Forms.Label labelRepaymentFrequency;
        private System.Windows.Forms.ListBox listBoxRepaymentFrequency;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.ErrorProvider errorProviderName;
        private System.Windows.Forms.ErrorProvider errorProviderAmount;
    }
}

