namespace LoanApp_v2
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
            this.btnCreateClient = new System.Windows.Forms.Button();
            this.btnCreateLoan = new System.Windows.Forms.Button();
            this.btnModifyLoan = new System.Windows.Forms.Button();
            this.btnModifyClient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreateClient
            // 
            this.btnCreateClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnCreateClient.Location = new System.Drawing.Point(19, 19);
            this.btnCreateClient.Margin = new System.Windows.Forms.Padding(10);
            this.btnCreateClient.Name = "btnCreateClient";
            this.btnCreateClient.Size = new System.Drawing.Size(119, 39);
            this.btnCreateClient.TabIndex = 0;
            this.btnCreateClient.Text = "Create client";
            this.btnCreateClient.UseVisualStyleBackColor = true;
            this.btnCreateClient.Click += new System.EventHandler(this.btnCreateClient_Click);
            // 
            // btnCreateLoan
            // 
            this.btnCreateLoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnCreateLoan.Location = new System.Drawing.Point(19, 78);
            this.btnCreateLoan.Margin = new System.Windows.Forms.Padding(10);
            this.btnCreateLoan.Name = "btnCreateLoan";
            this.btnCreateLoan.Size = new System.Drawing.Size(119, 39);
            this.btnCreateLoan.TabIndex = 1;
            this.btnCreateLoan.Text = "Create loan";
            this.btnCreateLoan.UseVisualStyleBackColor = true;
            // 
            // btnModifyLoan
            // 
            this.btnModifyLoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnModifyLoan.Location = new System.Drawing.Point(158, 78);
            this.btnModifyLoan.Margin = new System.Windows.Forms.Padding(10);
            this.btnModifyLoan.Name = "btnModifyLoan";
            this.btnModifyLoan.Size = new System.Drawing.Size(119, 39);
            this.btnModifyLoan.TabIndex = 3;
            this.btnModifyLoan.Text = "Modify loan";
            this.btnModifyLoan.UseVisualStyleBackColor = true;
            // 
            // btnModifyClient
            // 
            this.btnModifyClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnModifyClient.Location = new System.Drawing.Point(158, 19);
            this.btnModifyClient.Margin = new System.Windows.Forms.Padding(10);
            this.btnModifyClient.Name = "btnModifyClient";
            this.btnModifyClient.Size = new System.Drawing.Size(119, 39);
            this.btnModifyClient.TabIndex = 2;
            this.btnModifyClient.Text = "Modify client";
            this.btnModifyClient.UseVisualStyleBackColor = true;
            // 
            // LoanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 134);
            this.Controls.Add(this.btnModifyLoan);
            this.Controls.Add(this.btnModifyClient);
            this.Controls.Add(this.btnCreateLoan);
            this.Controls.Add(this.btnCreateClient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "LoanForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loan Application";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreateClient;
        private System.Windows.Forms.Button btnCreateLoan;
        private System.Windows.Forms.Button btnModifyLoan;
        private System.Windows.Forms.Button btnModifyClient;
    }
}

