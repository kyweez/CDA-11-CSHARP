namespace ComboBoxApp
{
    partial class ComboBoxApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComboBoxApp));
            this.cbSource = new System.Windows.Forms.ComboBox();
            this.btnRightShift = new System.Windows.Forms.Button();
            this.btnRightShiftAll = new System.Windows.Forms.Button();
            this.btnLeftShift = new System.Windows.Forms.Button();
            this.btnLeftShiftAll = new System.Windows.Forms.Button();
            this.lbTarget = new System.Windows.Forms.ListBox();
            this.btnMoveUp = new System.Windows.Forms.Button();
            this.btnMoveDown = new System.Windows.Forms.Button();
            this.labSource = new System.Windows.Forms.Label();
            this.labTarget = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // cbSource
            // 
            this.cbSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSource.FormattingEnabled = true;
            this.cbSource.Location = new System.Drawing.Point(23, 48);
            this.cbSource.Name = "cbSource";
            this.cbSource.Size = new System.Drawing.Size(208, 24);
            this.cbSource.TabIndex = 0;
            this.cbSource.TextChanged += new System.EventHandler(this.CbSource_TextChanged);
            // 
            // btnRightShift
            // 
            this.btnRightShift.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRightShift.Location = new System.Drawing.Point(308, 48);
            this.btnRightShift.Name = "btnRightShift";
            this.btnRightShift.Size = new System.Drawing.Size(64, 36);
            this.btnRightShift.TabIndex = 1;
            this.btnRightShift.Text = ">";
            this.btnRightShift.UseVisualStyleBackColor = true;
            this.btnRightShift.Click += new System.EventHandler(this.BtnRightShift_Click);
            // 
            // btnRightShiftAll
            // 
            this.btnRightShiftAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRightShiftAll.Location = new System.Drawing.Point(308, 90);
            this.btnRightShiftAll.Name = "btnRightShiftAll";
            this.btnRightShiftAll.Size = new System.Drawing.Size(64, 36);
            this.btnRightShiftAll.TabIndex = 2;
            this.btnRightShiftAll.Text = ">>";
            this.btnRightShiftAll.UseVisualStyleBackColor = true;
            this.btnRightShiftAll.Click += new System.EventHandler(this.BtnRightShiftAll_Click);
            // 
            // btnLeftShift
            // 
            this.btnLeftShift.Enabled = false;
            this.btnLeftShift.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeftShift.Location = new System.Drawing.Point(308, 156);
            this.btnLeftShift.Name = "btnLeftShift";
            this.btnLeftShift.Size = new System.Drawing.Size(64, 36);
            this.btnLeftShift.TabIndex = 3;
            this.btnLeftShift.Text = "<";
            this.btnLeftShift.UseVisualStyleBackColor = true;
            this.btnLeftShift.Click += new System.EventHandler(this.BtnLeftShift_Click);
            // 
            // btnLeftShiftAll
            // 
            this.btnLeftShiftAll.Enabled = false;
            this.btnLeftShiftAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeftShiftAll.Location = new System.Drawing.Point(308, 198);
            this.btnLeftShiftAll.Name = "btnLeftShiftAll";
            this.btnLeftShiftAll.Size = new System.Drawing.Size(64, 36);
            this.btnLeftShiftAll.TabIndex = 4;
            this.btnLeftShiftAll.Text = "<<";
            this.btnLeftShiftAll.UseVisualStyleBackColor = true;
            this.btnLeftShiftAll.Click += new System.EventHandler(this.BtnLeftShiftAll_Click);
            // 
            // lbTarget
            // 
            this.lbTarget.Enabled = false;
            this.lbTarget.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTarget.FormattingEnabled = true;
            this.lbTarget.ItemHeight = 16;
            this.lbTarget.Location = new System.Drawing.Point(445, 48);
            this.lbTarget.Name = "lbTarget";
            this.lbTarget.Size = new System.Drawing.Size(203, 180);
            this.lbTarget.TabIndex = 5;
            // 
            // btnMoveUp
            // 
            this.btnMoveUp.Enabled = false;
            this.btnMoveUp.Image = ((System.Drawing.Image)(resources.GetObject("btnMoveUp.Image")));
            this.btnMoveUp.Location = new System.Drawing.Point(499, 250);
            this.btnMoveUp.Name = "btnMoveUp";
            this.btnMoveUp.Size = new System.Drawing.Size(40, 40);
            this.btnMoveUp.TabIndex = 6;
            this.btnMoveUp.UseVisualStyleBackColor = true;
            // 
            // btnMoveDown
            // 
            this.btnMoveDown.Enabled = false;
            this.btnMoveDown.Image = ((System.Drawing.Image)(resources.GetObject("btnMoveDown.Image")));
            this.btnMoveDown.Location = new System.Drawing.Point(556, 250);
            this.btnMoveDown.Name = "btnMoveDown";
            this.btnMoveDown.Size = new System.Drawing.Size(40, 40);
            this.btnMoveDown.TabIndex = 7;
            this.btnMoveDown.UseVisualStyleBackColor = true;
            // 
            // labSource
            // 
            this.labSource.AutoSize = true;
            this.labSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSource.Location = new System.Drawing.Point(22, 14);
            this.labSource.Name = "labSource";
            this.labSource.Size = new System.Drawing.Size(66, 20);
            this.labSource.TabIndex = 8;
            this.labSource.Text = "Source";
            // 
            // labTarget
            // 
            this.labTarget.AutoSize = true;
            this.labTarget.Enabled = false;
            this.labTarget.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTarget.Location = new System.Drawing.Point(441, 14);
            this.labTarget.Name = "labTarget";
            this.labTarget.Size = new System.Drawing.Size(61, 20);
            this.labTarget.TabIndex = 9;
            this.labTarget.Text = "Target";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // ComboBoxApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 315);
            this.Controls.Add(this.labTarget);
            this.Controls.Add(this.labSource);
            this.Controls.Add(this.btnMoveDown);
            this.Controls.Add(this.btnMoveUp);
            this.Controls.Add(this.lbTarget);
            this.Controls.Add(this.btnLeftShiftAll);
            this.Controls.Add(this.btnLeftShift);
            this.Controls.Add(this.btnRightShiftAll);
            this.Controls.Add(this.btnRightShift);
            this.Controls.Add(this.cbSource);
            this.Name = "ComboBoxApp";
            this.Text = "ComboBox & ListBox";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbSource;
        private System.Windows.Forms.Button btnRightShift;
        private System.Windows.Forms.Button btnRightShiftAll;
        private System.Windows.Forms.Button btnLeftShift;
        private System.Windows.Forms.Button btnLeftShiftAll;
        private System.Windows.Forms.ListBox lbTarget;
        private System.Windows.Forms.Button btnMoveUp;
        private System.Windows.Forms.Button btnMoveDown;
        private System.Windows.Forms.Label labSource;
        private System.Windows.Forms.Label labTarget;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}

