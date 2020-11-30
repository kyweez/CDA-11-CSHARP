namespace WinFormAppMDI
{
    partial class SplashScreenForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreenForm));
            this.progressBarSplashScreen = new System.Windows.Forms.ProgressBar();
            this.timerSplashScreen = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // progressBarSplashScreen
            // 
            this.progressBarSplashScreen.Location = new System.Drawing.Point(538, 448);
            this.progressBarSplashScreen.Name = "progressBarSplashScreen";
            this.progressBarSplashScreen.Size = new System.Drawing.Size(266, 23);
            this.progressBarSplashScreen.TabIndex = 0;
            // 
            // timerSplashScreen
            // 
            this.timerSplashScreen.Tick += new System.EventHandler(this.TimerSplashScreen_Tick);
            // 
            // SplashScreenForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(960, 540);
            this.ControlBox = false;
            this.Controls.Add(this.progressBarSplashScreen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SplashScreenForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.SplashScreenForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBarSplashScreen;
        private System.Windows.Forms.Timer timerSplashScreen;
    }
}