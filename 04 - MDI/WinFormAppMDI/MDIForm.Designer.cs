namespace WinFormAppMDI
{
    partial class MDIForm
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.connectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firstStepsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inputValidationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inputValidationV1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inputValidationV2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graphicalObjectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scrollingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonLogin = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSplitButtonLastItem = new System.Windows.Forms.ToolStripSplitButton();
            this.checkBoxToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listBoxToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBoxToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.scrollingToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.version1InputValidationToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.version2InputValidationToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.loanToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.version1InputValidationToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.version2InputValidationToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelCurrentDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelLastApplication = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerStatusBar = new System.Windows.Forms.Timer(this.components);
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectionToolStripMenuItem,
            this.firstStepsToolStripMenuItem,
            this.inputValidationToolStripMenuItem,
            this.graphicalObjectsToolStripMenuItem,
            this.displayToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1122, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // connectionToolStripMenuItem
            // 
            this.connectionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logInToolStripMenuItem,
            this.disconnectToolStripMenuItem,
            this.toolStripSeparator1,
            this.quitToolStripMenuItem});
            this.connectionToolStripMenuItem.Name = "connectionToolStripMenuItem";
            this.connectionToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.connectionToolStripMenuItem.Text = "Connection";
            // 
            // logInToolStripMenuItem
            // 
            this.logInToolStripMenuItem.Name = "logInToolStripMenuItem";
            this.logInToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.logInToolStripMenuItem.Text = "Log in";
            this.logInToolStripMenuItem.Click += new System.EventHandler(this.Login_Click);
            // 
            // disconnectToolStripMenuItem
            // 
            this.disconnectToolStripMenuItem.Enabled = false;
            this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
            this.disconnectToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.disconnectToolStripMenuItem.Text = "Disconnect";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(130, 6);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // firstStepsToolStripMenuItem
            // 
            this.firstStepsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculatorToolStripMenuItem});
            this.firstStepsToolStripMenuItem.Enabled = false;
            this.firstStepsToolStripMenuItem.Name = "firstStepsToolStripMenuItem";
            this.firstStepsToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.firstStepsToolStripMenuItem.Text = "First steps";
            // 
            // calculatorToolStripMenuItem
            // 
            this.calculatorToolStripMenuItem.Name = "calculatorToolStripMenuItem";
            this.calculatorToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.calculatorToolStripMenuItem.Text = "Calculator";
            this.calculatorToolStripMenuItem.Click += new System.EventHandler(this.calculatorToolStripMenuItem_Click);
            // 
            // inputValidationToolStripMenuItem
            // 
            this.inputValidationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inputValidationV1ToolStripMenuItem,
            this.inputValidationV2ToolStripMenuItem});
            this.inputValidationToolStripMenuItem.Enabled = false;
            this.inputValidationToolStripMenuItem.Name = "inputValidationToolStripMenuItem";
            this.inputValidationToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.inputValidationToolStripMenuItem.Text = "Input validation";
            // 
            // inputValidationV1ToolStripMenuItem
            // 
            this.inputValidationV1ToolStripMenuItem.Name = "inputValidationV1ToolStripMenuItem";
            this.inputValidationV1ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.inputValidationV1ToolStripMenuItem.Text = "Input validation v1";
            this.inputValidationV1ToolStripMenuItem.Click += new System.EventHandler(this.inputValidationV1ToolStripMenuItem_Click);
            // 
            // inputValidationV2ToolStripMenuItem
            // 
            this.inputValidationV2ToolStripMenuItem.Name = "inputValidationV2ToolStripMenuItem";
            this.inputValidationV2ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.inputValidationV2ToolStripMenuItem.Text = "Input validation v2";
            this.inputValidationV2ToolStripMenuItem.Click += new System.EventHandler(this.inputValidationV2ToolStripMenuItem_Click);
            // 
            // graphicalObjectsToolStripMenuItem
            // 
            this.graphicalObjectsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkBoxToolStripMenuItem,
            this.listBoxToolStripMenuItem,
            this.comboBoxToolStripMenuItem,
            this.scrollingToolStripMenuItem,
            this.loanToolStripMenuItem});
            this.graphicalObjectsToolStripMenuItem.Enabled = false;
            this.graphicalObjectsToolStripMenuItem.Name = "graphicalObjectsToolStripMenuItem";
            this.graphicalObjectsToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.graphicalObjectsToolStripMenuItem.Text = "Graphical objects";
            // 
            // checkBoxToolStripMenuItem
            // 
            this.checkBoxToolStripMenuItem.Name = "checkBoxToolStripMenuItem";
            this.checkBoxToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.checkBoxToolStripMenuItem.Text = "Check box";
            this.checkBoxToolStripMenuItem.Click += new System.EventHandler(this.checkBoxToolStripMenuItem_Click);
            // 
            // listBoxToolStripMenuItem
            // 
            this.listBoxToolStripMenuItem.Name = "listBoxToolStripMenuItem";
            this.listBoxToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.listBoxToolStripMenuItem.Text = "List box";
            this.listBoxToolStripMenuItem.Click += new System.EventHandler(this.listBoxToolStripMenuItem_Click);
            // 
            // comboBoxToolStripMenuItem
            // 
            this.comboBoxToolStripMenuItem.Name = "comboBoxToolStripMenuItem";
            this.comboBoxToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.comboBoxToolStripMenuItem.Text = "Combo box";
            this.comboBoxToolStripMenuItem.Click += new System.EventHandler(this.comboBoxToolStripMenuItem_Click);
            // 
            // scrollingToolStripMenuItem
            // 
            this.scrollingToolStripMenuItem.Name = "scrollingToolStripMenuItem";
            this.scrollingToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.scrollingToolStripMenuItem.Text = "Scrolling";
            this.scrollingToolStripMenuItem.Click += new System.EventHandler(this.scrollingToolStripMenuItem_Click);
            // 
            // loanToolStripMenuItem
            // 
            this.loanToolStripMenuItem.Name = "loanToolStripMenuItem";
            this.loanToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.loanToolStripMenuItem.Text = "Loan";
            this.loanToolStripMenuItem.Click += new System.EventHandler(this.loanToolStripMenuItem_Click);
            // 
            // displayToolStripMenuItem
            // 
            this.displayToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cascadeToolStripMenuItem,
            this.horizontalToolStripMenuItem,
            this.verticalToolStripMenuItem});
            this.displayToolStripMenuItem.Enabled = false;
            this.displayToolStripMenuItem.Name = "displayToolStripMenuItem";
            this.displayToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.displayToolStripMenuItem.Text = "Display";
            // 
            // cascadeToolStripMenuItem
            // 
            this.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            this.cascadeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cascadeToolStripMenuItem.Text = "Cascade";
            this.cascadeToolStripMenuItem.Click += new System.EventHandler(this.cascadeToolStripMenuItem_Click);
            // 
            // horizontalToolStripMenuItem
            // 
            this.horizontalToolStripMenuItem.Name = "horizontalToolStripMenuItem";
            this.horizontalToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.horizontalToolStripMenuItem.Text = "Horizontal";
            this.horizontalToolStripMenuItem.Click += new System.EventHandler(this.horizontalToolStripMenuItem_Click);
            // 
            // verticalToolStripMenuItem
            // 
            this.verticalToolStripMenuItem.Name = "verticalToolStripMenuItem";
            this.verticalToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.verticalToolStripMenuItem.Text = "Vertical";
            this.verticalToolStripMenuItem.Click += new System.EventHandler(this.verticalToolStripMenuItem_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonLogin,
            this.toolStripSeparator2,
            this.toolStripSplitButtonLastItem});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1122, 25);
            this.toolStrip.TabIndex = 3;
            this.toolStrip.Text = "toolStrip1";
            // 
            // toolStripButtonLogin
            // 
            this.toolStripButtonLogin.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonLogin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonLogin.Name = "toolStripButtonLogin";
            this.toolStripButtonLogin.Size = new System.Drawing.Size(44, 22);
            this.toolStripButtonLogin.Text = "Log in";
            this.toolStripButtonLogin.Click += new System.EventHandler(this.Login_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSplitButtonLastItem
            // 
            this.toolStripSplitButtonLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButtonLastItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkBoxToolStripMenuItem1,
            this.listBoxToolStripMenuItem1,
            this.comboBoxToolStripMenuItem1,
            this.scrollingToolStripMenuItem1,
            this.loanToolStripMenuItem1});
            this.toolStripSplitButtonLastItem.Enabled = false;
            this.toolStripSplitButtonLastItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButtonLastItem.Name = "toolStripSplitButtonLastItem";
            this.toolStripSplitButtonLastItem.Size = new System.Drawing.Size(114, 22);
            this.toolStripSplitButtonLastItem.Text = "Graphical objects";
            this.toolStripSplitButtonLastItem.Visible = false;
            // 
            // checkBoxToolStripMenuItem1
            // 
            this.checkBoxToolStripMenuItem1.Name = "checkBoxToolStripMenuItem1";
            this.checkBoxToolStripMenuItem1.Size = new System.Drawing.Size(137, 22);
            this.checkBoxToolStripMenuItem1.Text = "Check box";
            // 
            // listBoxToolStripMenuItem1
            // 
            this.listBoxToolStripMenuItem1.Name = "listBoxToolStripMenuItem1";
            this.listBoxToolStripMenuItem1.Size = new System.Drawing.Size(137, 22);
            this.listBoxToolStripMenuItem1.Text = "List box";
            // 
            // comboBoxToolStripMenuItem1
            // 
            this.comboBoxToolStripMenuItem1.Name = "comboBoxToolStripMenuItem1";
            this.comboBoxToolStripMenuItem1.Size = new System.Drawing.Size(137, 22);
            this.comboBoxToolStripMenuItem1.Text = "Combo box";
            // 
            // scrollingToolStripMenuItem1
            // 
            this.scrollingToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.version1InputValidationToolStripMenuItem3,
            this.version2InputValidationToolStripMenuItem2});
            this.scrollingToolStripMenuItem1.Name = "scrollingToolStripMenuItem1";
            this.scrollingToolStripMenuItem1.Size = new System.Drawing.Size(137, 22);
            this.scrollingToolStripMenuItem1.Text = "Scrolling";
            // 
            // version1InputValidationToolStripMenuItem3
            // 
            this.version1InputValidationToolStripMenuItem3.Name = "version1InputValidationToolStripMenuItem3";
            this.version1InputValidationToolStripMenuItem3.Size = new System.Drawing.Size(121, 22);
            this.version1InputValidationToolStripMenuItem3.Text = "Version 1";
            // 
            // version2InputValidationToolStripMenuItem2
            // 
            this.version2InputValidationToolStripMenuItem2.Name = "version2InputValidationToolStripMenuItem2";
            this.version2InputValidationToolStripMenuItem2.Size = new System.Drawing.Size(121, 22);
            this.version2InputValidationToolStripMenuItem2.Text = "Version 2";
            // 
            // loanToolStripMenuItem1
            // 
            this.loanToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.version1InputValidationToolStripMenuItem4,
            this.version2InputValidationToolStripMenuItem3});
            this.loanToolStripMenuItem1.Name = "loanToolStripMenuItem1";
            this.loanToolStripMenuItem1.Size = new System.Drawing.Size(137, 22);
            this.loanToolStripMenuItem1.Text = "Loan";
            // 
            // version1InputValidationToolStripMenuItem4
            // 
            this.version1InputValidationToolStripMenuItem4.Name = "version1InputValidationToolStripMenuItem4";
            this.version1InputValidationToolStripMenuItem4.Size = new System.Drawing.Size(121, 22);
            this.version1InputValidationToolStripMenuItem4.Text = "Version 1";
            // 
            // version2InputValidationToolStripMenuItem3
            // 
            this.version2InputValidationToolStripMenuItem3.Name = "version2InputValidationToolStripMenuItem3";
            this.version2InputValidationToolStripMenuItem3.Size = new System.Drawing.Size(121, 22);
            this.version2InputValidationToolStripMenuItem3.Text = "Version 2";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelCurrentDate,
            this.toolStripStatusLabelLastApplication});
            this.statusStrip1.Location = new System.Drawing.Point(0, 600);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1122, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelCurrentDate
            // 
            this.toolStripStatusLabelCurrentDate.Name = "toolStripStatusLabelCurrentDate";
            this.toolStripStatusLabelCurrentDate.Size = new System.Drawing.Size(74, 17);
            this.toolStripStatusLabelCurrentDate.Text = "Current Date";
            // 
            // toolStripStatusLabelLastApplication
            // 
            this.toolStripStatusLabelLastApplication.Name = "toolStripStatusLabelLastApplication";
            this.toolStripStatusLabelLastApplication.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.toolStripStatusLabelLastApplication.Size = new System.Drawing.Size(112, 17);
            this.toolStripStatusLabelLastApplication.Text = "Last Application";
            this.toolStripStatusLabelLastApplication.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timerStatusBar
            // 
            this.timerStatusBar.Interval = 1000;
            this.timerStatusBar.Tick += new System.EventHandler(this.timerStatusBar_Tick);
            // 
            // MDIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 622);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "MDIForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create forms";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem connectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton toolStripButtonLogin;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButtonLastItem;
        private System.Windows.Forms.ToolStripMenuItem checkBoxToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listBoxToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem comboBoxToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem scrollingToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem version1InputValidationToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem version2InputValidationToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem loanToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem version1InputValidationToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem version2InputValidationToolStripMenuItem3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelCurrentDate;
        private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem;
        private System.Windows.Forms.Timer timerStatusBar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelLastApplication;
        private System.Windows.Forms.ToolStripMenuItem firstStepsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inputValidationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inputValidationV1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inputValidationV2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graphicalObjectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comboBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scrollingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verticalToolStripMenuItem;
    }
}

