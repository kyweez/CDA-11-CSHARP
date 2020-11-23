using System;
using System.Windows.Forms;

namespace WinFormAppMDI
{
    public partial class SplashScreenForm : Form
    {
        public SplashScreenForm()
        {
            InitializeComponent();
        }

        private void timerSplashScreen_Tick(object sender, EventArgs e)
        {
            progressBarSplashScreen.Increment(5);
            if (progressBarSplashScreen.Value == 100)
            {
                timerSplashScreen.Stop();
                this.Close();
            }
        }

        private void SplashScreenForm_Load(object sender, EventArgs e)
        {
            timerSplashScreen.Start();
        }
    }
}