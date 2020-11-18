using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            progressBarSplashScreen.Increment(1);
            if (progressBarSplashScreen.Value == 100)
                timerSplashScreen.Stop();
        }
    }
}