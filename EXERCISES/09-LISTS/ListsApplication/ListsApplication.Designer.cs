namespace ListsApplication
{
    partial class ListsApplication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListsApplication));
            this.comboBoxSource = new System.Windows.Forms.ComboBox();
            this.btnShiftRight = new System.Windows.Forms.Button();
            this.btnShiftRightAll = new System.Windows.Forms.Button();
            this.btnShiftLeft = new System.Windows.Forms.Button();
            this.btnShiftLeftAll = new System.Windows.Forms.Button();
            this.listBoxTarget = new System.Windows.Forms.ListBox();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.labelSource = new System.Windows.Forms.Label();
            this.labelTarget = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxSource
            // 
            this.comboBoxSource.FormattingEnabled = true;
            this.comboBoxSource.Location = new System.Drawing.Point(13, 45);
            this.comboBoxSource.Name = "comboBoxSource";
            this.comboBoxSource.Size = new System.Drawing.Size(215, 21);
            this.comboBoxSource.Sorted = true;
            this.comboBoxSource.TabIndex = 0;
            this.comboBoxSource.SelectedIndexChanged += new System.EventHandler(this.ComboBoxSource_SelectedIndexChanged);
            this.comboBoxSource.TextChanged += new System.EventHandler(this.ComboBoxSource_TextChanged);
            this.comboBoxSource.Click += new System.EventHandler(this.ComboBoxSource_Click);
            // 
            // btnShiftRight
            // 
            this.btnShiftRight.Enabled = false;
            this.btnShiftRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShiftRight.Location = new System.Drawing.Point(285, 45);
            this.btnShiftRight.Name = "btnShiftRight";
            this.btnShiftRight.Size = new System.Drawing.Size(75, 32);
            this.btnShiftRight.TabIndex = 1;
            this.btnShiftRight.Text = ">";
            this.btnShiftRight.UseVisualStyleBackColor = true;
            this.btnShiftRight.Click += new System.EventHandler(this.BtnShiftRight_Click);
            // 
            // btnShiftRightAll
            // 
            this.btnShiftRightAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShiftRightAll.Location = new System.Drawing.Point(285, 83);
            this.btnShiftRightAll.Name = "btnShiftRightAll";
            this.btnShiftRightAll.Size = new System.Drawing.Size(75, 32);
            this.btnShiftRightAll.TabIndex = 2;
            this.btnShiftRightAll.Text = ">>";
            this.btnShiftRightAll.UseVisualStyleBackColor = true;
            this.btnShiftRightAll.Click += new System.EventHandler(this.BtnShiftRightAll_Click);
            // 
            // btnShiftLeft
            // 
            this.btnShiftLeft.Enabled = false;
            this.btnShiftLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShiftLeft.Location = new System.Drawing.Point(285, 187);
            this.btnShiftLeft.Name = "btnShiftLeft";
            this.btnShiftLeft.Size = new System.Drawing.Size(75, 32);
            this.btnShiftLeft.TabIndex = 3;
            this.btnShiftLeft.Text = "<";
            this.btnShiftLeft.UseVisualStyleBackColor = true;
            // 
            // btnShiftLeftAll
            // 
            this.btnShiftLeftAll.Enabled = false;
            this.btnShiftLeftAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShiftLeftAll.Location = new System.Drawing.Point(285, 225);
            this.btnShiftLeftAll.Name = "btnShiftLeftAll";
            this.btnShiftLeftAll.Size = new System.Drawing.Size(75, 32);
            this.btnShiftLeftAll.TabIndex = 4;
            this.btnShiftLeftAll.Text = "<<";
            this.btnShiftLeftAll.UseVisualStyleBackColor = true;
            this.btnShiftLeftAll.Click += new System.EventHandler(this.BtnShiftLeftAll_Click);
            // 
            // listBoxTarget
            // 
            this.listBoxTarget.Enabled = false;
            this.listBoxTarget.FormattingEnabled = true;
            this.listBoxTarget.Location = new System.Drawing.Point(403, 45);
            this.listBoxTarget.Name = "listBoxTarget";
            this.listBoxTarget.Size = new System.Drawing.Size(206, 212);
            this.listBoxTarget.TabIndex = 5;
            // 
            // btnUp
            // 
            this.btnUp.Enabled = false;
            this.btnUp.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUp.Image = ((System.Drawing.Image)(resources.GetObject("btnUp.Image")));
            this.btnUp.Location = new System.Drawing.Point(449, 263);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(42, 53);
            this.btnUp.TabIndex = 6;
            this.btnUp.UseVisualStyleBackColor = true;
            // 
            // btnDown
            // 
            this.btnDown.Enabled = false;
            this.btnDown.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDown.Image = ((System.Drawing.Image)(resources.GetObject("btnDown.Image")));
            this.btnDown.Location = new System.Drawing.Point(514, 263);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(42, 53);
            this.btnDown.TabIndex = 7;
            this.btnDown.UseVisualStyleBackColor = true;
            // 
            // labelSource
            // 
            this.labelSource.AutoSize = true;
            this.labelSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSource.Location = new System.Drawing.Point(13, 17);
            this.labelSource.Name = "labelSource";
            this.labelSource.Size = new System.Drawing.Size(60, 20);
            this.labelSource.TabIndex = 8;
            this.labelSource.Text = "Source";
            // 
            // labelTarget
            // 
            this.labelTarget.AutoSize = true;
            this.labelTarget.Enabled = false;
            this.labelTarget.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTarget.Location = new System.Drawing.Point(403, 16);
            this.labelTarget.Name = "labelTarget";
            this.labelTarget.Size = new System.Drawing.Size(55, 20);
            this.labelTarget.TabIndex = 9;
            this.labelTarget.Text = "Target";
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // ListsApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 362);
            this.Controls.Add(this.labelTarget);
            this.Controls.Add(this.labelSource);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.listBoxTarget);
            this.Controls.Add(this.btnShiftLeftAll);
            this.Controls.Add(this.btnShiftLeft);
            this.Controls.Add(this.btnShiftRightAll);
            this.Controls.Add(this.btnShiftRight);
            this.Controls.Add(this.comboBoxSource);
            this.Name = "ListsApplication";
            this.Text = "Lists";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxSource;
        private System.Windows.Forms.Button btnShiftRight;
        private System.Windows.Forms.Button btnShiftRightAll;
        private System.Windows.Forms.Button btnShiftLeft;
        private System.Windows.Forms.Button btnShiftLeftAll;
        private System.Windows.Forms.ListBox listBoxTarget;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Label labelSource;
        private System.Windows.Forms.Label labelTarget;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}

