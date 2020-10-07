namespace INPUT_VALIDATION
{
    partial class Controles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Controles));
            this.labelName = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelAmount = new System.Windows.Forms.Label();
            this.labelZipCode = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.textZipCode = new System.Windows.Forms.TextBox();
            this.textAmount = new System.Windows.Forms.TextBox();
            this.textDate = new System.Windows.Forms.TextBox();
            this.labelDateTip = new System.Windows.Forms.Label();
            this.buttonValidate = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelName
            // 
            resources.ApplyResources(this.labelName, "labelName");
            this.labelName.Name = "labelName";
            // 
            // labelDate
            // 
            resources.ApplyResources(this.labelDate, "labelDate");
            this.labelDate.Name = "labelDate";
            // 
            // labelAmount
            // 
            resources.ApplyResources(this.labelAmount, "labelAmount");
            this.labelAmount.Name = "labelAmount";
            // 
            // labelZipCode
            // 
            resources.ApplyResources(this.labelZipCode, "labelZipCode");
            this.labelZipCode.Name = "labelZipCode";
            // 
            // textName
            // 
            resources.ApplyResources(this.textName, "textName");
            this.textName.Name = "textName";
            // 
            // textZipCode
            // 
            resources.ApplyResources(this.textZipCode, "textZipCode");
            this.textZipCode.Name = "textZipCode";
            // 
            // textAmount
            // 
            resources.ApplyResources(this.textAmount, "textAmount");
            this.textAmount.Name = "textAmount";
            // 
            // textDate
            // 
            resources.ApplyResources(this.textDate, "textDate");
            this.textDate.Name = "textDate";
            // 
            // labelDateTip
            // 
            resources.ApplyResources(this.labelDateTip, "labelDateTip");
            this.labelDateTip.Name = "labelDateTip";
            // 
            // buttonValidate
            // 
            resources.ApplyResources(this.buttonValidate, "buttonValidate");
            this.buttonValidate.Name = "buttonValidate";
            this.buttonValidate.UseVisualStyleBackColor = true;
            this.buttonValidate.Click += new System.EventHandler(this.buttonValidate_Click);
            // 
            // buttonReset
            // 
            resources.ApplyResources(this.buttonReset, "buttonReset");
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // Controles
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonValidate);
            this.Controls.Add(this.labelDateTip);
            this.Controls.Add(this.textDate);
            this.Controls.Add(this.textAmount);
            this.Controls.Add(this.textZipCode);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.labelZipCode);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Controles";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.Label labelZipCode;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textZipCode;
        private System.Windows.Forms.TextBox textAmount;
        private System.Windows.Forms.TextBox textDate;
        private System.Windows.Forms.Label labelDateTip;
        private System.Windows.Forms.Button buttonValidate;
        private System.Windows.Forms.Button buttonReset;
    }
}