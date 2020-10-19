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

        /// <summary>
        ///     This is triggered when the textBox changes
        ///     If it's empty, disable all groupBox
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            labOutput.Text = tbInput.Text;
            if (TextBoxControls.TextBoxIsEmpty(tbInput))
            {
                labOutput.Visible = false;
                gbxChoice.Enabled = false;
            }
            else
            {
                labOutput.Visible = true;
                gbxChoice.Enabled = true;
            }
        }

        private void CheckBox_CheckChanged(object sender, EventArgs e)
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

        private void GroupBox_EnabledChanged(object sender, EventArgs e)
        {
            List<GroupBox> radioButtonGroupBoxes = new List<GroupBox>
            {
                gbxBackgroundColor,
                gbxFontColor,
                gbxCase
            };

            if (!gbxChoice.Visible)
            {
                foreach (GroupBox groupBox in radioButtonGroupBoxes)
                    groupBox.Visible = true;
            }
        }

        private void RadioButtonBackGround_CheckedChanged(object sender, EventArgs e)
        {

            labOutput.BackColor = Color.Red;
        }
    }
}
