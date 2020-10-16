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
using TOOLS.ClassLibrary;
using BILL.ClassLibrary;


namespace INPUT_VALIDATION_V1
{
    public partial class InputValidation : Form
    {
        public InputValidation()
        {
            InitializeComponent();
        }

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

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            tbName.Clear();
            tbDate.Clear();
            tbAmount.Clear();
            tbZipCode.Clear();
            errorProvider.Clear();
        }

        private void BtnValidate_Click(object sender, EventArgs e)
        {
            bool inputIsInvalid;
            string error;

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
                Bill bill = new Bill(tbName.Text, tbDate.Text, tbAmount.Text, tbZipCode.Text);

                MessageBox.Show(bill.ToString(), "Validation completed", MessageBoxButtons.OK);
                BtnDelete_Click(this, e);
            }
        }

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