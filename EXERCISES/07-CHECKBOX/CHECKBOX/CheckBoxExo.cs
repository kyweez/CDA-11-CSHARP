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

        private void CheckBox_CheckStateChanged(object sender, EventArgs e)
        {
            CheckBox currentCheckBox = (CheckBox)sender;

            if (currentCheckBox == cbBackgroundColor)
                TriggerRadioButtonDisplay(gbxBackgroundColor);
         
            if (currentCheckBox == cbFontColor)
                TriggerRadioButtonDisplay(gbxFontColor);
         
            if (currentCheckBox == cbCase)
                TriggerRadioButtonDisplay(gbxCase);
        }

        private void TriggerRadioButtonDisplay(GroupBox _groupBox)
        {
            if (!_groupBox.Visible)
                _groupBox.Visible = true;
            else
                _groupBox.Visible = false;
        }


    }
}
