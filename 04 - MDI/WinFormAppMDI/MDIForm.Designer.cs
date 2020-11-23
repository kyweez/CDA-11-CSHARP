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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.connectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consoleApplicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.butterflyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zooToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firstStepsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inputValidationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.version1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.version2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graphicalObjectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scrollingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.version1ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.vesrion2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.version1ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.version2ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.version1ToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.version2ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.loanToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.version1ToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.version2ToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.coursesExercisesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fractionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.temperatureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.version1ToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.version2ToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectionToolStripMenuItem,
            this.consoleApplicationsToolStripMenuItem,
            this.firstStepsToolStripMenuItem,
            this.inputValidationToolStripMenuItem,
            this.graphicalObjectsToolStripMenuItem,
            this.coursesExercisesToolStripMenuItem,
            this.windowsToolStripMenuItem});
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
            this.logInToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.logInToolStripMenuItem.Text = "Log in";
            this.logInToolStripMenuItem.Click += new System.EventHandler(this.Login_Click);
            // 
            // disconnectToolStripMenuItem
            // 
            this.disconnectToolStripMenuItem.Enabled = false;
            this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
            this.disconnectToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.disconnectToolStripMenuItem.Text = "Disconnect";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // consoleApplicationsToolStripMenuItem
            // 
            this.consoleApplicationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.butterflyToolStripMenuItem,
            this.zooToolStripMenuItem,
            this.forestToolStripMenuItem});
            this.consoleApplicationsToolStripMenuItem.Enabled = false;
            this.consoleApplicationsToolStripMenuItem.Name = "consoleApplicationsToolStripMenuItem";
            this.consoleApplicationsToolStripMenuItem.Size = new System.Drawing.Size(129, 20);
            this.consoleApplicationsToolStripMenuItem.Text = "Console applications";
            // 
            // butterflyToolStripMenuItem
            // 
            this.butterflyToolStripMenuItem.Name = "butterflyToolStripMenuItem";
            this.butterflyToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.butterflyToolStripMenuItem.Text = "Butterfly";
            // 
            // zooToolStripMenuItem
            // 
            this.zooToolStripMenuItem.Name = "zooToolStripMenuItem";
            this.zooToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.zooToolStripMenuItem.Text = "Zoo";
            // 
            // forestToolStripMenuItem
            // 
            this.forestToolStripMenuItem.Name = "forestToolStripMenuItem";
            this.forestToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.forestToolStripMenuItem.Text = "Forest";
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
            // 
            // inputValidationToolStripMenuItem
            // 
            this.inputValidationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.version1ToolStripMenuItem,
            this.version2ToolStripMenuItem});
            this.inputValidationToolStripMenuItem.Enabled = false;
            this.inputValidationToolStripMenuItem.Name = "inputValidationToolStripMenuItem";
            this.inputValidationToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.inputValidationToolStripMenuItem.Text = "Input validation";
            // 
            // version1ToolStripMenuItem
            // 
            this.version1ToolStripMenuItem.Name = "version1ToolStripMenuItem";
            this.version1ToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.version1ToolStripMenuItem.Text = "Version 1";
            // 
            // version2ToolStripMenuItem
            // 
            this.version2ToolStripMenuItem.Name = "version2ToolStripMenuItem";
            this.version2ToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.version2ToolStripMenuItem.Text = "Version 2";
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
            // 
            // listBoxToolStripMenuItem
            // 
            this.listBoxToolStripMenuItem.Name = "listBoxToolStripMenuItem";
            this.listBoxToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.listBoxToolStripMenuItem.Text = "List box";
            // 
            // comboBoxToolStripMenuItem
            // 
            this.comboBoxToolStripMenuItem.Name = "comboBoxToolStripMenuItem";
            this.comboBoxToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.comboBoxToolStripMenuItem.Text = "Combo box";
            // 
            // scrollingToolStripMenuItem
            // 
            this.scrollingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.version1ToolStripMenuItem1,
            this.vesrion2ToolStripMenuItem});
            this.scrollingToolStripMenuItem.Name = "scrollingToolStripMenuItem";
            this.scrollingToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.scrollingToolStripMenuItem.Text = "Scrolling";
            // 
            // version1ToolStripMenuItem1
            // 
            this.version1ToolStripMenuItem1.Name = "version1ToolStripMenuItem1";
            this.version1ToolStripMenuItem1.Size = new System.Drawing.Size(121, 22);
            this.version1ToolStripMenuItem1.Text = "Version 1";
            // 
            // vesrion2ToolStripMenuItem
            // 
            this.vesrion2ToolStripMenuItem.Name = "vesrion2ToolStripMenuItem";
            this.vesrion2ToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.vesrion2ToolStripMenuItem.Text = "Vesrion 2";
            // 
            // loanToolStripMenuItem
            // 
            this.loanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.version1ToolStripMenuItem2,
            this.version2ToolStripMenuItem1});
            this.loanToolStripMenuItem.Name = "loanToolStripMenuItem";
            this.loanToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.loanToolStripMenuItem.Text = "Loan";
            // 
            // version1ToolStripMenuItem2
            // 
            this.version1ToolStripMenuItem2.Name = "version1ToolStripMenuItem2";
            this.version1ToolStripMenuItem2.Size = new System.Drawing.Size(121, 22);
            this.version1ToolStripMenuItem2.Text = "Version 1";
            // 
            // version2ToolStripMenuItem1
            // 
            this.version2ToolStripMenuItem1.Name = "version2ToolStripMenuItem1";
            this.version2ToolStripMenuItem1.Size = new System.Drawing.Size(121, 22);
            this.version2ToolStripMenuItem1.Text = "Version 2";
            // 
            // windowsToolStripMenuItem
            // 
            this.windowsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cascadeToolStripMenuItem,
            this.horizontalToolStripMenuItem,
            this.verticalToolStripMenuItem});
            this.windowsToolStripMenuItem.Enabled = false;
            this.windowsToolStripMenuItem.Name = "windowsToolStripMenuItem";
            this.windowsToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.windowsToolStripMenuItem.Text = "Windows";
            // 
            // cascadeToolStripMenuItem
            // 
            this.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            this.cascadeToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.cascadeToolStripMenuItem.Text = "Cascade";
            // 
            // horizontalToolStripMenuItem
            // 
            this.horizontalToolStripMenuItem.Name = "horizontalToolStripMenuItem";
            this.horizontalToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.horizontalToolStripMenuItem.Text = "Horizontal";
            // 
            // verticalToolStripMenuItem
            // 
            this.verticalToolStripMenuItem.Name = "verticalToolStripMenuItem";
            this.verticalToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.verticalToolStripMenuItem.Text = "Vertical";
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
            this.version1ToolStripMenuItem3,
            this.version2ToolStripMenuItem2});
            this.scrollingToolStripMenuItem1.Name = "scrollingToolStripMenuItem1";
            this.scrollingToolStripMenuItem1.Size = new System.Drawing.Size(137, 22);
            this.scrollingToolStripMenuItem1.Text = "Scrolling";
            // 
            // version1ToolStripMenuItem3
            // 
            this.version1ToolStripMenuItem3.Name = "version1ToolStripMenuItem3";
            this.version1ToolStripMenuItem3.Size = new System.Drawing.Size(121, 22);
            this.version1ToolStripMenuItem3.Text = "Version 1";
            // 
            // version2ToolStripMenuItem2
            // 
            this.version2ToolStripMenuItem2.Name = "version2ToolStripMenuItem2";
            this.version2ToolStripMenuItem2.Size = new System.Drawing.Size(121, 22);
            this.version2ToolStripMenuItem2.Text = "Version 2";
            // 
            // loanToolStripMenuItem1
            // 
            this.loanToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.version1ToolStripMenuItem4,
            this.version2ToolStripMenuItem3});
            this.loanToolStripMenuItem1.Name = "loanToolStripMenuItem1";
            this.loanToolStripMenuItem1.Size = new System.Drawing.Size(137, 22);
            this.loanToolStripMenuItem1.Text = "Loan";
            // 
            // version1ToolStripMenuItem4
            // 
            this.version1ToolStripMenuItem4.Name = "version1ToolStripMenuItem4";
            this.version1ToolStripMenuItem4.Size = new System.Drawing.Size(121, 22);
            this.version1ToolStripMenuItem4.Text = "Version 1";
            // 
            // version2ToolStripMenuItem3
            // 
            this.version2ToolStripMenuItem3.Name = "version2ToolStripMenuItem3";
            this.version2ToolStripMenuItem3.Size = new System.Drawing.Size(121, 22);
            this.version2ToolStripMenuItem3.Text = "Version 2";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 600);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1122, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(74, 17);
            this.toolStripStatusLabel1.Text = "Current Date";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(92, 17);
            this.toolStripStatusLabel2.Text = "Last Application";
            // 
            // coursesExercisesToolStripMenuItem
            // 
            this.coursesExercisesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fractionToolStripMenuItem,
            this.eventsToolStripMenuItem,
            this.temperatureToolStripMenuItem});
            this.coursesExercisesToolStripMenuItem.Enabled = false;
            this.coursesExercisesToolStripMenuItem.Name = "coursesExercisesToolStripMenuItem";
            this.coursesExercisesToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.coursesExercisesToolStripMenuItem.Text = "Courses exercises";
            // 
            // fractionToolStripMenuItem
            // 
            this.fractionToolStripMenuItem.Name = "fractionToolStripMenuItem";
            this.fractionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fractionToolStripMenuItem.Text = "Fraction";
            // 
            // eventsToolStripMenuItem
            // 
            this.eventsToolStripMenuItem.Name = "eventsToolStripMenuItem";
            this.eventsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eventsToolStripMenuItem.Text = "Events";
            // 
            // temperatureToolStripMenuItem
            // 
            this.temperatureToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.version1ToolStripMenuItem5,
            this.version2ToolStripMenuItem4});
            this.temperatureToolStripMenuItem.Name = "temperatureToolStripMenuItem";
            this.temperatureToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.temperatureToolStripMenuItem.Text = "Temperature";
            // 
            // version1ToolStripMenuItem5
            // 
            this.version1ToolStripMenuItem5.Name = "version1ToolStripMenuItem5";
            this.version1ToolStripMenuItem5.Size = new System.Drawing.Size(180, 22);
            this.version1ToolStripMenuItem5.Text = "Version 1";
            // 
            // version2ToolStripMenuItem4
            // 
            this.version2ToolStripMenuItem4.Name = "version2ToolStripMenuItem4";
            this.version2ToolStripMenuItem4.Size = new System.Drawing.Size(180, 22);
            this.version2ToolStripMenuItem4.Text = "Version 2";
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
        private System.Windows.Forms.ToolStripMenuItem consoleApplicationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem firstStepsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inputValidationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graphicalObjectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem butterflyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zooToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem version1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem version2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comboBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scrollingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem version1ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem vesrion2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem version1ToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem version2ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verticalToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton toolStripButtonLogin;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButtonLastItem;
        private System.Windows.Forms.ToolStripMenuItem checkBoxToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listBoxToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem comboBoxToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem scrollingToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem version1ToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem version2ToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem loanToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem version1ToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem version2ToolStripMenuItem3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coursesExercisesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fractionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem temperatureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem version1ToolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem version2ToolStripMenuItem4;
    }
}

