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
            this.closeAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDisplaySeparator = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonLogin = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSplitButtonGraphicalObjects = new System.Windows.Forms.ToolStripSplitButton();
            this.stripCheckBox = new System.Windows.Forms.ToolStripMenuItem();
            this.stripListBox = new System.Windows.Forms.ToolStripMenuItem();
            this.stripComboBox = new System.Windows.Forms.ToolStripMenuItem();
            this.stripScrolling = new System.Windows.Forms.ToolStripMenuItem();
            this.stripLoan = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelCurrentDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelLastApplication = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerStatusBar = new System.Windows.Forms.Timer(this.components);
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
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
            this.menuStrip.MdiWindowListItem = this.displayToolStripMenuItem;
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
            this.logInToolStripMenuItem.Click += new System.EventHandler(this.LoginLogout_Click);
            // 
            // disconnectToolStripMenuItem
            // 
            this.disconnectToolStripMenuItem.Enabled = false;
            this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
            this.disconnectToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.disconnectToolStripMenuItem.Text = "Disconnect";
            this.disconnectToolStripMenuItem.Click += new System.EventHandler(this.DisconnectToolStripMenuItem_Click);
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
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.QuitToolStripMenuItem_Click);
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
            this.calculatorToolStripMenuItem.Click += new System.EventHandler(this.Calculator_Click);
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
            this.inputValidationV1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.inputValidationV1ToolStripMenuItem.Text = "Input validation v1";
            this.inputValidationV1ToolStripMenuItem.Click += new System.EventHandler(this.InputValidationV1_Click);
            // 
            // inputValidationV2ToolStripMenuItem
            // 
            this.inputValidationV2ToolStripMenuItem.Name = "inputValidationV2ToolStripMenuItem";
            this.inputValidationV2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.inputValidationV2ToolStripMenuItem.Text = "Input validation v2";
            this.inputValidationV2ToolStripMenuItem.Click += new System.EventHandler(this.InputValidationV2_Click);
            // 
            // graphicalObjectsToolStripMenuItem
            // 
            this.graphicalObjectsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkBoxToolStripMenuItem,
            this.listBoxToolStripMenuItem,
            this.comboBoxToolStripMenuItem,
            this.scrollingToolStripMenuItem,
            this.toolStripSeparator3,
            this.loanToolStripMenuItem});
            this.graphicalObjectsToolStripMenuItem.Enabled = false;
            this.graphicalObjectsToolStripMenuItem.Name = "graphicalObjectsToolStripMenuItem";
            this.graphicalObjectsToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.graphicalObjectsToolStripMenuItem.Text = "Graphical objects";
            // 
            // checkBoxToolStripMenuItem
            // 
            this.checkBoxToolStripMenuItem.Name = "checkBoxToolStripMenuItem";
            this.checkBoxToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.checkBoxToolStripMenuItem.Text = "Check box";
            this.checkBoxToolStripMenuItem.Click += new System.EventHandler(this.CheckBox_Click);
            // 
            // listBoxToolStripMenuItem
            // 
            this.listBoxToolStripMenuItem.Name = "listBoxToolStripMenuItem";
            this.listBoxToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listBoxToolStripMenuItem.Text = "List box";
            this.listBoxToolStripMenuItem.Click += new System.EventHandler(this.ListBox_Click);
            // 
            // comboBoxToolStripMenuItem
            // 
            this.comboBoxToolStripMenuItem.Name = "comboBoxToolStripMenuItem";
            this.comboBoxToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.comboBoxToolStripMenuItem.Text = "Combo box";
            this.comboBoxToolStripMenuItem.Click += new System.EventHandler(this.ComboBox_Click);
            // 
            // scrollingToolStripMenuItem
            // 
            this.scrollingToolStripMenuItem.Name = "scrollingToolStripMenuItem";
            this.scrollingToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.scrollingToolStripMenuItem.Text = "Scrolling";
            this.scrollingToolStripMenuItem.Click += new System.EventHandler(this.Scrolling_Click);
            // 
            // loanToolStripMenuItem
            // 
            this.loanToolStripMenuItem.Name = "loanToolStripMenuItem";
            this.loanToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loanToolStripMenuItem.Text = "Loan";
            this.loanToolStripMenuItem.Click += new System.EventHandler(this.Loan_Click);
            // 
            // displayToolStripMenuItem
            // 
            this.displayToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cascadeToolStripMenuItem,
            this.horizontalToolStripMenuItem,
            this.verticalToolStripMenuItem,
            this.closeAllToolStripMenuItem,
            this.toolStripDisplaySeparator});
            this.displayToolStripMenuItem.Enabled = false;
            this.displayToolStripMenuItem.Name = "displayToolStripMenuItem";
            this.displayToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.displayToolStripMenuItem.Text = "Display";
            // 
            // cascadeToolStripMenuItem
            // 
            this.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            this.cascadeToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.cascadeToolStripMenuItem.Text = "Cascade";
            this.cascadeToolStripMenuItem.Click += new System.EventHandler(this.CascadeToolStripMenuItem_Click);
            // 
            // horizontalToolStripMenuItem
            // 
            this.horizontalToolStripMenuItem.Name = "horizontalToolStripMenuItem";
            this.horizontalToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.horizontalToolStripMenuItem.Text = "Horizontal";
            this.horizontalToolStripMenuItem.Click += new System.EventHandler(this.HorizontalToolStripMenuItem_Click);
            // 
            // verticalToolStripMenuItem
            // 
            this.verticalToolStripMenuItem.Name = "verticalToolStripMenuItem";
            this.verticalToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.verticalToolStripMenuItem.Text = "Vertical";
            this.verticalToolStripMenuItem.Click += new System.EventHandler(this.VerticalToolStripMenuItem_Click);
            // 
            // closeAllToolStripMenuItem
            // 
            this.closeAllToolStripMenuItem.Name = "closeAllToolStripMenuItem";
            this.closeAllToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.closeAllToolStripMenuItem.Text = "Close all";
            this.closeAllToolStripMenuItem.Click += new System.EventHandler(this.CloseAllToolStripMenuItem_Click);
            // 
            // toolStripDisplaySeparator
            // 
            this.toolStripDisplaySeparator.Name = "toolStripDisplaySeparator";
            this.toolStripDisplaySeparator.Size = new System.Drawing.Size(126, 6);
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonLogin,
            this.toolStripSeparator2,
            this.toolStripSplitButtonGraphicalObjects});
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
            this.toolStripButtonLogin.Click += new System.EventHandler(this.LoginLogout_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSplitButtonGraphicalObjects
            // 
            this.toolStripSplitButtonGraphicalObjects.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButtonGraphicalObjects.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripCheckBox,
            this.stripListBox,
            this.stripComboBox,
            this.stripScrolling,
            this.toolStripSeparator4,
            this.stripLoan});
            this.toolStripSplitButtonGraphicalObjects.Enabled = false;
            this.toolStripSplitButtonGraphicalObjects.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButtonGraphicalObjects.Name = "toolStripSplitButtonGraphicalObjects";
            this.toolStripSplitButtonGraphicalObjects.Size = new System.Drawing.Size(114, 22);
            this.toolStripSplitButtonGraphicalObjects.Text = "Graphical objects";
            this.toolStripSplitButtonGraphicalObjects.Visible = false;
            this.toolStripSplitButtonGraphicalObjects.ButtonClick += new System.EventHandler(this.ToolStripSplitButtonLastItem_ButtonClick);
            // 
            // stripCheckBox
            // 
            this.stripCheckBox.Name = "stripCheckBox";
            this.stripCheckBox.Size = new System.Drawing.Size(180, 22);
            this.stripCheckBox.Text = "Check box";
            this.stripCheckBox.Click += new System.EventHandler(this.CheckBox_Click);
            // 
            // stripListBox
            // 
            this.stripListBox.Name = "stripListBox";
            this.stripListBox.Size = new System.Drawing.Size(180, 22);
            this.stripListBox.Text = "List box";
            this.stripListBox.Click += new System.EventHandler(this.ListBox_Click);
            // 
            // stripComboBox
            // 
            this.stripComboBox.Name = "stripComboBox";
            this.stripComboBox.Size = new System.Drawing.Size(180, 22);
            this.stripComboBox.Text = "Combo box";
            this.stripComboBox.Click += new System.EventHandler(this.ComboBox_Click);
            // 
            // stripScrolling
            // 
            this.stripScrolling.Name = "stripScrolling";
            this.stripScrolling.Size = new System.Drawing.Size(180, 22);
            this.stripScrolling.Text = "Scrolling";
            this.stripScrolling.Click += new System.EventHandler(this.Scrolling_Click);
            // 
            // stripLoan
            // 
            this.stripLoan.Name = "stripLoan";
            this.stripLoan.Size = new System.Drawing.Size(180, 22);
            this.stripLoan.Text = "Loan";
            this.stripLoan.Click += new System.EventHandler(this.Loan_Click);
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
            this.timerStatusBar.Interval = 500;
            this.timerStatusBar.Tick += new System.EventHandler(this.TimerStatusBar_Tick);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(177, 6);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(177, 6);
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
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButtonGraphicalObjects;
        private System.Windows.Forms.ToolStripMenuItem stripCheckBox;
        private System.Windows.Forms.ToolStripMenuItem stripListBox;
        private System.Windows.Forms.ToolStripMenuItem stripComboBox;
        private System.Windows.Forms.ToolStripMenuItem stripScrolling;
        private System.Windows.Forms.ToolStripMenuItem stripLoan;
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
        private System.Windows.Forms.ToolStripMenuItem closeAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripDisplaySeparator;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    }
}