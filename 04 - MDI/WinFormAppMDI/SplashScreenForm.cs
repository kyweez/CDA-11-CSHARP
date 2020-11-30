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

        /// <summary>
        /// Trigger on each tick of the splash screen timer
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void TimerSplashScreen_Tick(object sender, EventArgs e)
        {
            progressBarSplashScreen.Increment(10);
            if (progressBarSplashScreen.Value == 100)
            {
                timerSplashScreen.Stop();
                Close();
            }
        }

        /// <summary>
        /// Triggered when the splash screen is load
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void SplashScreenForm_Load(object sender, EventArgs e)
        {
            timerSplashScreen.Start();
        }
    }
}