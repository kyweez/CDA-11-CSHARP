using BILL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TOOLS;

namespace INPUT_VALIDATION_V1
{
    public partial class InputValidation : Form
    {
        private Bill currentBill;
        public InputValidation()
        {
            InitializeComponent();
            currentBill = new Bill();
        }

        public Bill CurrentBill
        {
            get => currentBill;
        }

        /// <summary>
        ///     This method is triggered when a textbox change
        ///     Checks if all textboxes are filled. If so, enable the validate button
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            List<TextBox> allFields = new List<TextBox>
            {
                tbName,
                tbDate,
                tbAmount,
                tbZipCode
            };

            if (!CheckData.FieldsAreFilled(allFields))
                btnValidate.Enabled = false;
            else
                btnValidate.Enabled = true;
        }

        /// <summary>
        ///     This method is triggered when the "delete" button is clicked
        ///     Clear all the textboxes and the errorProvider
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DeleteAllFields();
        }

        private void DeleteAllFields()
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

            //Form1 fenetre = new Form1();
            //DialogResult dr = fenetre.ShowDialog();
            //int result = fenetre.Coucou;

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

            if (inputIsInvalid)
                SystemSounds.Beep.Play();
            else
            {
                 currentBill = new Bill(tbName.Text, tbDate.Text, tbAmount.Text, tbZipCode.Text);

                MessageBox.Show(currentBill.ToString(), "Validation completed", MessageBoxButtons.OK);
                DeleteAllFields();
            }
        }

        /// <summary>
        ///     This method is triggered when the program is closed
        ///     Display a window to validate the exit
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void InputValidation_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show
            (
                "Do you want to quit the program ?",
                "END OF PROGRAM",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1
            );

            if (dialogResult == DialogResult.No)
                e.Cancel = true;
        }
    }
}