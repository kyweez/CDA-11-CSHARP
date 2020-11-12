namespace WinFormAppScrolling_v1
{
    partial class ScrollingForm1
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
            this.numericUpDownRed = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownGreen = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownBlue = new System.Windows.Forms.NumericUpDown();
            this.hsRed = new System.Windows.Forms.HScrollBar();
            this.hsGreen = new System.Windows.Forms.HScrollBar();
            this.hsBlue = new System.Windows.Forms.HScrollBar();
            this.labRed = new System.Windows.Forms.Label();
            this.labGreen = new System.Windows.Forms.Label();
            this.labBlue = new System.Windows.Forms.Label();
            this.textBoxRed = new System.Windows.Forms.TextBox();
            this.textBoxGreen = new System.Windows.Forms.TextBox();
            this.textBoxBlue = new System.Windows.Forms.TextBox();
            this.textBoxColor = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBlue)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownRed
            // 
            this.numericUpDownRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownRed.Location = new System.Drawing.Point(342, 27);
            this.numericUpDownRed.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownRed.Name = "numericUpDownRed";
            this.numericUpDownRed.Size = new System.Drawing.Size(50, 26);
            this.numericUpDownRed.TabIndex = 0;
            this.numericUpDownRed.ValueChanged += new System.EventHandler(this.NumericUpDownRed_ValueChanged);
            // 
            // numericUpDownGreen
            // 
            this.numericUpDownGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownGreen.Location = new System.Drawing.Point(342, 76);
            this.numericUpDownGreen.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownGreen.Name = "numericUpDownGreen";
            this.numericUpDownGreen.Size = new System.Drawing.Size(50, 26);
            this.numericUpDownGreen.TabIndex = 1;
            this.numericUpDownGreen.ValueChanged += new System.EventHandler(this.NumericUpDownGreen_ValueChanged);
            // 
            // numericUpDownBlue
            // 
            this.numericUpDownBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownBlue.Location = new System.Drawing.Point(342, 127);
            this.numericUpDownBlue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownBlue.Name = "numericUpDownBlue";
            this.numericUpDownBlue.Size = new System.Drawing.Size(50, 26);
            this.numericUpDownBlue.TabIndex = 2;
            this.numericUpDownBlue.ValueChanged += new System.EventHandler(this.NumericUpDownBlue_ValueChanged);
            // 
            // hsRed
            // 
            this.hsRed.Location = new System.Drawing.Point(111, 27);
            this.hsRed.Maximum = 264;
            this.hsRed.Name = "hsRed";
            this.hsRed.Size = new System.Drawing.Size(210, 26);
            this.hsRed.TabIndex = 3;
            this.hsRed.ValueChanged += new System.EventHandler(this.HsRed_ValueChanged);
            // 
            // hsGreen
            // 
            this.hsGreen.Location = new System.Drawing.Point(111, 76);
            this.hsGreen.Maximum = 264;
            this.hsGreen.Name = "hsGreen";
            this.hsGreen.Size = new System.Drawing.Size(210, 26);
            this.hsGreen.TabIndex = 4;
            this.hsGreen.ValueChanged += new System.EventHandler(this.HsGreen_ValueChanged);
            // 
            // hsBlue
            // 
            this.hsBlue.Location = new System.Drawing.Point(111, 127);
            this.hsBlue.Maximum = 264;
            this.hsBlue.Name = "hsBlue";
            this.hsBlue.Size = new System.Drawing.Size(210, 26);
            this.hsBlue.TabIndex = 5;
            this.hsBlue.ValueChanged += new System.EventHandler(this.HsBlue_ValueChanged);
            // 
            // labRed
            // 
            this.labRed.AutoSize = true;
            this.labRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labRed.Location = new System.Drawing.Point(12, 33);
            this.labRed.Name = "labRed";
            this.labRed.Size = new System.Drawing.Size(42, 20);
            this.labRed.TabIndex = 6;
            this.labRed.Text = "Red";
            // 
            // labGreen
            // 
            this.labGreen.AutoSize = true;
            this.labGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labGreen.Location = new System.Drawing.Point(12, 82);
            this.labGreen.Name = "labGreen";
            this.labGreen.Size = new System.Drawing.Size(59, 20);
            this.labGreen.TabIndex = 7;
            this.labGreen.Text = "Green";
            // 
            // labBlue
            // 
            this.labBlue.AutoSize = true;
            this.labBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labBlue.Location = new System.Drawing.Point(12, 133);
            this.labBlue.Name = "labBlue";
            this.labBlue.Size = new System.Drawing.Size(45, 20);
            this.labBlue.TabIndex = 8;
            this.labBlue.Text = "Blue";
            // 
            // textBoxRed
            // 
            this.textBoxRed.BackColor = System.Drawing.Color.Red;
            this.textBoxRed.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRed.Enabled = false;
            this.textBoxRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRed.Location = new System.Drawing.Point(422, 27);
            this.textBoxRed.Name = "textBoxRed";
            this.textBoxRed.Size = new System.Drawing.Size(57, 19);
            this.textBoxRed.TabIndex = 9;
            // 
            // textBoxGreen
            // 
            this.textBoxGreen.BackColor = System.Drawing.Color.Green;
            this.textBoxGreen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxGreen.Enabled = false;
            this.textBoxGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGreen.Location = new System.Drawing.Point(422, 76);
            this.textBoxGreen.Name = "textBoxGreen";
            this.textBoxGreen.Size = new System.Drawing.Size(57, 19);
            this.textBoxGreen.TabIndex = 10;
            // 
            // textBoxBlue
            // 
            this.textBoxBlue.BackColor = System.Drawing.Color.Blue;
            this.textBoxBlue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxBlue.Enabled = false;
            this.textBoxBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBlue.Location = new System.Drawing.Point(422, 127);
            this.textBoxBlue.Name = "textBoxBlue";
            this.textBoxBlue.Size = new System.Drawing.Size(57, 19);
            this.textBoxBlue.TabIndex = 11;
            // 
            // textBoxColor
            // 
            this.textBoxColor.BackColor = System.Drawing.Color.Black;
            this.textBoxColor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxColor.Enabled = false;
            this.textBoxColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxColor.Location = new System.Drawing.Point(111, 184);
            this.textBoxColor.MinimumSize = new System.Drawing.Size(4, 80);
            this.textBoxColor.Name = "textBoxColor";
            this.textBoxColor.Size = new System.Drawing.Size(368, 55);
            this.textBoxColor.TabIndex = 12;
            // 
            // Scrolling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(509, 290);
            this.Controls.Add(this.textBoxColor);
            this.Controls.Add(this.textBoxBlue);
            this.Controls.Add(this.textBoxGreen);
            this.Controls.Add(this.textBoxRed);
            this.Controls.Add(this.labBlue);
            this.Controls.Add(this.labGreen);
            this.Controls.Add(this.labRed);
            this.Controls.Add(this.hsBlue);
            this.Controls.Add(this.hsGreen);
            this.Controls.Add(this.hsRed);
            this.Controls.Add(this.numericUpDownBlue);
            this.Controls.Add(this.numericUpDownGreen);
            this.Controls.Add(this.numericUpDownRed);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Scrolling";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Color Picker";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBlue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownRed;
        private System.Windows.Forms.NumericUpDown numericUpDownGreen;
        private System.Windows.Forms.NumericUpDown numericUpDownBlue;
        private System.Windows.Forms.HScrollBar hsGreen;
        private System.Windows.Forms.HScrollBar hsBlue;
        private System.Windows.Forms.Label labRed;
        private System.Windows.Forms.Label labGreen;
        private System.Windows.Forms.Label labBlue;
        private System.Windows.Forms.TextBox textBoxRed;
        private System.Windows.Forms.TextBox textBoxGreen;
        private System.Windows.Forms.TextBox textBoxBlue;
        private System.Windows.Forms.TextBox textBoxColor;
        private System.Windows.Forms.HScrollBar hsRed;
    }
}