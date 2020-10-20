namespace LISTBOX
{
    partial class ListBoxExo
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
            this.tbNewElement = new System.Windows.Forms.TextBox();
            this.btnAddFirstName = new System.Windows.Forms.Button();
            this.tbIndexElement = new System.Windows.Forms.TextBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnEmptyList = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.tbItemsCount = new System.Windows.Forms.TextBox();
            this.tbSelectedIndex = new System.Windows.Forms.TextBox();
            this.tbText = new System.Windows.Forms.TextBox();
            this.labelNewFirstName = new System.Windows.Forms.Label();
            this.labelFirstNameIndex = new System.Windows.Forms.Label();
            this.labelFirstNameList = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelCount = new System.Windows.Forms.Label();
            this.labelSelectedIndex = new System.Windows.Forms.Label();
            this.labelText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbNewElement
            // 
            this.tbNewElement.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNewElement.Location = new System.Drawing.Point(27, 44);
            this.tbNewElement.MinimumSize = new System.Drawing.Size(12, 30);
            this.tbNewElement.Name = "tbNewElement";
            this.tbNewElement.Size = new System.Drawing.Size(138, 22);
            this.tbNewElement.TabIndex = 0;
            this.tbNewElement.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // btnAddFirstName
            // 
            this.btnAddFirstName.Enabled = false;
            this.btnAddFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFirstName.Location = new System.Drawing.Point(27, 92);
            this.btnAddFirstName.MinimumSize = new System.Drawing.Size(0, 30);
            this.btnAddFirstName.Name = "btnAddFirstName";
            this.btnAddFirstName.Size = new System.Drawing.Size(138, 30);
            this.btnAddFirstName.TabIndex = 1;
            this.btnAddFirstName.Text = "Add first name";
            this.btnAddFirstName.UseVisualStyleBackColor = true;
            this.btnAddFirstName.Click += new System.EventHandler(this.Button_Click);
            // 
            // tbIndexElement
            // 
            this.tbIndexElement.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIndexElement.Location = new System.Drawing.Point(233, 44);
            this.tbIndexElement.MinimumSize = new System.Drawing.Size(12, 30);
            this.tbIndexElement.Name = "tbIndexElement";
            this.tbIndexElement.Size = new System.Drawing.Size(56, 22);
            this.tbIndexElement.TabIndex = 2;
            this.tbIndexElement.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // btnSelect
            // 
            this.btnSelect.Enabled = false;
            this.btnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.Location = new System.Drawing.Point(295, 44);
            this.btnSelect.MinimumSize = new System.Drawing.Size(0, 30);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(146, 30);
            this.btnSelect.TabIndex = 3;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnEmptyList
            // 
            this.btnEmptyList.Enabled = false;
            this.btnEmptyList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmptyList.Location = new System.Drawing.Point(295, 92);
            this.btnEmptyList.MinimumSize = new System.Drawing.Size(0, 30);
            this.btnEmptyList.Name = "btnEmptyList";
            this.btnEmptyList.Size = new System.Drawing.Size(146, 30);
            this.btnEmptyList.TabIndex = 4;
            this.btnEmptyList.Text = "Empty list";
            this.btnEmptyList.UseVisualStyleBackColor = true;
            this.btnEmptyList.Click += new System.EventHandler(this.Button_Click);
            // 
            // listBox
            // 
            this.listBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 16;
            this.listBox.Location = new System.Drawing.Point(27, 180);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(138, 100);
            this.listBox.TabIndex = 5;
            // 
            // tbItemsCount
            // 
            this.tbItemsCount.Enabled = false;
            this.tbItemsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbItemsCount.Location = new System.Drawing.Point(346, 178);
            this.tbItemsCount.MinimumSize = new System.Drawing.Size(12, 30);
            this.tbItemsCount.Name = "tbItemsCount";
            this.tbItemsCount.Size = new System.Drawing.Size(46, 22);
            this.tbItemsCount.TabIndex = 6;
            // 
            // tbSelectedIndex
            // 
            this.tbSelectedIndex.Enabled = false;
            this.tbSelectedIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSelectedIndex.Location = new System.Drawing.Point(346, 216);
            this.tbSelectedIndex.MinimumSize = new System.Drawing.Size(12, 30);
            this.tbSelectedIndex.Name = "tbSelectedIndex";
            this.tbSelectedIndex.Size = new System.Drawing.Size(46, 22);
            this.tbSelectedIndex.TabIndex = 7;
            // 
            // tbText
            // 
            this.tbText.Enabled = false;
            this.tbText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbText.Location = new System.Drawing.Point(346, 252);
            this.tbText.MinimumSize = new System.Drawing.Size(12, 30);
            this.tbText.Name = "tbText";
            this.tbText.Size = new System.Drawing.Size(100, 22);
            this.tbText.TabIndex = 8;
            // 
            // labelNewFirstName
            // 
            this.labelNewFirstName.AutoSize = true;
            this.labelNewFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNewFirstName.Location = new System.Drawing.Point(27, 17);
            this.labelNewFirstName.Name = "labelNewFirstName";
            this.labelNewFirstName.Size = new System.Drawing.Size(109, 16);
            this.labelNewFirstName.TabIndex = 9;
            this.labelNewFirstName.Text = "New first name";
            // 
            // labelFirstNameIndex
            // 
            this.labelFirstNameIndex.AutoSize = true;
            this.labelFirstNameIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFirstNameIndex.Location = new System.Drawing.Point(232, 16);
            this.labelFirstNameIndex.Name = "labelFirstNameIndex";
            this.labelFirstNameIndex.Size = new System.Drawing.Size(121, 16);
            this.labelFirstNameIndex.TabIndex = 10;
            this.labelFirstNameIndex.Text = "First name index";
            // 
            // labelFirstNameList
            // 
            this.labelFirstNameList.AutoSize = true;
            this.labelFirstNameList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFirstNameList.Location = new System.Drawing.Point(27, 150);
            this.labelFirstNameList.Name = "labelFirstNameList";
            this.labelFirstNameList.Size = new System.Drawing.Size(104, 16);
            this.labelFirstNameList.TabIndex = 11;
            this.labelFirstNameList.Text = "First name list";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(232, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Properties";
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCount.Location = new System.Drawing.Point(232, 181);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(77, 16);
            this.labelCount.TabIndex = 13;
            this.labelCount.Text = "Items.Count";
            // 
            // labelSelectedIndex
            // 
            this.labelSelectedIndex.AutoSize = true;
            this.labelSelectedIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectedIndex.Location = new System.Drawing.Point(232, 219);
            this.labelSelectedIndex.Name = "labelSelectedIndex";
            this.labelSelectedIndex.Size = new System.Drawing.Size(94, 16);
            this.labelSelectedIndex.TabIndex = 14;
            this.labelSelectedIndex.Text = "SelectedIndex";
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelText.Location = new System.Drawing.Point(232, 255);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(34, 16);
            this.labelText.TabIndex = 15;
            this.labelText.Text = "Text";
            // 
            // ListBoxExo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 307);
            this.Controls.Add(this.labelText);
            this.Controls.Add(this.labelSelectedIndex);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelFirstNameList);
            this.Controls.Add(this.labelFirstNameIndex);
            this.Controls.Add(this.labelNewFirstName);
            this.Controls.Add(this.tbText);
            this.Controls.Add(this.tbSelectedIndex);
            this.Controls.Add(this.tbItemsCount);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.btnEmptyList);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.tbIndexElement);
            this.Controls.Add(this.btnAddFirstName);
            this.Controls.Add(this.tbNewElement);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ListBoxExo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lists and their properties";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNewElement;
        private System.Windows.Forms.Button btnAddFirstName;
        private System.Windows.Forms.TextBox tbIndexElement;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnEmptyList;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.TextBox tbItemsCount;
        private System.Windows.Forms.TextBox tbSelectedIndex;
        private System.Windows.Forms.TextBox tbText;
        private System.Windows.Forms.Label labelNewFirstName;
        private System.Windows.Forms.Label labelFirstNameIndex;
        private System.Windows.Forms.Label labelFirstNameList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Label labelSelectedIndex;
        private System.Windows.Forms.Label labelText;
    }
}

