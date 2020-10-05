﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CALCULATOR
{
    public partial class Additionneur : Form
    {
        private Int32 result = 0;

        public Additionneur()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBoxResult.Text += (button.Tag.ToString() + "+");
            result += Int32.Parse(button.Tag.ToString());
        }

        private void buttonEmpty_Click(object sender, EventArgs e)
        {
            textBoxResult.Clear();
            result = 0;
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            textBoxResult.Text += (" = " + result.ToString() + "+");

        }
    }
}
