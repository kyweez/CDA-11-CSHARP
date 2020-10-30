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
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbDateOfBirth = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.gbClient = new System.Windows.Forms.GroupBox();
            this.cbSex = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.labSex = new System.Windows.Forms.Label();
            this.labDateOfBirth = new System.Windows.Forms.Label();
            this.labLastName = new System.Windows.Forms.Label();
            this.labFirstName = new System.Windows.Forms.Label();
            this.tbBorrowedCapital = new System.Windows.Forms.TextBox();
            this.hsbRepaymentDuration = new System.Windows.Forms.HScrollBar();
            this.lbRepaymentPeriodicity = new System.Windows.Forms.ListBox();
            this.rbSeven = new System.Windows.Forms.RadioButton();
            this.rbEight = new System.Windows.Forms.RadioButton();
            this.rbNine = new System.Windows.Forms.RadioButton();
            this.gbInterestRate = new System.Windows.Forms.GroupBox();
            this.labBorrowedCapital = new System.Windows.Forms.Label();
            this.labRepaymentDuration = new System.Windows.Forms.Label();
            this.labMonths = new System.Windows.Forms.Label();
            this.labRepaymentPeriodicity = new System.Windows.Forms.Label();
            this.gbLoan = new System.Windows.Forms.GroupBox();
            this.labResult = new System.Windows.Forms.Label();
            this.gbClient.SuspendLayout();
            this.gbInterestRate.SuspendLayout();
            this.gbLoan.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbFirstName
            // 
            this.tbFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFirstName.Location = new System.Drawing.Point(151, 36);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(204, 24);
            this.tbFirstName.TabIndex = 0;
            // 
            // tbLastName
            // 
            this.tbLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLastName.Location = new System.Drawing.Point(151, 79);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(204, 24);
            this.tbLastName.TabIndex = 1;
            // 
            // tbDateOfBirth
            // 
            this.tbDateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDateOfBirth.Location = new System.Drawing.Point(151, 120);
            this.tbDateOfBirth.Name = "tbDateOfBirth";
            this.tbDateOfBirth.Size = new System.Drawing.Size(204, 24);
            this.tbDateOfBirth.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(151, 263);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(204, 26);
            this.comboBox1.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(151, 213);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 30);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Enabled = false;
            this.btnReset.Location = new System.Drawing.Point(280, 213);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 30);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // gbClient
            // 
            this.gbClient.Controls.Add(this.cbSex);
            this.gbClient.Controls.Add(this.btnDelete);
            this.gbClient.Controls.Add(this.labSex);
            this.gbClient.Controls.Add(this.labDateOfBirth);
            this.gbClient.Controls.Add(this.labLastName);
            this.gbClient.Controls.Add(this.labFirstName);
            this.gbClient.Controls.Add(this.btnReset);
            this.gbClient.Controls.Add(this.btnSave);
            this.gbClient.Controls.Add(this.comboBox1);
            this.gbClient.Controls.Add(this.tbDateOfBirth);
            this.gbClient.Controls.Add(this.tbLastName);
            this.gbClient.Controls.Add(this.tbFirstName);
            this.gbClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbClient.Location = new System.Drawing.Point(25, 23);
            this.gbClient.Name = "gbClient";
            this.gbClient.Size = new System.Drawing.Size(425, 476);
            this.gbClient.TabIndex = 7;
            this.gbClient.TabStop = false;
            this.gbClient.Text = "Client";
            // 
            // cbSex
            // 
            this.cbSex.FormattingEnabled = true;
            this.cbSex.Location = new System.Drawing.Point(151, 165);
            this.cbSex.Name = "cbSex";
            this.cbSex.Size = new System.Drawing.Size(204, 26);
            this.cbSex.TabIndex = 3;
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(27, 259);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 30);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // labSex
            // 
            this.labSex.AutoSize = true;
            this.labSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSex.Location = new System.Drawing.Point(25, 165);
            this.labSex.Name = "labSex";
            this.labSex.Size = new System.Drawing.Size(33, 18);
            this.labSex.TabIndex = 11;
            this.labSex.Text = "Sex";
            // 
            // labDateOfBirth
            // 
            this.labDateOfBirth.AutoSize = true;
            this.labDateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDateOfBirth.Location = new System.Drawing.Point(25, 123);
            this.labDateOfBirth.Name = "labDateOfBirth";
            this.labDateOfBirth.Size = new System.Drawing.Size(88, 18);
            this.labDateOfBirth.TabIndex = 10;
            this.labDateOfBirth.Text = "Date of birth";
            // 
            // labLastName
            // 
            this.labLastName.AutoSize = true;
            this.labLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labLastName.Location = new System.Drawing.Point(25, 82);
            this.labLastName.Name = "labLastName";
            this.labLastName.Size = new System.Drawing.Size(77, 18);
            this.labLastName.TabIndex = 9;
            this.labLastName.Text = "Last name";
            // 
            // labFirstName
            // 
            this.labFirstName.AutoSize = true;
            this.labFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labFirstName.Location = new System.Drawing.Point(25, 39);
            this.labFirstName.Name = "labFirstName";
            this.labFirstName.Size = new System.Drawing.Size(78, 18);
            this.labFirstName.TabIndex = 8;
            this.labFirstName.Text = "First name";
            // 
            // tbBorrowedCapital
            // 
            this.tbBorrowedCapital.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBorrowedCapital.Location = new System.Drawing.Point(146, 31);
            this.tbBorrowedCapital.Name = "tbBorrowedCapital";
            this.tbBorrowedCapital.Size = new System.Drawing.Size(204, 24);
            this.tbBorrowedCapital.TabIndex = 12;
            // 
            // hsbRepaymentDuration
            // 
            this.hsbRepaymentDuration.Location = new System.Drawing.Point(23, 115);
            this.hsbRepaymentDuration.Name = "hsbRepaymentDuration";
            this.hsbRepaymentDuration.Size = new System.Drawing.Size(327, 24);
            this.hsbRepaymentDuration.TabIndex = 13;
            // 
            // lbRepaymentPeriodicity
            // 
            this.lbRepaymentPeriodicity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRepaymentPeriodicity.FormattingEnabled = true;
            this.lbRepaymentPeriodicity.ItemHeight = 18;
            this.lbRepaymentPeriodicity.Location = new System.Drawing.Point(23, 222);
            this.lbRepaymentPeriodicity.Name = "lbRepaymentPeriodicity";
            this.lbRepaymentPeriodicity.Size = new System.Drawing.Size(183, 94);
            this.lbRepaymentPeriodicity.TabIndex = 14;
            // 
            // rbSeven
            // 
            this.rbSeven.AutoSize = true;
            this.rbSeven.Location = new System.Drawing.Point(22, 31);
            this.rbSeven.Name = "rbSeven";
            this.rbSeven.Size = new System.Drawing.Size(47, 22);
            this.rbSeven.TabIndex = 16;
            this.rbSeven.TabStop = true;
            this.rbSeven.Text = "7%";
            this.rbSeven.UseVisualStyleBackColor = true;
            // 
            // rbEight
            // 
            this.rbEight.AutoSize = true;
            this.rbEight.Location = new System.Drawing.Point(22, 59);
            this.rbEight.Name = "rbEight";
            this.rbEight.Size = new System.Drawing.Size(47, 22);
            this.rbEight.TabIndex = 17;
            this.rbEight.TabStop = true;
            this.rbEight.Text = "8%";
            this.rbEight.UseVisualStyleBackColor = true;
            // 
            // rbNine
            // 
            this.rbNine.AutoSize = true;
            this.rbNine.Location = new System.Drawing.Point(22, 87);
            this.rbNine.Name = "rbNine";
            this.rbNine.Size = new System.Drawing.Size(47, 22);
            this.rbNine.TabIndex = 18;
            this.rbNine.TabStop = true;
            this.rbNine.Text = "9%";
            this.rbNine.UseVisualStyleBackColor = true;
            // 
            // gbInterestRate
            // 
            this.gbInterestRate.Controls.Add(this.rbSeven);
            this.gbInterestRate.Controls.Add(this.rbNine);
            this.gbInterestRate.Controls.Add(this.rbEight);
            this.gbInterestRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInterestRate.Location = new System.Drawing.Point(235, 199);
            this.gbInterestRate.Name = "gbInterestRate";
            this.gbInterestRate.Size = new System.Drawing.Size(115, 121);
            this.gbInterestRate.TabIndex = 15;
            this.gbInterestRate.TabStop = false;
            this.gbInterestRate.Text = "Interest rate";
            // 
            // labBorrowedCapital
            // 
            this.labBorrowedCapital.AutoSize = true;
            this.labBorrowedCapital.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labBorrowedCapital.Location = new System.Drawing.Point(20, 34);
            this.labBorrowedCapital.Name = "labBorrowedCapital";
            this.labBorrowedCapital.Size = new System.Drawing.Size(119, 18);
            this.labBorrowedCapital.TabIndex = 19;
            this.labBorrowedCapital.Text = "Borrowed capital";
            // 
            // labRepaymentDuration
            // 
            this.labRepaymentDuration.AutoSize = true;
            this.labRepaymentDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labRepaymentDuration.Location = new System.Drawing.Point(119, 91);
            this.labRepaymentDuration.Name = "labRepaymentDuration";
            this.labRepaymentDuration.Size = new System.Drawing.Size(140, 18);
            this.labRepaymentDuration.TabIndex = 20;
            this.labRepaymentDuration.Text = "Repayment duration";
            // 
            // labMonths
            // 
            this.labMonths.AutoSize = true;
            this.labMonths.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labMonths.Location = new System.Drawing.Point(119, 148);
            this.labMonths.MinimumSize = new System.Drawing.Size(140, 0);
            this.labMonths.Name = "labMonths";
            this.labMonths.Size = new System.Drawing.Size(140, 18);
            this.labMonths.TabIndex = 21;
            this.labMonths.Text = "120 months";
            this.labMonths.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labRepaymentPeriodicity
            // 
            this.labRepaymentPeriodicity.AutoSize = true;
            this.labRepaymentPeriodicity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labRepaymentPeriodicity.Location = new System.Drawing.Point(20, 199);
            this.labRepaymentPeriodicity.Name = "labRepaymentPeriodicity";
            this.labRepaymentPeriodicity.Size = new System.Drawing.Size(155, 18);
            this.labRepaymentPeriodicity.TabIndex = 22;
            this.labRepaymentPeriodicity.Text = "Repayment Periodicity";
            // 
            // gbLoan
            // 
            this.gbLoan.Controls.Add(this.labResult);
            this.gbLoan.Controls.Add(this.hsbRepaymentDuration);
            this.gbLoan.Controls.Add(this.labRepaymentPeriodicity);
            this.gbLoan.Controls.Add(this.tbBorrowedCapital);
            this.gbLoan.Controls.Add(this.labMonths);
            this.gbLoan.Controls.Add(this.lbRepaymentPeriodicity);
            this.gbLoan.Controls.Add(this.labRepaymentDuration);
            this.gbLoan.Controls.Add(this.gbInterestRate);
            this.gbLoan.Controls.Add(this.labBorrowedCapital);
            this.gbLoan.Enabled = false;
            this.gbLoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbLoan.Location = new System.Drawing.Point(483, 25);
            this.gbLoan.Name = "gbLoan";
            this.gbLoan.Size = new System.Drawing.Size(372, 474);
            this.gbLoan.TabIndex = 23;
            this.gbLoan.TabStop = false;
            this.gbLoan.Text = "Loan";
            // 
            // labResult
            // 
            this.labResult.AutoSize = true;
            this.labResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labResult.Location = new System.Drawing.Point(20, 382);
            this.labResult.MinimumSize = new System.Drawing.Size(327, 0);
            this.labResult.Name = "labResult";
            this.labResult.Size = new System.Drawing.Size(327, 20);
            this.labResult.TabIndex = 23;
            this.labResult.Text = "120 repayments of 12345,67 $";
            this.labResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Loan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(893, 531);
            this.Controls.Add(this.gbLoan);
            this.Controls.Add(this.gbClient);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Loan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loan";
            this.gbClient.ResumeLayout(false);
            this.gbClient.PerformLayout();
            this.gbInterestRate.ResumeLayout(false);
            this.gbInterestRate.PerformLayout();
            this.gbLoan.ResumeLayout(false);
            this.gbLoan.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbDateOfBirth;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox gbClient;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label labSex;
        private System.Windows.Forms.Label labDateOfBirth;
        private System.Windows.Forms.Label labLastName;
        private System.Windows.Forms.Label labFirstName;
        private System.Windows.Forms.TextBox tbBorrowedCapital;
        private System.Windows.Forms.HScrollBar hsbRepaymentDuration;
        private System.Windows.Forms.ListBox lbRepaymentPeriodicity;
        private System.Windows.Forms.RadioButton rbSeven;
        private System.Windows.Forms.RadioButton rbEight;
        private System.Windows.Forms.RadioButton rbNine;
        private System.Windows.Forms.GroupBox gbInterestRate;
        private System.Windows.Forms.Label labBorrowedCapital;
        private System.Windows.Forms.Label labRepaymentDuration;
        private System.Windows.Forms.Label labMonths;
        private System.Windows.Forms.Label labRepaymentPeriodicity;
        private System.Windows.Forms.GroupBox gbLoan;
        private System.Windows.Forms.ComboBox cbSex;
        private System.Windows.Forms.Label labResult;
    }
}

