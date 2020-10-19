namespace CHECKBOX
{
    partial class CheckBoxExo
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
            this.tbInput = new System.Windows.Forms.TextBox();
            this.groupBoxChoice = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(30, 54);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(254, 20);
            this.tbInput.TabIndex = 0;
            // 
            // groupBoxChoice
            // 
            this.groupBoxChoice.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBoxChoice.Location = new System.Drawing.Point(350, 31);
            this.groupBoxChoice.Name = "groupBoxChoice";
            this.groupBoxChoice.Size = new System.Drawing.Size(200, 100);
            this.groupBoxChoice.TabIndex = 1;
            this.groupBoxChoice.TabStop = false;
            this.groupBoxChoice.Text = "Choices";
            // 
            // CheckBoxExo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxChoice);
            this.Controls.Add(this.tbInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CheckBoxExo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckBox & RadioButton";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.GroupBox groupBoxChoice;
    }
}

