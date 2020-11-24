using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormAppCalculator
{
    public partial class Adder : Form
    {
        private int result;

        public Adder()
        {
            InitializeComponent();
            result = 0;
        }

        public Adder(int instanceNumber)
        {
            InitializeComponent();
            result = 0;
            Text = $"Adder number : {instanceNumber}";
        }

        /// <summary>
        ///     This method is triggered when the user clik on a number
        ///     This print the adding in the textBox then store the new result
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void BtnNumber_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            tbResult.Text += $"{button.Tag}+";
            result += int.Parse(button.Tag.ToString());
        }

        /// <summary> 
        ///     This method is triggered when the user clik on calculate
        ///     Display the result
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            tbResult.Text += $" = {result}+";
        }

        /// <summary> 
        ///     This method is triggered when the user clik on reset
        ///     Resest the display and the result
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void BtnReset_Click(object sender, EventArgs e)
        {
            tbResult.Clear();
            result = 0;
        }
    }
}