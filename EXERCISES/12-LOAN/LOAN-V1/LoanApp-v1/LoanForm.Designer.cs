namespace LoanApp_v1
{
    partial class LoanForm
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
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbBorrowedCapital = new System.Windows.Forms.TextBox();
            this.hsbRepaymentDuration = new System.Windows.Forms.HScrollBar();
            this.gbInterestRate = new System.Windows.Forms.GroupBox();
            this.rbSeven = new System.Windows.Forms.RadioButton();
            this.rbEight = new System.Windows.Forms.RadioButton();
            this.rbNine = new System.Windows.Forms.RadioButton();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lbRepaymentPeriodicity = new System.Windows.Forms.ListBox();
            this.labName = new System.Windows.Forms.Label();
            this.labBorrowedCapital = new System.Windows.Forms.Label();
            this.labRepaymentDuration = new System.Windows.Forms.Label();
            this.labNumberOfMonths = new System.Windows.Forms.Label();
            this.labRepaymentPeriodicity = new System.Windows.Forms.Label();
            this.labResult = new System.Windows.Forms.Label();
            this.errorProviderName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderCapital = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbInterestRate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCapital)).BeginInit();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(205, 40);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(229, 24);
            this.tbName.TabIndex = 0;
            // 
            // tbBorrowedCapital
            // 
            this.tbBorrowedCapital.Location = new System.Drawing.Point(205, 116);
            this.tbBorrowedCapital.Name = "tbBorrowedCapital";
            this.tbBorrowedCapital.Size = new System.Drawing.Size(100, 24);
            this.tbBorrowedCapital.TabIndex = 1;
            // 
            // hsbRepaymentDuration
            // 
            this.hsbRepaymentDuration.Location = new System.Drawing.Point(205, 184);
            this.hsbRepaymentDuration.Name = "hsbRepaymentDuration";
            this.hsbRepaymentDuration.Size = new System.Drawing.Size(229, 24);
            this.hsbRepaymentDuration.TabIndex = 2;
            // 
            // gbInterestRate
            // 
            this.gbInterestRate.Controls.Add(this.rbNine);
            this.gbInterestRate.Controls.Add(this.rbEight);
            this.gbInterestRate.Controls.Add(this.rbSeven);
            this.gbInterestRate.Location = new System.Drawing.Point(480, 32);
            this.gbInterestRate.Name = "gbInterestRate";
            this.gbInterestRate.Size = new System.Drawing.Size(111, 177);
            this.gbInterestRate.TabIndex = 3;
            this.gbInterestRate.TabStop = false;
            this.gbInterestRate.Text = "Interetst rate";
            // 
            // rbSeven
            // 
            this.rbSeven.AutoSize = true;
            this.rbSeven.Checked = true;
            this.rbSeven.Location = new System.Drawing.Point(28, 34);
            this.rbSeven.Name = "rbSeven";
            this.rbSeven.Size = new System.Drawing.Size(47, 22);
            this.rbSeven.TabIndex = 0;
            this.rbSeven.TabStop = true;
            this.rbSeven.Text = "7%";
            this.rbSeven.UseVisualStyleBackColor = true;
            // 
            // rbEight
            // 
            this.rbEight.AutoSize = true;
            this.rbEight.Location = new System.Drawing.Point(28, 84);
            this.rbEight.Name = "rbEight";
            this.rbEight.Size = new System.Drawing.Size(47, 22);
            this.rbEight.TabIndex = 1;
            this.rbEight.Text = "8%";
            this.rbEight.UseVisualStyleBackColor = true;
            // 
            // rbNine
            // 
            this.rbNine.AutoSize = true;
            this.rbNine.Location = new System.Drawing.Point(28, 132);
            this.rbNine.Name = "rbNine";
            this.rbNine.Size = new System.Drawing.Size(47, 22);
            this.rbNine.TabIndex = 2;
            this.rbNine.Text = "9%";
            this.rbNine.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(650, 40);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(121, 38);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(650, 100);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(121, 38);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // lbRepaymentPeriodicity
            // 
            this.lbRepaymentPeriodicity.FormattingEnabled = true;
            this.lbRepaymentPeriodicity.ItemHeight = 18;
            this.lbRepaymentPeriodicity.Location = new System.Drawing.Point(35, 311);
            this.lbRepaymentPeriodicity.Name = "lbRepaymentPeriodicity";
            this.lbRepaymentPeriodicity.Size = new System.Drawing.Size(199, 94);
            this.lbRepaymentPeriodicity.TabIndex = 6;
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Location = new System.Drawing.Point(32, 43);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(48, 18);
            this.labName.TabIndex = 7;
            this.labName.Text = "Name";
            // 
            // labBorrowedCapital
            // 
            this.labBorrowedCapital.AutoSize = true;
            this.labBorrowedCapital.Location = new System.Drawing.Point(32, 119);
            this.labBorrowedCapital.Name = "labBorrowedCapital";
            this.labBorrowedCapital.Size = new System.Drawing.Size(119, 18);
            this.labBorrowedCapital.TabIndex = 8;
            this.labBorrowedCapital.Text = "Borrowed capital";
            // 
            // labRepaymentDuration
            // 
            this.labRepaymentDuration.AutoSize = true;
            this.labRepaymentDuration.Location = new System.Drawing.Point(32, 187);
            this.labRepaymentDuration.Name = "labRepaymentDuration";
            this.labRepaymentDuration.Size = new System.Drawing.Size(140, 18);
            this.labRepaymentDuration.TabIndex = 9;
            this.labRepaymentDuration.Text = "Repayment duration";
            // 
            // labNumberOfMonths
            // 
            this.labNumberOfMonths.AutoSize = true;
            this.labNumberOfMonths.Location = new System.Drawing.Point(205, 215);
            this.labNumberOfMonths.MinimumSize = new System.Drawing.Size(229, 0);
            this.labNumberOfMonths.Name = "labNumberOfMonths";
            this.labNumberOfMonths.Size = new System.Drawing.Size(229, 18);
            this.labNumberOfMonths.TabIndex = 10;
            this.labNumberOfMonths.Text = "1 month";
            this.labNumberOfMonths.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labRepaymentPeriodicity
            // 
            this.labRepaymentPeriodicity.AutoSize = true;
            this.labRepaymentPeriodicity.Location = new System.Drawing.Point(32, 285);
            this.labRepaymentPeriodicity.Name = "labRepaymentPeriodicity";
            this.labRepaymentPeriodicity.Size = new System.Drawing.Size(153, 18);
            this.labRepaymentPeriodicity.TabIndex = 11;
            this.labRepaymentPeriodicity.Text = "Repayment periodicity";
            // 
            // labResult
            // 
            this.labResult.AutoSize = true;
            this.labResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labResult.Location = new System.Drawing.Point(327, 339);
            this.labResult.Name = "labResult";
            this.labResult.Size = new System.Drawing.Size(294, 25);
            this.labResult.TabIndex = 12;
            this.labResult.Text = "1 repayment of 12345,12 $";
            // 
            // errorProviderName
            // 
            this.errorProviderName.ContainerControl = this;
            // 
            // errorProviderCapital
            // 
            this.errorProviderCapital.ContainerControl = this;
            // 
            // LoanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(802, 429);
            this.Controls.Add(this.labResult);
            this.Controls.Add(this.labRepaymentPeriodicity);
            this.Controls.Add(this.labNumberOfMonths);
            this.Controls.Add(this.labRepaymentDuration);
            this.Controls.Add(this.labBorrowedCapital);
            this.Controls.Add(this.labName);
            this.Controls.Add(this.lbRepaymentPeriodicity);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbInterestRate);
            this.Controls.Add(this.hsbRepaymentDuration);
            this.Controls.Add(this.tbBorrowedCapital);
            this.Controls.Add(this.tbName);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "LoanForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create a loan";
            this.gbInterestRate.ResumeLayout(false);
            this.gbInterestRate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCapital)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbBorrowedCapital;
        private System.Windows.Forms.HScrollBar hsbRepaymentDuration;
        private System.Windows.Forms.GroupBox gbInterestRate;
        private System.Windows.Forms.RadioButton rbNine;
        private System.Windows.Forms.RadioButton rbEight;
        private System.Windows.Forms.RadioButton rbSeven;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ListBox lbRepaymentPeriodicity;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label labBorrowedCapital;
        private System.Windows.Forms.Label labRepaymentDuration;
        private System.Windows.Forms.Label labNumberOfMonths;
        private System.Windows.Forms.Label labRepaymentPeriodicity;
        private System.Windows.Forms.Label labResult;
        private System.Windows.Forms.ErrorProvider errorProviderName;
        private System.Windows.Forms.ErrorProvider errorProviderCapital;
    }
}

