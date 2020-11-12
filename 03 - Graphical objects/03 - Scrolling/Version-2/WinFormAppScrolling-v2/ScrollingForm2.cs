using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormAppScrolling_v1
{
    public partial class ScrollingForm2 : Form
    {
        #region ############### FIELDS ###############
        private Color finalColor;
        #endregion

        #region ############### CONSTRUCTORS ###############
        public ScrollingForm2()
        {
            InitializeComponent();
            finalColor = new Color();
            finalColor = Color.FromArgb(0, 0, 0);
        }
        #endregion

        #region ############### METHODS ###############
        /// <summary>
        /// Update the textBoxColor dependeing on the RGB values
        /// </summary>
        private void UpdateTextBoxColor()
        {
            textBoxColor.BackColor = finalColor;
        }
        #endregion

        #region ############### EVENTS ###############
        /// <summary>
        /// Sync the numericUpDownBlue value to the hsBlue bar
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void NumericUpDownBlue_ValueChanged(object sender, EventArgs e)
        {
            hsBlue.Value = Convert.ToInt32(numericUpDownBlue.Value);
            finalColor = Color.FromArgb(finalColor.R, finalColor.G, Convert.ToInt32(numericUpDownBlue.Value));
            UpdateTextBoxColor();
        }

        /// <summary>
        /// Sync the numericUpDownGreen value to the hsGreen bar
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void NumericUpDownGreen_ValueChanged(object sender, EventArgs e)
        {
            hsGreen.Value = Convert.ToInt32(numericUpDownGreen.Value);
            finalColor = Color.FromArgb(finalColor.R, Convert.ToInt32(numericUpDownGreen.Value), finalColor.B);
            UpdateTextBoxColor();
        }

        /// <summary>
        /// Sync the numericUpDownRed value to the hsRed bar
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void NumericUpDownRed_ValueChanged(object sender, EventArgs e)
        {
            hsRed.Value = Convert.ToInt32(numericUpDownRed.Value);
            finalColor = Color.FromArgb(Convert.ToInt32(numericUpDownRed.Value), finalColor.G, finalColor.B);
            UpdateTextBoxColor();
        }

        /// <summary>
        /// Sync the hsBlue bar value to the numericUpDownBlue
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void HsBlue_ValueChanged(object sender, EventArgs e)
        {
            numericUpDownBlue.Value = hsBlue.Value;
            UpdateTextBoxColor();
        }

        /// <summary>
        /// Sync the hsGreen bar value to the numericUpDownGreen
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void HsGreen_ValueChanged(object sender, EventArgs e)
        {
            numericUpDownGreen.Value = hsGreen.Value;
            UpdateTextBoxColor();
        }

        /// <summary>
        /// Sync the hsRed bar value to the numericUpDownRed
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void HsRed_ValueChanged(object sender, EventArgs e)
        {
            numericUpDownRed.Value = hsRed.Value;
            UpdateTextBoxColor();
        }
        #endregion
    }
}