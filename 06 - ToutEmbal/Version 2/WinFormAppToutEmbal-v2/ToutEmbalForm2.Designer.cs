namespace WinFormAppToutEmbal_v2
{
    partial class ToutEmbalForm2
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
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.quitItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productionMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.startItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startProductionA = new System.Windows.Forms.ToolStripMenuItem();
            this.startProductionB = new System.Windows.Forms.ToolStripMenuItem();
            this.startProductionC = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseProductionA = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseProductionB = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseProductionC = new System.Windows.Forms.ToolStripMenuItem();
            this.stopItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopProductionA = new System.Windows.Forms.ToolStripMenuItem();
            this.stopProductionB = new System.Windows.Forms.ToolStripMenuItem();
            this.stopProductionC = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControlProduction = new System.Windows.Forms.TabControl();
            this.tabPageProductionA = new System.Windows.Forms.TabPage();
            this.tbFaultyRateFromStartA = new System.Windows.Forms.TextBox();
            this.tbHourlyFaultyRateA = new System.Windows.Forms.TextBox();
            this.tbCratesNumberFromStartA = new System.Windows.Forms.TextBox();
            this.labelFaultyRateFromStartA = new System.Windows.Forms.Label();
            this.labelHourlyFaultyRateA = new System.Windows.Forms.Label();
            this.labelCratesNumberFromStartA = new System.Windows.Forms.Label();
            this.tabPageProductionB = new System.Windows.Forms.TabPage();
            this.tbFaultyRateFromStartB = new System.Windows.Forms.TextBox();
            this.tbHourlyFaultyRateB = new System.Windows.Forms.TextBox();
            this.tbCratesNumberFromStartB = new System.Windows.Forms.TextBox();
            this.labelFaultyRateFromStartB = new System.Windows.Forms.Label();
            this.labelHourlyFaultyRateB = new System.Windows.Forms.Label();
            this.labelCratesNumberFromStartB = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tbFaultyRateFromStartC = new System.Windows.Forms.TextBox();
            this.tbHourlyFaultyRateC = new System.Windows.Forms.TextBox();
            this.tbCratesNumberFromStartC = new System.Windows.Forms.TextBox();
            this.labelFaultyRateFromStartC = new System.Windows.Forms.Label();
            this.labelHourlyFaultyRateC = new System.Windows.Forms.Label();
            this.labelCratesNumberFromStartC = new System.Windows.Forms.Label();
            this.progressBarA = new System.Windows.Forms.ProgressBar();
            this.progressBarB = new System.Windows.Forms.ProgressBar();
            this.progressBarC = new System.Windows.Forms.ProgressBar();
            this.labelProductionA = new System.Windows.Forms.Label();
            this.labelProductionB = new System.Windows.Forms.Label();
            this.labelProductionC = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.tabControlProduction.SuspendLayout();
            this.tabPageProductionA.SuspendLayout();
            this.tabPageProductionB.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.productionMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip.Size = new System.Drawing.Size(712, 25);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileMenu
            // 
            this.fileMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitItem});
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(37, 19);
            this.fileMenu.Text = "File";
            // 
            // quitItem
            // 
            this.quitItem.Name = "quitItem";
            this.quitItem.Size = new System.Drawing.Size(97, 22);
            this.quitItem.Text = "Quit";
            // 
            // productionMenu
            // 
            this.productionMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startItem,
            this.pauseItem,
            this.stopItem});
            this.productionMenu.Name = "productionMenu";
            this.productionMenu.Size = new System.Drawing.Size(78, 19);
            this.productionMenu.Text = "Production";
            // 
            // startItem
            // 
            this.startItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startProductionA,
            this.startProductionB,
            this.startProductionC});
            this.startItem.Name = "startItem";
            this.startItem.Size = new System.Drawing.Size(105, 22);
            this.startItem.Text = "Start";
            // 
            // startProductionA
            // 
            this.startProductionA.Name = "startProductionA";
            this.startProductionA.Size = new System.Drawing.Size(144, 22);
            this.startProductionA.Text = "Production A";
            // 
            // startProductionB
            // 
            this.startProductionB.Name = "startProductionB";
            this.startProductionB.Size = new System.Drawing.Size(144, 22);
            this.startProductionB.Text = "Production B";
            // 
            // startProductionC
            // 
            this.startProductionC.Name = "startProductionC";
            this.startProductionC.Size = new System.Drawing.Size(144, 22);
            this.startProductionC.Text = "Production C";
            // 
            // pauseItem
            // 
            this.pauseItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pauseProductionA,
            this.pauseProductionB,
            this.pauseProductionC});
            this.pauseItem.Name = "pauseItem";
            this.pauseItem.Size = new System.Drawing.Size(105, 22);
            this.pauseItem.Text = "Pause";
            // 
            // pauseProductionA
            // 
            this.pauseProductionA.Name = "pauseProductionA";
            this.pauseProductionA.Size = new System.Drawing.Size(144, 22);
            this.pauseProductionA.Text = "Production A";
            // 
            // pauseProductionB
            // 
            this.pauseProductionB.Name = "pauseProductionB";
            this.pauseProductionB.Size = new System.Drawing.Size(144, 22);
            this.pauseProductionB.Text = "Production B";
            // 
            // pauseProductionC
            // 
            this.pauseProductionC.Name = "pauseProductionC";
            this.pauseProductionC.Size = new System.Drawing.Size(144, 22);
            this.pauseProductionC.Text = "Production C";
            // 
            // stopItem
            // 
            this.stopItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stopProductionA,
            this.stopProductionB,
            this.stopProductionC});
            this.stopItem.Name = "stopItem";
            this.stopItem.Size = new System.Drawing.Size(105, 22);
            this.stopItem.Text = "Stop";
            // 
            // stopProductionA
            // 
            this.stopProductionA.Name = "stopProductionA";
            this.stopProductionA.Size = new System.Drawing.Size(144, 22);
            this.stopProductionA.Text = "Production A";
            // 
            // stopProductionB
            // 
            this.stopProductionB.Name = "stopProductionB";
            this.stopProductionB.Size = new System.Drawing.Size(144, 22);
            this.stopProductionB.Text = "Production B";
            // 
            // stopProductionC
            // 
            this.stopProductionC.Name = "stopProductionC";
            this.stopProductionC.Size = new System.Drawing.Size(144, 22);
            this.stopProductionC.Text = "Production C";
            // 
            // tabControlProduction
            // 
            this.tabControlProduction.Controls.Add(this.tabPageProductionA);
            this.tabControlProduction.Controls.Add(this.tabPageProductionB);
            this.tabControlProduction.Controls.Add(this.tabPage1);
            this.tabControlProduction.Location = new System.Drawing.Point(159, 52);
            this.tabControlProduction.Margin = new System.Windows.Forms.Padding(45, 42, 45, 42);
            this.tabControlProduction.Name = "tabControlProduction";
            this.tabControlProduction.SelectedIndex = 0;
            this.tabControlProduction.Size = new System.Drawing.Size(496, 164);
            this.tabControlProduction.TabIndex = 1;
            // 
            // tabPageProductionA
            // 
            this.tabPageProductionA.Controls.Add(this.tbFaultyRateFromStartA);
            this.tabPageProductionA.Controls.Add(this.tbHourlyFaultyRateA);
            this.tabPageProductionA.Controls.Add(this.tbCratesNumberFromStartA);
            this.tabPageProductionA.Controls.Add(this.labelFaultyRateFromStartA);
            this.tabPageProductionA.Controls.Add(this.labelHourlyFaultyRateA);
            this.tabPageProductionA.Controls.Add(this.labelCratesNumberFromStartA);
            this.tabPageProductionA.Location = new System.Drawing.Point(4, 27);
            this.tabPageProductionA.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageProductionA.Name = "tabPageProductionA";
            this.tabPageProductionA.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageProductionA.Size = new System.Drawing.Size(488, 133);
            this.tabPageProductionA.TabIndex = 0;
            this.tabPageProductionA.Text = "Production A";
            this.tabPageProductionA.UseVisualStyleBackColor = true;
            // 
            // tbFaultyRateFromStartA
            // 
            this.tbFaultyRateFromStartA.Enabled = false;
            this.tbFaultyRateFromStartA.Location = new System.Drawing.Point(308, 92);
            this.tbFaultyRateFromStartA.Name = "tbFaultyRateFromStartA";
            this.tbFaultyRateFromStartA.Size = new System.Drawing.Size(153, 24);
            this.tbFaultyRateFromStartA.TabIndex = 5;
            // 
            // tbHourlyFaultyRateA
            // 
            this.tbHourlyFaultyRateA.Enabled = false;
            this.tbHourlyFaultyRateA.Location = new System.Drawing.Point(308, 54);
            this.tbHourlyFaultyRateA.Name = "tbHourlyFaultyRateA";
            this.tbHourlyFaultyRateA.Size = new System.Drawing.Size(153, 24);
            this.tbHourlyFaultyRateA.TabIndex = 4;
            // 
            // tbCratesNumberFromStartA
            // 
            this.tbCratesNumberFromStartA.Enabled = false;
            this.tbCratesNumberFromStartA.Location = new System.Drawing.Point(308, 16);
            this.tbCratesNumberFromStartA.Name = "tbCratesNumberFromStartA";
            this.tbCratesNumberFromStartA.Size = new System.Drawing.Size(153, 24);
            this.tbCratesNumberFromStartA.TabIndex = 3;
            // 
            // labelFaultyRateFromStartA
            // 
            this.labelFaultyRateFromStartA.AutoSize = true;
            this.labelFaultyRateFromStartA.Location = new System.Drawing.Point(27, 95);
            this.labelFaultyRateFromStartA.Margin = new System.Windows.Forms.Padding(10);
            this.labelFaultyRateFromStartA.Name = "labelFaultyRateFromStartA";
            this.labelFaultyRateFromStartA.Size = new System.Drawing.Size(144, 18);
            this.labelFaultyRateFromStartA.TabIndex = 2;
            this.labelFaultyRateFromStartA.Text = "Faulty rate from start";
            // 
            // labelHourlyFaultyRateA
            // 
            this.labelHourlyFaultyRateA.AutoSize = true;
            this.labelHourlyFaultyRateA.Location = new System.Drawing.Point(27, 57);
            this.labelHourlyFaultyRateA.Margin = new System.Windows.Forms.Padding(10);
            this.labelHourlyFaultyRateA.Name = "labelHourlyFaultyRateA";
            this.labelHourlyFaultyRateA.Size = new System.Drawing.Size(118, 18);
            this.labelHourlyFaultyRateA.TabIndex = 1;
            this.labelHourlyFaultyRateA.Text = "Hourly faulty rate";
            // 
            // labelCratesNumberFromStartA
            // 
            this.labelCratesNumberFromStartA.AutoSize = true;
            this.labelCratesNumberFromStartA.Location = new System.Drawing.Point(27, 19);
            this.labelCratesNumberFromStartA.Margin = new System.Windows.Forms.Padding(10);
            this.labelCratesNumberFromStartA.Name = "labelCratesNumberFromStartA";
            this.labelCratesNumberFromStartA.Size = new System.Drawing.Size(242, 18);
            this.labelCratesNumberFromStartA.TabIndex = 0;
            this.labelCratesNumberFromStartA.Text = "Produced crates from the beginning";
            // 
            // tabPageProductionB
            // 
            this.tabPageProductionB.Controls.Add(this.tbFaultyRateFromStartB);
            this.tabPageProductionB.Controls.Add(this.tbHourlyFaultyRateB);
            this.tabPageProductionB.Controls.Add(this.tbCratesNumberFromStartB);
            this.tabPageProductionB.Controls.Add(this.labelFaultyRateFromStartB);
            this.tabPageProductionB.Controls.Add(this.labelHourlyFaultyRateB);
            this.tabPageProductionB.Controls.Add(this.labelCratesNumberFromStartB);
            this.tabPageProductionB.Location = new System.Drawing.Point(4, 27);
            this.tabPageProductionB.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageProductionB.Name = "tabPageProductionB";
            this.tabPageProductionB.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageProductionB.Size = new System.Drawing.Size(488, 133);
            this.tabPageProductionB.TabIndex = 1;
            this.tabPageProductionB.Text = "Production B";
            this.tabPageProductionB.UseVisualStyleBackColor = true;
            // 
            // tbFaultyRateFromStartB
            // 
            this.tbFaultyRateFromStartB.Enabled = false;
            this.tbFaultyRateFromStartB.Location = new System.Drawing.Point(308, 92);
            this.tbFaultyRateFromStartB.Name = "tbFaultyRateFromStartB";
            this.tbFaultyRateFromStartB.Size = new System.Drawing.Size(153, 24);
            this.tbFaultyRateFromStartB.TabIndex = 11;
            // 
            // tbHourlyFaultyRateB
            // 
            this.tbHourlyFaultyRateB.Enabled = false;
            this.tbHourlyFaultyRateB.Location = new System.Drawing.Point(308, 54);
            this.tbHourlyFaultyRateB.Name = "tbHourlyFaultyRateB";
            this.tbHourlyFaultyRateB.Size = new System.Drawing.Size(153, 24);
            this.tbHourlyFaultyRateB.TabIndex = 10;
            // 
            // tbCratesNumberFromStartB
            // 
            this.tbCratesNumberFromStartB.Enabled = false;
            this.tbCratesNumberFromStartB.Location = new System.Drawing.Point(308, 16);
            this.tbCratesNumberFromStartB.Name = "tbCratesNumberFromStartB";
            this.tbCratesNumberFromStartB.Size = new System.Drawing.Size(153, 24);
            this.tbCratesNumberFromStartB.TabIndex = 9;
            // 
            // labelFaultyRateFromStartB
            // 
            this.labelFaultyRateFromStartB.AutoSize = true;
            this.labelFaultyRateFromStartB.Location = new System.Drawing.Point(27, 95);
            this.labelFaultyRateFromStartB.Margin = new System.Windows.Forms.Padding(10);
            this.labelFaultyRateFromStartB.Name = "labelFaultyRateFromStartB";
            this.labelFaultyRateFromStartB.Size = new System.Drawing.Size(144, 18);
            this.labelFaultyRateFromStartB.TabIndex = 8;
            this.labelFaultyRateFromStartB.Text = "Faulty rate from start";
            // 
            // labelHourlyFaultyRateB
            // 
            this.labelHourlyFaultyRateB.AutoSize = true;
            this.labelHourlyFaultyRateB.Location = new System.Drawing.Point(27, 57);
            this.labelHourlyFaultyRateB.Margin = new System.Windows.Forms.Padding(10);
            this.labelHourlyFaultyRateB.Name = "labelHourlyFaultyRateB";
            this.labelHourlyFaultyRateB.Size = new System.Drawing.Size(118, 18);
            this.labelHourlyFaultyRateB.TabIndex = 7;
            this.labelHourlyFaultyRateB.Text = "Hourly faulty rate";
            // 
            // labelCratesNumberFromStartB
            // 
            this.labelCratesNumberFromStartB.AutoSize = true;
            this.labelCratesNumberFromStartB.Location = new System.Drawing.Point(27, 19);
            this.labelCratesNumberFromStartB.Margin = new System.Windows.Forms.Padding(10);
            this.labelCratesNumberFromStartB.Name = "labelCratesNumberFromStartB";
            this.labelCratesNumberFromStartB.Size = new System.Drawing.Size(242, 18);
            this.labelCratesNumberFromStartB.TabIndex = 6;
            this.labelCratesNumberFromStartB.Text = "Produced crates from the beginning";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tbFaultyRateFromStartC);
            this.tabPage1.Controls.Add(this.tbHourlyFaultyRateC);
            this.tabPage1.Controls.Add(this.tbCratesNumberFromStartC);
            this.tabPage1.Controls.Add(this.labelFaultyRateFromStartC);
            this.tabPage1.Controls.Add(this.labelHourlyFaultyRateC);
            this.tabPage1.Controls.Add(this.labelCratesNumberFromStartC);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(488, 133);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Production C";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tbFaultyRateFromStartC
            // 
            this.tbFaultyRateFromStartC.Enabled = false;
            this.tbFaultyRateFromStartC.Location = new System.Drawing.Point(308, 92);
            this.tbFaultyRateFromStartC.Name = "tbFaultyRateFromStartC";
            this.tbFaultyRateFromStartC.Size = new System.Drawing.Size(153, 24);
            this.tbFaultyRateFromStartC.TabIndex = 11;
            // 
            // tbHourlyFaultyRateC
            // 
            this.tbHourlyFaultyRateC.Enabled = false;
            this.tbHourlyFaultyRateC.Location = new System.Drawing.Point(308, 54);
            this.tbHourlyFaultyRateC.Name = "tbHourlyFaultyRateC";
            this.tbHourlyFaultyRateC.Size = new System.Drawing.Size(153, 24);
            this.tbHourlyFaultyRateC.TabIndex = 10;
            // 
            // tbCratesNumberFromStartC
            // 
            this.tbCratesNumberFromStartC.Enabled = false;
            this.tbCratesNumberFromStartC.Location = new System.Drawing.Point(308, 16);
            this.tbCratesNumberFromStartC.Name = "tbCratesNumberFromStartC";
            this.tbCratesNumberFromStartC.Size = new System.Drawing.Size(153, 24);
            this.tbCratesNumberFromStartC.TabIndex = 9;
            // 
            // labelFaultyRateFromStartC
            // 
            this.labelFaultyRateFromStartC.AutoSize = true;
            this.labelFaultyRateFromStartC.Location = new System.Drawing.Point(27, 95);
            this.labelFaultyRateFromStartC.Margin = new System.Windows.Forms.Padding(10);
            this.labelFaultyRateFromStartC.Name = "labelFaultyRateFromStartC";
            this.labelFaultyRateFromStartC.Size = new System.Drawing.Size(144, 18);
            this.labelFaultyRateFromStartC.TabIndex = 8;
            this.labelFaultyRateFromStartC.Text = "Faulty rate from start";
            // 
            // labelHourlyFaultyRateC
            // 
            this.labelHourlyFaultyRateC.AutoSize = true;
            this.labelHourlyFaultyRateC.Location = new System.Drawing.Point(27, 57);
            this.labelHourlyFaultyRateC.Margin = new System.Windows.Forms.Padding(10);
            this.labelHourlyFaultyRateC.Name = "labelHourlyFaultyRateC";
            this.labelHourlyFaultyRateC.Size = new System.Drawing.Size(118, 18);
            this.labelHourlyFaultyRateC.TabIndex = 7;
            this.labelHourlyFaultyRateC.Text = "Hourly faulty rate";
            // 
            // labelCratesNumberFromStartC
            // 
            this.labelCratesNumberFromStartC.AutoSize = true;
            this.labelCratesNumberFromStartC.Location = new System.Drawing.Point(27, 19);
            this.labelCratesNumberFromStartC.Margin = new System.Windows.Forms.Padding(10);
            this.labelCratesNumberFromStartC.Name = "labelCratesNumberFromStartC";
            this.labelCratesNumberFromStartC.Size = new System.Drawing.Size(242, 18);
            this.labelCratesNumberFromStartC.TabIndex = 6;
            this.labelCratesNumberFromStartC.Text = "Produced crates from the beginning";
            // 
            // progressBarA
            // 
            this.progressBarA.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.progressBarA.Location = new System.Drawing.Point(165, 258);
            this.progressBarA.Margin = new System.Windows.Forms.Padding(15, 14, 15, 14);
            this.progressBarA.Name = "progressBarA";
            this.progressBarA.Size = new System.Drawing.Size(486, 32);
            this.progressBarA.TabIndex = 2;
            // 
            // progressBarB
            // 
            this.progressBarB.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.progressBarB.Location = new System.Drawing.Point(165, 317);
            this.progressBarB.Margin = new System.Windows.Forms.Padding(15, 14, 15, 14);
            this.progressBarB.Name = "progressBarB";
            this.progressBarB.Size = new System.Drawing.Size(486, 32);
            this.progressBarB.TabIndex = 3;
            // 
            // progressBarC
            // 
            this.progressBarC.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.progressBarC.Location = new System.Drawing.Point(165, 377);
            this.progressBarC.Margin = new System.Windows.Forms.Padding(15, 14, 15, 14);
            this.progressBarC.Name = "progressBarC";
            this.progressBarC.Size = new System.Drawing.Size(486, 32);
            this.progressBarC.TabIndex = 4;
            // 
            // labelProductionA
            // 
            this.labelProductionA.AutoSize = true;
            this.labelProductionA.Location = new System.Drawing.Point(34, 265);
            this.labelProductionA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProductionA.Name = "labelProductionA";
            this.labelProductionA.Size = new System.Drawing.Size(93, 18);
            this.labelProductionA.TabIndex = 5;
            this.labelProductionA.Text = "Production A";
            // 
            // labelProductionB
            // 
            this.labelProductionB.AutoSize = true;
            this.labelProductionB.Location = new System.Drawing.Point(34, 326);
            this.labelProductionB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProductionB.Name = "labelProductionB";
            this.labelProductionB.Size = new System.Drawing.Size(94, 18);
            this.labelProductionB.TabIndex = 6;
            this.labelProductionB.Text = "Production B";
            // 
            // labelProductionC
            // 
            this.labelProductionC.AutoSize = true;
            this.labelProductionC.Location = new System.Drawing.Point(34, 386);
            this.labelProductionC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProductionC.Name = "labelProductionC";
            this.labelProductionC.Size = new System.Drawing.Size(95, 18);
            this.labelProductionC.TabIndex = 7;
            this.labelProductionC.Text = "Production C";
            // 
            // ToutEmbalForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(712, 449);
            this.Controls.Add(this.labelProductionC);
            this.Controls.Add(this.labelProductionB);
            this.Controls.Add(this.labelProductionA);
            this.Controls.Add(this.progressBarC);
            this.Controls.Add(this.progressBarB);
            this.Controls.Add(this.progressBarA);
            this.Controls.Add(this.tabControlProduction);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "ToutEmbalForm2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Wood Crates Production";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.tabControlProduction.ResumeLayout(false);
            this.tabPageProductionA.ResumeLayout(false);
            this.tabPageProductionA.PerformLayout();
            this.tabPageProductionB.ResumeLayout(false);
            this.tabPageProductionB.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem productionMenu;
        private System.Windows.Forms.TabControl tabControlProduction;
        private System.Windows.Forms.TabPage tabPageProductionA;
        private System.Windows.Forms.TabPage tabPageProductionB;
        private System.Windows.Forms.ProgressBar progressBarA;
        private System.Windows.Forms.ProgressBar progressBarB;
        private System.Windows.Forms.ProgressBar progressBarC;
        private System.Windows.Forms.Label labelProductionA;
        private System.Windows.Forms.Label labelProductionB;
        private System.Windows.Forms.Label labelProductionC;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox tbFaultyRateFromStartA;
        private System.Windows.Forms.TextBox tbHourlyFaultyRateA;
        private System.Windows.Forms.TextBox tbCratesNumberFromStartA;
        private System.Windows.Forms.Label labelFaultyRateFromStartA;
        private System.Windows.Forms.Label labelHourlyFaultyRateA;
        private System.Windows.Forms.Label labelCratesNumberFromStartA;
        private System.Windows.Forms.TextBox tbFaultyRateFromStartB;
        private System.Windows.Forms.TextBox tbHourlyFaultyRateB;
        private System.Windows.Forms.TextBox tbCratesNumberFromStartB;
        private System.Windows.Forms.Label labelFaultyRateFromStartB;
        private System.Windows.Forms.Label labelHourlyFaultyRateB;
        private System.Windows.Forms.Label labelCratesNumberFromStartB;
        private System.Windows.Forms.TextBox tbFaultyRateFromStartC;
        private System.Windows.Forms.TextBox tbHourlyFaultyRateC;
        private System.Windows.Forms.TextBox tbCratesNumberFromStartC;
        private System.Windows.Forms.Label labelFaultyRateFromStartC;
        private System.Windows.Forms.Label labelHourlyFaultyRateC;
        private System.Windows.Forms.Label labelCratesNumberFromStartC;
        private System.Windows.Forms.ToolStripMenuItem quitItem;
        private System.Windows.Forms.ToolStripMenuItem startItem;
        private System.Windows.Forms.ToolStripMenuItem startProductionA;
        private System.Windows.Forms.ToolStripMenuItem startProductionB;
        private System.Windows.Forms.ToolStripMenuItem startProductionC;
        private System.Windows.Forms.ToolStripMenuItem pauseItem;
        private System.Windows.Forms.ToolStripMenuItem pauseProductionA;
        private System.Windows.Forms.ToolStripMenuItem pauseProductionB;
        private System.Windows.Forms.ToolStripMenuItem pauseProductionC;
        private System.Windows.Forms.ToolStripMenuItem stopItem;
        private System.Windows.Forms.ToolStripMenuItem stopProductionA;
        private System.Windows.Forms.ToolStripMenuItem stopProductionB;
        private System.Windows.Forms.ToolStripMenuItem stopProductionC;
    }
}

