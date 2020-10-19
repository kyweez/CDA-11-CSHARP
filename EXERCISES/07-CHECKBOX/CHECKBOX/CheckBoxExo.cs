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
        /***************************** ATTRIBUTES ****************************/
        private List<GroupBox> radioButtonGroupBoxes;

        /**************************** CONSTRUCTORS ***************************/
        public CheckBoxExo()
        {
            InitializeComponent();

            radioButtonGroupBoxes = new List<GroupBox>
            {
                gbxBackgroundColor,
                gbxFontColor,
                gbxCase
            };
        }

        /***************************** PROPERTIES ****************************/
        // NONE

        /****************************** METHODS ******************************/

        /// <summary>
        ///     This method unchecks every radio buttons in the groupBox given as an argument
        /// </summary>
        /// <param name="_groupBox">GroupBox</param>
        private void Clear_RadioButtons(GroupBox _groupBox)
        {
            _groupBox.Controls.OfType<RadioButton>().ToList().ForEach(rb => rb.Checked = false);
        }

        /// <summary>
        ///     This method unchecks every check box in the groupBox given as an argument
        /// </summary>
        /// <param name="_groupBox">GroupBox</param>
        private void Clear_CheckBox(GroupBox _groupBox)
        {
            _groupBox.Controls.OfType<CheckBox>().ToList().ForEach(cb => cb.Checked = false);
        }

        /// <summary>
        ///     This method hides the groupBox given as an argument
        /// </summary>
        /// <param name="_groupBox">GroupBox</param>
        private void Hide_GroupBox(GroupBox _groupBox)
        {
            _groupBox.Visible = false;
        }

        /// <summary>
        ///     This method change the visibility of the GroupBox given as an argument
        ///     If it makes 
        /// </summary>
        /// <param name="_groupBox">GroupBox</param>
        private void TriggerRadioButtonDisplay(GroupBox _groupBox)
        {
            if (!_groupBox.Visible)
                _groupBox.Visible = true;
            else
            {
                _groupBox.Visible = false;
                Clear_RadioButtons(_groupBox);
            }
        }

        /******************************* EVENTS ******************************/

        /// <summary>
        ///     This method triggers the display of radioButtons groupbox when the checkBox checkstate changes
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void CheckBox_CheckChanged(object sender, EventArgs e)
        {
            CheckBox currentCheckBox = (CheckBox)sender;
            if (gbxChoice.Enabled)
            {
                if (currentCheckBox == cbBackgroundColor)
                    TriggerRadioButtonDisplay(gbxBackgroundColor);

                if (currentCheckBox == cbFontColor)
                    TriggerRadioButtonDisplay(gbxFontColor);

                if (currentCheckBox == cbCase)
                {
                    TriggerRadioButtonDisplay(gbxCase);
                    labOutput.Text = tbInput.Text;
                }
            }
        }

        /// <summary>
        ///     This method is triggered when the gbChoice enabling changes
        ///     If it's disabled, reset radio buttons and checkBoxes
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">sender</param>
        private void GroupBox_EnabledChanged(object sender, EventArgs e)
        {
            if (!gbxChoice.Enabled)
            {
                foreach (GroupBox groupBox in radioButtonGroupBoxes)
                {
                    Clear_RadioButtons(groupBox);
                    Hide_GroupBox(groupBox);
                }
            }
        }

        /// <summary>
        ///     This method is triggered when a radio button in the background group box is checked
        ///     Change the label background color
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void RadioButtonBackGround_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonBgRed.Checked)
                labOutput.BackColor = Color.Red;
            else if (radioButtonBgGreen.Checked)
                labOutput.BackColor = Color.Green;
            else if (radioButtonBgBlue.Checked)
                labOutput.BackColor = Color.Blue;
            else
                labOutput.BackColor = System.Drawing.SystemColors.ControlLightLight;
        }

        /// <summary>
        ///     This method is triggered when a radio button in thecase group box is checked
        ///     Change the label case
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void RadioButtonCase_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonLowerCase.Checked)
                labOutput.Text = labOutput.Text.ToLower();
            else
                labOutput.Text = labOutput.Text.ToUpper();
        }

        /// <summary>
        ///     This method is triggered when a radio button in the font color group box is checked
        ///     Change the label font color
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void RadioButtonFontColor_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonFontColorRed.Checked)
                labOutput.ForeColor = Color.Red;
            else if (radioButtonFontColorWhite.Checked)
                labOutput.ForeColor = Color.White;
            else
                labOutput.ForeColor = Color.Black;
        }

        /// <summary>
        ///     This method is triggered when the textBox changes
        ///     If it's empty, disable all groupBox
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            labOutput.Text = tbInput.Text;
            Clear_CheckBox(gbxChoice);
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
    }
}