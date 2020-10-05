using System;
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
        public Additionneur()
        {
            InitializeComponent();
        }

        private void textBoxResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonZero_Click(object sender, EventArgs e)
        {
            textBoxResult.Text += "0+";
        }

        private void buttonOne_Click(object sender, EventArgs e)
        {
            textBoxResult.Text += "1+";
        }

        private void buttonTwo_Click(object sender, EventArgs e)
        {
            textBoxResult.Text += "2+";
        }

        private void buttonThree_Click(object sender, EventArgs e)
        {
            textBoxResult.Text += "3+";
        }

        private void buttonFour_Click(object sender, EventArgs e)
        {
            textBoxResult.Text += "4+";
        }

        private void buttonFive_Click(object sender, EventArgs e)
        {
            textBoxResult.Text += "5+";
        }

        private void buttonSix_Click(object sender, EventArgs e)
        {
            textBoxResult.Text += "6+";
        }

        private void buttonSeven_Click(object sender, EventArgs e)
        {
            textBoxResult.Text += "7+";
        }

        private void buttonEight_Click(object sender, EventArgs e)
        {
            textBoxResult.Text += "8+";
        }

        private void buttonNine_Click(object sender, EventArgs e)
        {
            textBoxResult.Text += "9+";
        }

        private void buttonEmpty_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = "";
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {

        }
    }
}
