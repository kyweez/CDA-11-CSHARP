using ClassLibraryBill;
using ClassLibraryDataCheck;
using ClassLibraryErrorCheck;
using System;
using System.Collections.Generic;
using System.Media;
using System.Windows.Forms;

namespace WinFormAppInputValidation_v2
{
    public partial class InputValidationForm2 : Form
    {
        public InputValidationForm2()
        {
            InitializeComponent();
        }

        /// <summary>
        ///     This method is triggered when the "delete" button is clicked
        ///     Clear all the textboxes and the errorProvider
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            tbName.Clear();
            tbDate.Clear();
            tbAmount.Clear();
            tbZipCode.Clear();
            errorProvider.Clear();
        }

        /// <summary>
        ///     This method is triggered when the "validate" button is clicked
        ///     Create the object with the provided data and display it in a new window
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void BtnValidate_Click(object sender, EventArgs e)
        {
            bool inputIsInvalid;
            string error;
            List<TextBox> allFields = new List<TextBox>
            {
                tbName,
                tbDate,
                tbAmount,
                tbZipCode
            };

            inputIsInvalid = false;
            error = "Invalid input";
            errorProvider.Clear();

            if (ErrorCheck.HasZipCodeError(tbZipCode, error, errorProvider))
                inputIsInvalid = true;
            if (ErrorCheck.HasAmountError(tbAmount, error, errorProvider))
                inputIsInvalid = true;
            if (ErrorCheck.HasDateError(tbDate, error, errorProvider))
                inputIsInvalid = true;
            if (ErrorCheck.HasNameError(tbName, error, errorProvider))
                inputIsInvalid = true;
            if (!DataCheck.FieldsAreFilled(allFields, errorProvider))
                inputIsInvalid = true;

            if (inputIsInvalid)
                SystemSounds.Beep.Play();
            else
            {
                Bill bill = new Bill(tbName.Text, tbDate.Text, tbAmount.Text, tbZipCode.Text);

                MessageBox.Show(bill.ToString(), "Validation completed", MessageBoxButtons.OK);
                BtnDelete_Click(this, e);
            }
        }

        /// <summary>
        ///     This method is triggered when the program is closed
        ///     Display a window to validate the exit
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void InputValidation_FormClosing(object sender, EventArgs e)
        {
            FormClosingEventArgs _e = (FormClosingEventArgs)e;
            DialogResult dialogResult = MessageBox.Show
            (
                "Do you want to quit the program ?",
                "END OF PROGRAM",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1
            );
            if (dialogResult == DialogResult.No)
                _e.Cancel = true;
        }
    }
}