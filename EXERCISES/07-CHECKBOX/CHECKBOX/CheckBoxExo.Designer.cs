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
            this.gbxChoice = new System.Windows.Forms.GroupBox();
            this.cbBackgroundColor = new System.Windows.Forms.CheckBox();
            this.cbFontColor = new System.Windows.Forms.CheckBox();
            this.cbCase = new System.Windows.Forms.CheckBox();
            this.gbxBackgroundColor = new System.Windows.Forms.GroupBox();
            this.radioButtonBgRed = new System.Windows.Forms.RadioButton();
            this.radioButtonBgGreen = new System.Windows.Forms.RadioButton();
            this.radioButtonBgBlue = new System.Windows.Forms.RadioButton();
            this.gbxFontColor = new System.Windows.Forms.GroupBox();
            this.radioButtonFontColorRed = new System.Windows.Forms.RadioButton();
            this.radioButtonFontColorWhite = new System.Windows.Forms.RadioButton();
            this.radioButtonFontColorBlack = new System.Windows.Forms.RadioButton();
            this.gbxCase = new System.Windows.Forms.GroupBox();
            this.radioButtonLowerCase = new System.Windows.Forms.RadioButton();
            this.radioButtonUpperCase = new System.Windows.Forms.RadioButton();
            this.labInput = new System.Windows.Forms.Label();
            this.labOutput = new System.Windows.Forms.Label();
            this.gbxChoice.SuspendLayout();
            this.gbxBackgroundColor.SuspendLayout();
            this.gbxFontColor.SuspendLayout();
            this.gbxCase.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(30, 31);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(255, 20);
            this.tbInput.TabIndex = 0;
            this.tbInput.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // gbxChoice
            // 
            this.gbxChoice.Controls.Add(this.cbCase);
            this.gbxChoice.Controls.Add(this.cbFontColor);
            this.gbxChoice.Controls.Add(this.cbBackgroundColor);
            this.gbxChoice.Enabled = false;
            this.gbxChoice.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.gbxChoice.Location = new System.Drawing.Point(308, 13);
            this.gbxChoice.Name = "gbxChoice";
            this.gbxChoice.Size = new System.Drawing.Size(135, 92);
            this.gbxChoice.TabIndex = 1;
            this.gbxChoice.TabStop = false;
            this.gbxChoice.Text = "Choices";
            // 
            // cbBackgroundColor
            // 
            this.cbBackgroundColor.AutoSize = true;
            this.cbBackgroundColor.Checked = true;
            this.cbBackgroundColor.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbBackgroundColor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbBackgroundColor.Location = new System.Drawing.Point(15, 21);
            this.cbBackgroundColor.Name = "cbBackgroundColor";
            this.cbBackgroundColor.Size = new System.Drawing.Size(110, 17);
            this.cbBackgroundColor.TabIndex = 0;
            this.cbBackgroundColor.Text = "Background color";
            this.cbBackgroundColor.UseVisualStyleBackColor = true;
            // 
            // cbFontColor
            // 
            this.cbFontColor.AutoSize = true;
            this.cbFontColor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbFontColor.Location = new System.Drawing.Point(15, 44);
            this.cbFontColor.Name = "cbFontColor";
            this.cbFontColor.Size = new System.Drawing.Size(73, 17);
            this.cbFontColor.TabIndex = 1;
            this.cbFontColor.Text = "Font color";
            this.cbFontColor.UseVisualStyleBackColor = true;
            // 
            // cbCase
            // 
            this.cbCase.AutoSize = true;
            this.cbCase.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbCase.Location = new System.Drawing.Point(15, 67);
            this.cbCase.Name = "cbCase";
            this.cbCase.Size = new System.Drawing.Size(50, 17);
            this.cbCase.TabIndex = 2;
            this.cbCase.Text = "Case";
            this.cbCase.UseVisualStyleBackColor = true;
            // 
            // gbxBackgroundColor
            // 
            this.gbxBackgroundColor.Controls.Add(this.radioButtonBgBlue);
            this.gbxBackgroundColor.Controls.Add(this.radioButtonBgGreen);
            this.gbxBackgroundColor.Controls.Add(this.radioButtonBgRed);
            this.gbxBackgroundColor.Enabled = false;
            this.gbxBackgroundColor.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.gbxBackgroundColor.Location = new System.Drawing.Point(30, 127);
            this.gbxBackgroundColor.Name = "gbxBackgroundColor";
            this.gbxBackgroundColor.Size = new System.Drawing.Size(94, 100);
            this.gbxBackgroundColor.TabIndex = 2;
            this.gbxBackgroundColor.TabStop = false;
            this.gbxBackgroundColor.Text = "Background";
            this.gbxBackgroundColor.Visible = false;
            // 
            // radioButtonBgRed
            // 
            this.radioButtonBgRed.AutoSize = true;
            this.radioButtonBgRed.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButtonBgRed.Location = new System.Drawing.Point(13, 21);
            this.radioButtonBgRed.Name = "radioButtonBgRed";
            this.radioButtonBgRed.Size = new System.Drawing.Size(45, 17);
            this.radioButtonBgRed.TabIndex = 0;
            this.radioButtonBgRed.TabStop = true;
            this.radioButtonBgRed.Text = "Red";
            this.radioButtonBgRed.UseVisualStyleBackColor = true;
            // 
            // radioButtonBgGreen
            // 
            this.radioButtonBgGreen.AutoSize = true;
            this.radioButtonBgGreen.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButtonBgGreen.Location = new System.Drawing.Point(13, 45);
            this.radioButtonBgGreen.Name = "radioButtonBgGreen";
            this.radioButtonBgGreen.Size = new System.Drawing.Size(54, 17);
            this.radioButtonBgGreen.TabIndex = 1;
            this.radioButtonBgGreen.TabStop = true;
            this.radioButtonBgGreen.Text = "Green";
            this.radioButtonBgGreen.UseVisualStyleBackColor = true;
            // 
            // radioButtonBgBlue
            // 
            this.radioButtonBgBlue.AutoSize = true;
            this.radioButtonBgBlue.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButtonBgBlue.Location = new System.Drawing.Point(13, 69);
            this.radioButtonBgBlue.Name = "radioButtonBgBlue";
            this.radioButtonBgBlue.Size = new System.Drawing.Size(46, 17);
            this.radioButtonBgBlue.TabIndex = 2;
            this.radioButtonBgBlue.TabStop = true;
            this.radioButtonBgBlue.Text = "Blue";
            this.radioButtonBgBlue.UseVisualStyleBackColor = true;
            // 
            // gbxFontColor
            // 
            this.gbxFontColor.Controls.Add(this.radioButtonFontColorBlack);
            this.gbxFontColor.Controls.Add(this.radioButtonFontColorWhite);
            this.gbxFontColor.Controls.Add(this.radioButtonFontColorRed);
            this.gbxFontColor.Enabled = false;
            this.gbxFontColor.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.gbxFontColor.Location = new System.Drawing.Point(130, 127);
            this.gbxFontColor.Name = "gbxFontColor";
            this.gbxFontColor.Size = new System.Drawing.Size(94, 100);
            this.gbxFontColor.TabIndex = 3;
            this.gbxFontColor.TabStop = false;
            this.gbxFontColor.Text = "Font";
            this.gbxFontColor.Visible = false;
            // 
            // radioButtonFontColorRed
            // 
            this.radioButtonFontColorRed.AutoSize = true;
            this.radioButtonFontColorRed.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButtonFontColorRed.Location = new System.Drawing.Point(15, 21);
            this.radioButtonFontColorRed.Name = "radioButtonFontColorRed";
            this.radioButtonFontColorRed.Size = new System.Drawing.Size(45, 17);
            this.radioButtonFontColorRed.TabIndex = 0;
            this.radioButtonFontColorRed.TabStop = true;
            this.radioButtonFontColorRed.Text = "Red";
            this.radioButtonFontColorRed.UseVisualStyleBackColor = true;
            // 
            // radioButtonFontColorWhite
            // 
            this.radioButtonFontColorWhite.AutoSize = true;
            this.radioButtonFontColorWhite.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButtonFontColorWhite.Location = new System.Drawing.Point(15, 45);
            this.radioButtonFontColorWhite.Name = "radioButtonFontColorWhite";
            this.radioButtonFontColorWhite.Size = new System.Drawing.Size(53, 17);
            this.radioButtonFontColorWhite.TabIndex = 1;
            this.radioButtonFontColorWhite.TabStop = true;
            this.radioButtonFontColorWhite.Text = "White";
            this.radioButtonFontColorWhite.UseVisualStyleBackColor = true;
            // 
            // radioButtonFontColorBlack
            // 
            this.radioButtonFontColorBlack.AutoSize = true;
            this.radioButtonFontColorBlack.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButtonFontColorBlack.Location = new System.Drawing.Point(15, 69);
            this.radioButtonFontColorBlack.Name = "radioButtonFontColorBlack";
            this.radioButtonFontColorBlack.Size = new System.Drawing.Size(52, 17);
            this.radioButtonFontColorBlack.TabIndex = 2;
            this.radioButtonFontColorBlack.TabStop = true;
            this.radioButtonFontColorBlack.Text = "Black";
            this.radioButtonFontColorBlack.UseVisualStyleBackColor = true;
            // 
            // gbxCase
            // 
            this.gbxCase.Controls.Add(this.radioButtonUpperCase);
            this.gbxCase.Controls.Add(this.radioButtonLowerCase);
            this.gbxCase.Enabled = false;
            this.gbxCase.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.gbxCase.Location = new System.Drawing.Point(230, 152);
            this.gbxCase.Name = "gbxCase";
            this.gbxCase.Size = new System.Drawing.Size(104, 75);
            this.gbxCase.TabIndex = 4;
            this.gbxCase.TabStop = false;
            this.gbxCase.Text = "Case";
            this.gbxCase.Visible = false;
            // 
            // radioButtonLowerCase
            // 
            this.radioButtonLowerCase.AutoSize = true;
            this.radioButtonLowerCase.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButtonLowerCase.Location = new System.Drawing.Point(14, 21);
            this.radioButtonLowerCase.Name = "radioButtonLowerCase";
            this.radioButtonLowerCase.Size = new System.Drawing.Size(80, 17);
            this.radioButtonLowerCase.TabIndex = 0;
            this.radioButtonLowerCase.TabStop = true;
            this.radioButtonLowerCase.Text = "Lower case";
            this.radioButtonLowerCase.UseVisualStyleBackColor = true;
            // 
            // radioButtonUpperCase
            // 
            this.radioButtonUpperCase.AutoSize = true;
            this.radioButtonUpperCase.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButtonUpperCase.Location = new System.Drawing.Point(14, 45);
            this.radioButtonUpperCase.Name = "radioButtonUpperCase";
            this.radioButtonUpperCase.Size = new System.Drawing.Size(80, 17);
            this.radioButtonUpperCase.TabIndex = 1;
            this.radioButtonUpperCase.TabStop = true;
            this.radioButtonUpperCase.Text = "Upper case";
            this.radioButtonUpperCase.UseVisualStyleBackColor = true;
            // 
            // labInput
            // 
            this.labInput.AutoSize = true;
            this.labInput.Location = new System.Drawing.Point(30, 13);
            this.labInput.Name = "labInput";
            this.labInput.Size = new System.Drawing.Size(76, 13);
            this.labInput.TabIndex = 5;
            this.labInput.Text = "Insert your text";
            // 
            // labOutput
            // 
            this.labOutput.AutoSize = true;
            this.labOutput.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labOutput.Location = new System.Drawing.Point(30, 85);
            this.labOutput.MaximumSize = new System.Drawing.Size(255, 20);
            this.labOutput.MinimumSize = new System.Drawing.Size(255, 20);
            this.labOutput.Name = "labOutput";
            this.labOutput.Size = new System.Drawing.Size(255, 20);
            this.labOutput.TabIndex = 6;
            this.labOutput.Visible = false;
            // 
            // CheckBoxExo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 257);
            this.Controls.Add(this.labOutput);
            this.Controls.Add(this.labInput);
            this.Controls.Add(this.gbxCase);
            this.Controls.Add(this.gbxFontColor);
            this.Controls.Add(this.gbxBackgroundColor);
            this.Controls.Add(this.gbxChoice);
            this.Controls.Add(this.tbInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CheckBoxExo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckBox & RadioButton";
            this.gbxChoice.ResumeLayout(false);
            this.gbxChoice.PerformLayout();
            this.gbxBackgroundColor.ResumeLayout(false);
            this.gbxBackgroundColor.PerformLayout();
            this.gbxFontColor.ResumeLayout(false);
            this.gbxFontColor.PerformLayout();
            this.gbxCase.ResumeLayout(false);
            this.gbxCase.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.GroupBox gbxChoice;
        private System.Windows.Forms.CheckBox cbCase;
        private System.Windows.Forms.CheckBox cbFontColor;
        private System.Windows.Forms.CheckBox cbBackgroundColor;
        private System.Windows.Forms.GroupBox gbxBackgroundColor;
        private System.Windows.Forms.RadioButton radioButtonBgBlue;
        private System.Windows.Forms.RadioButton radioButtonBgGreen;
        private System.Windows.Forms.RadioButton radioButtonBgRed;
        private System.Windows.Forms.GroupBox gbxFontColor;
        private System.Windows.Forms.RadioButton radioButtonFontColorBlack;
        private System.Windows.Forms.RadioButton radioButtonFontColorWhite;
        private System.Windows.Forms.RadioButton radioButtonFontColorRed;
        private System.Windows.Forms.GroupBox gbxCase;
        private System.Windows.Forms.RadioButton radioButtonUpperCase;
        private System.Windows.Forms.RadioButton radioButtonLowerCase;
        private System.Windows.Forms.Label labInput;
        private System.Windows.Forms.Label labOutput;
    }
}

