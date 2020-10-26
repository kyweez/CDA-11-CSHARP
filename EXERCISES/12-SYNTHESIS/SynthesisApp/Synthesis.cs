using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SynthesisApp
{
    public partial class Loan : Form
    {
        /***************************** ATTRIBUTES ****************************/
        private List<string> repaymentFrequency;
        private bool nameHasError;
        private bool capitalHasError;
        private double totalRepayment;

        /**************************** CONSTRUCTORS ***************************/
        public Loan()
        {
            InitializeComponent();
            repaymentFrequency = new List<string> { "Monthly", "Bimonthly", "Quarterly", "Semi-annual", "Annual" };
            listBoxRepaymentFrequency.DataSource = repaymentFrequency;
            UpdateLabelNumberOfMonths();
            totalRepayment = 0f;
        }

        /****************************** METHODS ******************************/

        /// <summary>
        /// This methods sets the new totalAmount
        /// </summary>
        private void CalculateTotalRepayment()
        {
            var checkedButton = this.Controls.OfType<RadioButton>().First(button => (button.Checked == true));
            int rate = Convert.ToInt32(checkedButton.Tag);
            int capital = Convert.ToInt32(textBoxBorrowedCapital);
            double repaymentNumber = hScrollBarNumberOfMonths.Value / NumberOfMonthsDivider();

            totalRepayment = capital * (rate / (1 - Math.Pow((1 + rate), (repaymentNumber * -1))));
        }

        /// <summary>
        /// This method returns an int needed to find the number of repayment, depending on the selected item in the listbox
        /// </summary>
        /// <returns>int</returns>
        private int NumberOfMonthsDivider()
        {
            int index = listBoxRepaymentFrequency.SelectedIndex;

            switch (index)
            {
                case 0:
                    return 12;
                case 1:
                    return 6;
                case 2:
                    return 4;
                case 3:
                    return 2;
                default:
                    return 1;
            }
        }

        /// <summary>
        /// Updates the label NumberOfMonths (under the hsScrollBar)
        /// </summary>
        private void UpdateLabelNumberOfMonths()
        {
            if (hScrollBarNumberOfMonths.Value != 1)
                labelNumberOfMonths.Text = $"{hScrollBarNumberOfMonths.Value} months";
            else
                labelNumberOfMonths.Text = $"{hScrollBarNumberOfMonths.Value} month";
        }

        /******************************* EVENTS ******************************/

        /// <summary>
        /// Launches the calcul and display the result
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void ButtonOK_Click(object sender, EventArgs e)
        {
            CalculateTotalRepayment();
            MessageBox.Show(Math.Round(totalRepayment, 2).ToString());
        }

        /// <summary>
        /// Triggers the update of the Label NumberOfMonths
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void HScrollBarNumberOfMonths_ValueChanged(object sender, EventArgs e)
        {
            UpdateLabelNumberOfMonths();
        }

        /// <summary>
        /// Does some controls on the name textbox and activate/desactivate Ok button
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void TextBoxName_TextChanged(object sender, EventArgs e)
        {
            errorProviderName.Clear();
            if (!capitalHasError)
                buttonOK.Enabled = true;
            if (textBoxName.Text.Length == 0)
            {
                buttonOK.Enabled = false;
                nameHasError = true;
            }
            else if (!Regex.IsMatch(textBoxName.Text, @"^[a-zA-Z]+([\-\' ][a-zA-Z]+)*$"))
            {
                buttonOK.Enabled = false;
                errorProviderName.SetError(textBoxName, "Not a valid name");
                nameHasError = true;
            }
            else
                nameHasError = false;
        }

        /// <summary>
        /// Does some controls on the capital textbox and activate/desactivate Ok button
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void TextBorrowedCapital_TextChanged(object sender, EventArgs e)
        {
            errorProviderAmount.Clear();
            if (!nameHasError)
                buttonOK.Enabled = true;
            if (textBoxBorrowedCapital.Text.Length == 0)
            {
                buttonOK.Enabled = false;
                capitalHasError = true;
            }
            else if (!Int32.TryParse(textBoxBorrowedCapital.Text, out int _desiredAmount))
            {
                buttonOK.Enabled = false;
                errorProviderAmount.SetError(textBoxBorrowedCapital, "Input an integer number");
                capitalHasError = true;

            }
            else if (_desiredAmount > 1000000)
            {
                buttonOK.Enabled = false;
                errorProviderAmount.SetError(textBoxBorrowedCapital, "We can't moan more than 1,000,000");
                capitalHasError = true;
            }
            else
                capitalHasError = false;
        }
    }
}