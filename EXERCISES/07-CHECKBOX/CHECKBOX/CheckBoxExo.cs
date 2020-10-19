using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UTILS;

namespace CHECKBOX
{
    public partial class CheckBoxExo : Form
    {
        public CheckBoxExo()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            if (TextBoxControls.TextBoxIsEmpty(tbInput))
                gbxChoice.Enabled = false;
            else
                gbxChoice.Enabled = true;
        }

        private void CheckBox_Click(object sender, EventArgs e)
        {
            CheckBox currentCheckBox = (CheckBox)sender;
            if (!currentCheckBox.Checked)
                currentCheckBox.Checked = true;
            else
                currentCheckBox.Checked = false;
        }

        private void CheckBox_CheckStateChanged(object sender, EventArgs e)
        {
            CheckBox currentCheckBox = (CheckBox)sender;


        }
    }
}
