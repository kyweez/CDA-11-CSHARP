﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WinFormAppMDI
{
    public partial class MDIForm : Form
    {
        public MDIForm()
        {
            //Thread trd = new Thread(new ThreadStart(StartSplashScreenForm));
            //trd.Start();
            //Thread.Sleep(6000);
            InitializeComponent();
            //trd.Abort();
        }

        private void StartSplashScreenForm()
        {
            Application.Run(new SplashScreenForm());
        }
    }
}